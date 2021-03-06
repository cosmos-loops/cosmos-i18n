using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
    /// Cosmos i18n code: i18n_country_xila <br />
    /// Cosmos region code: 200115
    /// </summary>
    public static class Greece
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Greece()
        {
            _country = new CountryInfo
            {
                Country = Country.Greece,
                CountryCode = CountryCode.GR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Greece,
                M49Code = "300",
                Cep1CrCode = 2_00_115,
                Alpha2Code = "GR",
                Alpha3Code = "GRC",
                Name = "The Republic of Greece",
                ShorterForm = "Greece",
                ChineseName = "希腊共和国",
                ChineseShorterForm = "希腊",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
        /// Cosmos i18n code: i18n_country_xila <br />
        /// Cosmos region code: 200115
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xila";

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