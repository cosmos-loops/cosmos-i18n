using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
    /// Cosmos i18n code: i18n_country_kaiman <br />
    /// Cosmos region code: 400110
    /// </summary>
    public static class CaymanIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CaymanIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.CaymanIslands,
                CountryCode = CountryCode.KY,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "136",
                Cep1CrCode = 4_00_110,
                Alpha2Code = "KY",
                Alpha3Code = "CYM",
                Name = "Cayman Islands",
                ChineseName = "开曼群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
        /// Cosmos i18n code: i18n_country_kaiman <br />
        /// Cosmos region code: 400110
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kaiman";

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