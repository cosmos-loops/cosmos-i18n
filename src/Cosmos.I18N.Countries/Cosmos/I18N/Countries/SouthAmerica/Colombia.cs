namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_gelunbiya <br />
    /// Cosmos region code: 500102
    /// </summary>
    public static partial class Colombia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Colombia()
        {
            _country = new CountryInfo
            {
                Country = Country.Colombia,
                CountryCode = CountryCode.CO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Colombia,
                M49Code = "170",
                Cep1CrCode = 5_00_102,
                Alpha2Code = "CO",
                Alpha3Code = "COL",
                Name = "The Republic of Colombia",
                ShorterForm = "Colombia",
                ChineseName = "哥伦比亚共和国",
                ChineseShorterForm = "哥伦比亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya <br />
        /// Cosmos region code: 500102
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelunbiya";

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