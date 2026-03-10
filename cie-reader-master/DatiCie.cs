using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using CieReader.Service;
using ImageMagick;

namespace CieReader
{
    public sealed class DatiCie
    {
        public string JsonCompleto { get; private set; } = string.Empty;

        public string Cognome { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string LocalitaNascita { get; private set; } = string.Empty;
        public string DataNascita { get; private set; } = string.Empty;
        public string ProvinciaNascita { get; private set; } = string.Empty;
        public string IndirizzoResidenza { get; private set; } = string.Empty;
        public string CittaResidenza { get; private set; } = string.Empty;
        public string ProvinciaResidenza { get; private set; } = string.Empty;
        public string CodiceFiscale { get; private set; } = string.Empty;
        public string ScadenzaCarta { get; private set; } = string.Empty;
        public string Mrz { get; private set; } = string.Empty;

        public MrzData MrzData { get; private set; } = new MrzData();

        public string ImagePathJp2 { get; private set; } = string.Empty;
        public string ImagePathJpg { get; private set; } = string.Empty;

        public static DatiCie ReadCie(string can)
        {
            using var reader = new Reader();
            string json = reader.ReadCardAsJson(can);

            return FromJson(json);
        }

        public static DatiCie FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                throw new ArgumentException("Il JSON della CIE è vuoto.", nameof(json));
            }

            using JsonDocument doc = JsonDocument.Parse(json);
            JsonElement root = doc.RootElement;

            string mrz = GetString(root, "mrz");
            CieImagePaths imagePaths = SaveCieImage(root);

            return new DatiCie
            {
                JsonCompleto = json,

                // Mantengo il mapping attuale per non alterare il comportamento che stavi già usando.
                // Se vuoi il mapping semanticamente corretto, inverti firstName/lastName.
                Cognome = GetString(root, "firstName"),
                Nome = GetString(root, "lastName"),

                LocalitaNascita = GetString(root, "birthCity"),
                DataNascita = GetString(root, "birthDate"),
                ProvinciaNascita = GetString(root, "birthProv"),
                IndirizzoResidenza = GetString(root, "address"),
                CittaResidenza = GetString(root, "city"),
                ProvinciaResidenza = GetString(root, "prov"),
                CodiceFiscale = GetString(root, "cf"),
                ScadenzaCarta = GetString(root, "dateExpire"),
                Mrz = mrz,
                MrzData = MrzData.Decode(mrz),
                ImagePathJp2 = imagePaths.Jp2Path,
                ImagePathJpg = imagePaths.JpgPath
            };
        }

        public static string? GetValidatedCan(string[] args)
        {
            string? can;

            if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
            {
                can = args[0].Trim();
            }
            else
            {
                Console.Write("CAN della CIE (codice di 6 cifre sul fronte, in basso a destra): ");
                can = Console.ReadLine()?.Trim();
            }

            return IsValidCan(can) ? can : null;
        }

        private static bool IsValidCan(string? can)
        {
            if (string.IsNullOrWhiteSpace(can) || can.Length != 6)
            {
                return false;
            }

            for (int i = 0; i < can.Length; i++)
            {
                if (!char.IsDigit(can[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetString(JsonElement root, string propertyName)
        {
            if (root.TryGetProperty(propertyName, out JsonElement value))
            {
                return value.GetString() ?? string.Empty;
            }

            return string.Empty;
        }

        private static CieImagePaths SaveCieImage(JsonElement root)
        {
            if (!root.TryGetProperty("cie_jpg2k_image", out JsonElement imageElement) ||
                imageElement.ValueKind != JsonValueKind.Array)
            {
                throw new InvalidOperationException("Il JSON non contiene il campo cie_jpg2k_image.");
            }

            byte[] imageBytes = imageElement.EnumerateArray()
                .Select(x =>
                {
                    int value = x.GetInt32();
                    if (value < 0 || value > 255)
                    {
                        throw new InvalidOperationException("Il campo cie_jpg2k_image contiene valori non validi.");
                    }

                    return (byte)value;
                })
                .ToArray();

            if (imageBytes.Length == 0)
            {
                throw new InvalidOperationException("Il campo cie_jpg2k_image è vuoto.");
            }

            string firstName = GetSafeFilePart(root, "firstName");
            string lastName = GetSafeFilePart(root, "lastName");
            string cf = GetSafeFilePart(root, "cf");

            string baseName = string.Join("_", new[] { lastName, firstName, cf }
                .Where(s => !string.IsNullOrWhiteSpace(s)));

            if (string.IsNullOrWhiteSpace(baseName))
            {
                baseName = "cie_foto";
            }

            string outputDirectory = AppContext.BaseDirectory;
            string jp2Path = Path.Combine(outputDirectory, baseName + ".jp2");
            string jpgPath = Path.Combine(outputDirectory, baseName + ".jpg");

            File.WriteAllBytes(jp2Path, imageBytes);

            try
            {
                using var image = new MagickImage(imageBytes);
                image.Format = MagickFormat.Jpg;
                image.Quality = 95;
                image.Write(jpgPath);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    "Il file JP2 è stato salvato, ma la conversione in JPG non è riuscita. Verifica che Magick.NET supporti JPEG 2000 nell'ambiente corrente.",
                    ex);
            }

            return new CieImagePaths
            {
                Jp2Path = jp2Path,
                JpgPath = jpgPath
            };
        }

        private static string GetSafeFilePart(JsonElement root, string propertyName)
        {
            if (!root.TryGetProperty(propertyName, out JsonElement element) ||
                element.ValueKind != JsonValueKind.String)
            {
                return string.Empty;
            }

            string? value = element.GetString();
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            char[] invalidChars = Path.GetInvalidFileNameChars();
            string cleaned = new string(value
                .Trim()
                .Select(ch => invalidChars.Contains(ch) ? '_' : ch)
                .ToArray());

            return cleaned.Replace(' ', '_');
        }

        private sealed class CieImagePaths
        {
            public string Jp2Path { get; set; } = string.Empty;
            public string JpgPath { get; set; } = string.Empty;
        }
    }
}