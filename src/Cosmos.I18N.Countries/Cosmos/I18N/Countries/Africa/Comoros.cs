namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
    /// Cosmos i18n code: i18n_country_kemoluo <br />
    /// Cosmos region code: 300111
    /// </summary>
    public static partial class Comoros
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Comoros()
        {
            _country = new CountryInfo
            {
                Country = Country.Comoros,
                CountryCode = CountryCode.KM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Comoros,
                M49Code = "174",
                Cep1CrCode = 3_00_111,
                Alpha2Code = "KM",
                Alpha3Code = "COM",
                Name = "Union of Comoros",
                ShorterForm = "Comoros",
                ChineseName = "科摩罗联盟",
                ChineseShorterForm = "科摩罗",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
        /// Cosmos i18n code: i18n_country_kemoluo <br />
        /// Cosmos region code: 300111
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kemoluo";

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