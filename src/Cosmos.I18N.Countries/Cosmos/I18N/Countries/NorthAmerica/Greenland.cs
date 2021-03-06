namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
    /// Cosmos i18n code: i18n_country_gelinlan <br />
    /// Cosmos region code: 400116
    /// </summary>
    public static partial class Greenland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Greenland()
        {
            _country = new CountryInfo
            {
                Country = Country.Greenland,
                CountryCode = CountryCode.GL,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Greenland,
                M49Code = "304",
                Cep1CrCode = 4_00_116,
                Alpha2Code = "GL",
                Alpha3Code = "GRL",
                Name = "Greenland",
                ChineseName = "格陵兰岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
        /// Cosmos i18n code: i18n_country_gelinlan <br />
        /// Cosmos region code: 400116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelinlan";

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