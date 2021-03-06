namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_sinuowenniya <br />
    /// Cosmos region code: 200138
    /// </summary>
    public static partial class Slovenia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Slovenia()
        {
            _country = new CountryInfo
            {
                Country = Country.Slovenia,
                CountryCode = CountryCode.SI,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Slovenia,
                M49Code = "705",
                Cep1CrCode = 2_00_138,
                Alpha2Code = "SI",
                Alpha3Code = "SVN",
                Name = "The Republic of Slovenia",
                ShorterForm = "Slovenia",
                ChineseName = "斯洛文尼亚共和国",
                ChineseShorterForm = "斯洛文尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_sinuowenniya <br />
        /// Cosmos region code: 200138
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sinuowenniya";

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