namespace CieReader
{
    public sealed class MrzData
    {
        public string Raw { get; set; } = string.Empty;
        public string Line1 { get; set; } = string.Empty;
        public string Line2 { get; set; } = string.Empty;
        public string Line3 { get; set; } = string.Empty;

        public string DocumentType { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string Sex { get; set; } = string.Empty;
        public string ExpiryDate { get; set; } = string.Empty;
        public string Citizenship { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string GivenNames { get; set; } = string.Empty;

        public bool DocumentNumberCheckOk { get; set; }
        public bool BirthDateCheckOk { get; set; }
        public bool ExpiryDateCheckOk { get; set; }
        public bool FinalCheckOk { get; set; }

        public string DocumentNumberCheckDigit { get; set; } = string.Empty;
        public string BirthDateCheckDigit { get; set; } = string.Empty;
        public string ExpiryDateCheckDigit { get; set; } = string.Empty;
        public string FinalCheckDigit { get; set; } = string.Empty;

        public static MrzData Decode(string mrz)
        {
            if (string.IsNullOrWhiteSpace(mrz))
            {
                return new MrzData();
            }

            string normalized = mrz.Replace("\r", "").Replace("\n", "");

            if (normalized.Length < 90)
            {
                return new MrzData { Raw = normalized };
            }

            string line1 = normalized.Substring(0, 30);
            string line2 = normalized.Substring(30, 30);
            string line3 = normalized.Substring(60, 30);

            string documentNumberField = line1.Substring(5, 9);
            string documentNumberCheckDigit = line1.Substring(14, 1);

            string birthDateField = line2.Substring(0, 6);
            string birthDateCheckDigit = line2.Substring(6, 1);

            string expiryDateField = line2.Substring(8, 6);
            string expiryDateCheckDigit = line2.Substring(14, 1);

            string finalComposite =
                line1.Substring(5, 25) +
                line2.Substring(0, 7) +
                line2.Substring(8, 7) +
                line2.Substring(18, 11);

            string finalCheckDigit = line2.Substring(29, 1);

            return new MrzData
            {
                Raw = normalized,
                Line1 = line1,
                Line2 = line2,
                Line3 = line3,

                DocumentType = CleanMrz(line1.Substring(0, 2)),
                Nationality = CleanMrz(line1.Substring(2, 3)),
                DocumentNumber = CleanMrz(documentNumberField),
                BirthDate = ParseMrzDate(birthDateField),
                Sex = DecodeSex(line2.Substring(7, 1)),
                ExpiryDate = ParseMrzDate(expiryDateField),
                Citizenship = CleanMrz(line2.Substring(15, 3)),
                Surname = ExtractSurname(line3),
                GivenNames = ExtractGivenNames(line3),

                DocumentNumberCheckDigit = documentNumberCheckDigit,
                BirthDateCheckDigit = birthDateCheckDigit,
                ExpiryDateCheckDigit = expiryDateCheckDigit,
                FinalCheckDigit = finalCheckDigit,

                DocumentNumberCheckOk = VerifyMrzCheckDigit(documentNumberField, documentNumberCheckDigit),
                BirthDateCheckOk = VerifyMrzCheckDigit(birthDateField, birthDateCheckDigit),
                ExpiryDateCheckOk = VerifyMrzCheckDigit(expiryDateField, expiryDateCheckDigit),
                FinalCheckOk = VerifyMrzCheckDigit(finalComposite, finalCheckDigit)
            };
        }

        private static bool VerifyMrzCheckDigit(string field, string checkDigit)
        {
            if (string.IsNullOrWhiteSpace(checkDigit) || checkDigit.Length != 1)
            {
                return false;
            }

            int expected = ComputeMrzCheckDigit(field);
            int actual = MrzCharValue(checkDigit[0]);

            return expected == actual;
        }

        private static int ComputeMrzCheckDigit(string value)
        {
            int[] weights = { 7, 3, 1 };
            int sum = 0;

            for (int i = 0; i < value.Length; i++)
            {
                int charValue = MrzCharValue(value[i]);
                int weight = weights[i % 3];
                sum += charValue * weight;
            }

            return sum % 10;
        }

        private static int MrzCharValue(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return c - '0';
            }

            if (c >= 'A' && c <= 'Z')
            {
                return c - 'A' + 10;
            }

            if (c == '<')
            {
                return 0;
            }

            return 0;
        }

        private static string CleanMrz(string value)
        {
            return (value ?? string.Empty).Replace("<", "").Trim();
        }

        private static string DecodeSex(string value)
        {
            return value switch
            {
                "M" => "Maschile",
                "F" => "Femminile",
                _ => value
            };
        }

        private static string ParseMrzDate(string yymmdd)
        {
            if (string.IsNullOrWhiteSpace(yymmdd) || yymmdd.Length != 6)
            {
                return string.Empty;
            }

            if (!int.TryParse(yymmdd.Substring(0, 2), out int yy) ||
                !int.TryParse(yymmdd.Substring(2, 2), out int mm) ||
                !int.TryParse(yymmdd.Substring(4, 2), out int dd))
            {
                return yymmdd;
            }

            int currentTwoDigitYear = DateTime.Now.Year % 100;
            int fullYear = yy <= currentTwoDigitYear ? 2000 + yy : 1900 + yy;

            try
            {
                return new DateTime(fullYear, mm, dd).ToString("dd/MM/yyyy");
            }
            catch
            {
                return yymmdd;
            }
        }

        private static string ExtractSurname(string line3)
        {
            if (string.IsNullOrWhiteSpace(line3))
            {
                return string.Empty;
            }

            string[] parts = line3.Split(new[] { "<<" }, StringSplitOptions.None);
            return parts.Length > 0 ? CleanMrz(parts[0]).Replace("<", " ") : string.Empty;
        }

        private static string ExtractGivenNames(string line3)
        {
            if (string.IsNullOrWhiteSpace(line3))
            {
                return string.Empty;
            }

            string[] parts = line3.Split(new[] { "<<" }, StringSplitOptions.None);
            if (parts.Length < 2)
            {
                return string.Empty;
            }

            return parts[1].Replace("<", " ").Trim();
        }
    }
}