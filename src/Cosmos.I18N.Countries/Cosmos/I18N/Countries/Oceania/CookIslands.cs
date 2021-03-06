using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
    /// Cosmos i18n code: i18n_country_kukequndao <br />
    /// Cosmos region code: 600102
    /// </summary>
    public static class CookIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CookIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.CookIslands,
                CountryCode = CountryCode.CK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CookIslands,
                M49Code = "184",
                Cep1CrCode = 6_00_102,
                Alpha2Code = "CK",
                Alpha3Code = "COK",
                Name = "The Cook Islands",
                ShorterForm = "Cook Islands",
                ChineseName = "库克群岛",
                ChineseShorterForm = "瑞士",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao <br />
        /// Cosmos region code: 600102
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kukequndao";

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