namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
    /// Cosmos i18n code: i18n_country_jilibasi <br />
    /// Cosmos region code: 600105
    /// </summary>
    public static partial class Kiribati
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kiribati()
        {
            _country = new CountryInfo
            {
                Country = Country.Kiribati,
                CountryCode = CountryCode.KI,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Kiribati,
                M49Code = "296",
                Cep1CrCode = 6_00_105,
                Alpha2Code = "KI",
                Alpha3Code = "KIR",
                Name = "The Republic of Kiribati",
                ShorterForm = "Kiribati",
                ChineseName = "基里巴斯共和国",
                ChineseShorterForm = "基里巴斯",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jilibasi <br />
        /// Cosmos region code: 600105
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jilibasi";

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