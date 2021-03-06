namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
    /// Cosmos i18n code: i18n_country_babaduosi <br />
    /// Cosmos region code: 400106
    /// </summary>
    public static partial class Barbados
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Barbados()
        {
            _country = new CountryInfo
            {
                Country = Country.Barbados,
                CountryCode = CountryCode.BB,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Barbados,
                M49Code = "052",
                Cep1CrCode = 4_00_106,
                Alpha2Code = "BB",
                Alpha3Code = "BRB",
                Name = "Barbados ",
                ChineseName = "巴巴多斯",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi <br />
        /// Cosmos region code: 400106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_babaduosi";

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