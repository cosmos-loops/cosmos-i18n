namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
    /// Cosmos i18n code: i18n_country_yindu <br />
    /// Cosmos region code: 100013
    /// </summary>
    public static partial class India
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static India()
        {
            _country = new CountryInfo
            {
                Country = Country.India,
                CountryCode = CountryCode.IN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.India,
                M49Code = "356",
                Cep1CrCode = 1_00_013,
                Alpha2Code = "IN",
                Alpha3Code = "IND",
                Name = "Republic of India",
                ShorterForm = "India",
                ChineseName = "印度共和国",
                ChineseShorterForm = "印度",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
        /// Cosmos i18n code: i18n_country_yindu <br />
        /// Cosmos region code: 100013
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yindu";

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