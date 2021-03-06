namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 西班牙（The Kingdom of Spain，欧洲，ES，ESP，724），西班牙王国 <br />
    /// Cosmos i18n code: i18n_country_xibanya <br />
    /// Cosmos region code: 200015
    /// </summary>
    public static partial class Spain
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Spain()
        {
            _country = new CountryInfo
            {
                Country = Country.Spain,
                CountryCode = CountryCode.ES,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Spain,
                M49Code = "724",
                Cep1CrCode = 2_00_015,
                Alpha2Code = "ES",
                Alpha3Code = "ESP",
                Name = "The Kingdom of Spain",
                ShorterForm = "Spain",
                ChineseName = "西班牙王国",
                ChineseShorterForm = "西班牙",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 西班牙（The Kingdom of Spain，欧洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya <br />
        /// Cosmos region code: 200015
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xibanya";

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