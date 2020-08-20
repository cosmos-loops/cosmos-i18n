namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_suomali <br />
    /// Cosmos region code: 300152
    /// </summary>
    public static partial class Somalia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Somalia() {
            _country = new CountryInfo {
                CountryCode = CountryCode.SO,
                Country = Country.Somalia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Somalia,
                M49Code = "706",
                Cep1CrCode= 3_00_152,
                Alpha2Code = "SO",
                Alpha3Code = "SOM",
                Name = "The Federal Republic of Somalia",
                ShorterForm = "Somalia",
                ChineseName = "索马里联邦共和国",
                ChineseShorterForm = "索马里",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_suomali <br />
        /// Cosmos region code: 300152
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_suomali";

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