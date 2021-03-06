namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
    /// 台湾，中华人民共和国的一部分 <br />
    /// Taiwan, a part of China <br />
    /// Cosmos i18n code: i18n_country_cnhtaiwan <br />
    /// Cosmos region code: 10000100332
    /// </summary>
    public static partial class Taiwan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Taiwan()
        {
            _country = new CountryInfo
            {
                Country = Country.Taiwan,
                CountryCode = CountryCode.TW,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.China,
                M49Code = "158",
                Cep1CrCode = 1_00_001_0032,
                Alpha2Code = "TW",
                Alpha3Code = "TWN",
                Name = "Taiwan, China",
                ShorterForm = "Taiwan",
                ChineseName = "中华人民共和国台湾省",
                ChineseShorterForm = "台湾",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue,
                ExistenceCycle = new ExistenceCycle(19491001)
            };
        }

        /// <summary>
        /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan <br />
        /// Cosmos region code: 10000100332
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_cnhtaiwan";

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