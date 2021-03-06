namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_miandian <br />
    /// Cosmos region code: 100127
    /// </summary>
    public static partial class Myanmar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Myanmar()
        {
            _country = new CountryInfo
            {
                Country = Country.Myanmar,
                CountryCode = CountryCode.MM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Myanmar,
                M49Code = "104",
                Cep1CrCode = 1_00_127,
                Alpha2Code = "MM",
                Alpha3Code = "MMR",
                Name = "The Republic of the Union of Myanmar",
                ShorterForm = "Myanmar",
                ChineseName = "缅甸联邦共和国",
                ChineseShorterForm = "缅甸",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_miandian <br />
        /// Cosmos region code: 100127
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_miandian";

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