namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
    /// Cosmos i18n code: i18n_country_guba <br />
    /// Cosmos region code: 400101
    /// </summary>
    public static partial class Cuba
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Cuba()
        {
            _country = new CountryInfo
            {
                Country = Country.Cuba,
                CountryCode = CountryCode.CU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Cuba,
                M49Code = "192",
                Cep1CrCode = 4_00_101,
                Alpha2Code = "CU",
                Alpha3Code = "CUB",
                Name = "The Republic of Cuba",
                ShorterForm = "Cuba",
                ChineseName = "古巴共和国",
                ChineseShorterForm = "古巴",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba <br />
        /// Cosmos region code: 400101
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guba";

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