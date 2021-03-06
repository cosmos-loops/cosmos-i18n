namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
    /// Cosmos i18n code: i18n_country_saineijiaer <br />
    /// Cosmos region code: 300151
    /// </summary>
    public static partial class Senegal {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Senegal() {
            _country = new CountryInfo {
                Country = Country.Senegal,
                CountryCode = CountryCode.SN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Senegal,
                M49Code = "686",
                Cep1CrCode = 3_00_151,
                Alpha2Code = "SN",
                Alpha3Code = "SEN",
                Name = "The Republic of Senegal",
                ShorterForm = "Senegal",
                ChineseName = "塞内加尔共和国",
                ChineseShorterForm = "塞内加尔",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saineijiaer <br />
        /// Cosmos region code: 300151
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saineijiaer";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

        /// <summary>
        /// Get Cosmos Region Identity Code (CEP-1/IICode)
        /// </summary>
        public static string CosmosIdentityCode => _country.I18NIdentityCode;

        /// <summary>
        /// Get M49 code / ISO 3166-1 numeric
        /// </summary>
        public static string M49Code => _country.M49Code;

        /// <summary>
        /// Get Alpha2 code / ISO 3166-1 alpha-2
        /// </summary>
        public static string Alpha2Code => _country.Alpha2Code;

        /// <summary>
        /// Get Alpha3 code / ISO 3166-1 alpha-3
        /// </summary>
        public static string Alpha3Code => _country.Alpha3Code;
    }
}