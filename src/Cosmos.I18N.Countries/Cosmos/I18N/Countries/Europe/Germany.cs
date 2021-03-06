namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 德国（The Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_deguo <br />
    /// Cosmos region code: 200002
    /// </summary>
    public static partial class Germany
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Germany()
        {
            _country = new CountryInfo
            {
                Country = Country.Germany,
                CountryCode = CountryCode.DE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Germany,
                M49Code = "276",
                Cep1CrCode = 2_00_002,
                Alpha2Code = "DE",
                Alpha3Code = "DEU",
                Name = "The Federal Republic of Germany",
                ShorterForm = "Germany",
                ChineseName = "德意志联邦共和国",
                ChineseShorterForm = "德国",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 德国（The Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo <br />
        /// Cosmos region code: 200002
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_deguo";

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