using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Morocco Regions
    /// </summary>
    public static partial  class Morocco 
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Doukkala-Abda
        /// </summary>
        public static EnumValues DoukkalaAbda => EnumValues.DoukkalaAbda;

        /// <summary>
        /// Marrakesh-Tensift-El Haouz
        /// </summary>
        public static EnumValues MarrakeshTensiftElHaouz => EnumValues.MarrakeshTensiftElHaouz;

        /// <summary>
        /// Tadla-Azilal
        /// </summary>
        public static EnumValues TadlaAzilal => EnumValues.TadlaAzilal;

        /// <summary>
        /// Souss-Massa-Drâa
        /// </summary>
        public static EnumValues SoussMassaDrâa => EnumValues.SoussMassaDrâa;

        /// <summary>
        /// Guelmim-Es Semara
        /// </summary>
        public static EnumValues GuelmimEsSemara => EnumValues.GuelmimEsSemara;

        /// <summary>
        /// Laâyoune-Boujdour-Sakia El Hamra
        /// </summary>
        public static EnumValues LaâyouneBoujdourSakiaElHamra => EnumValues.LaâyouneBoujdourSakiaElHamra;

        /// <summary>
        /// Oued Ed-Dahab-Lagouira
        /// </summary>
        public static EnumValues OuedEdDahabLagouira => EnumValues.OuedEdDahabLagouira;

        /// <summary>
        /// Tangier-Tétouan  
        /// </summary>
        public static EnumValues TangierTétouan => EnumValues.TangierTétouan;

        /// <summary>
        /// Gharb-Chrarda-Béni Hssen
        /// </summary>
        public static EnumValues GharbChrardaBéniHssen => EnumValues.GharbChrardaBéniHssen;

        /// <summary>
        /// Taza-Al Hoceima-Taounate
        /// </summary>
        public static EnumValues TazaAlHoceimaTaounate => EnumValues.TazaAlHoceimaTaounate;

        /// <summary>
        /// Oriental
        /// </summary>
        public static EnumValues Oriental => EnumValues.Oriental;

        /// <summary>
        /// Fès-Boulemane
        /// </summary>
        public static EnumValues FèsBoulemane => EnumValues.FèsBoulemane;

        /// <summary>
        /// Meknès-Tafilalet
        /// </summary>
        public static EnumValues MeknèsTafilalet => EnumValues.MeknèsTafilalet;

        /// <summary>
        /// Rabat-Salé-Zemmour-Zaer
        /// </summary>
        public static EnumValues RabatSaléZemmourZaer => EnumValues.RabatSaléZemmourZaer;

        /// <summary>
        /// Grand Casablanca
        /// </summary>
        public static EnumValues GrandCasablanca => EnumValues.GrandCasablanca;

        /// <summary>
        /// Chaouia-Ouardigha
        /// </summary>
        public static EnumValues ChaouiaOuardigha => EnumValues.ChaouiaOuardigha;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Morocco regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Doukkala-Abda
            /// </summary>
            [AliasInShort("10")][RegionCode(3_00_139_0010)] DoukkalaAbda,

            /// <summary>
            /// Marrakesh-Tensift-El Haouz
            /// </summary>
            [AliasInShort("11")][RegionCode(3_00_139_0011)] MarrakeshTensiftElHaouz,

            /// <summary>
            /// Tadla-Azilal
            /// </summary>
            [AliasInShort("12")][RegionCode(3_00_139_0012)] TadlaAzilal,

            /// <summary>
            /// Souss-Massa-Drâa
            /// </summary>
            [AliasInShort("13")][RegionCode(3_00_139_0013)] SoussMassaDrâa,

            /// <summary>
            /// Guelmim-Es Semara
            /// </summary>
            [AliasInShort("14")][RegionCode(3_00_139_0014)] GuelmimEsSemara,

            /// <summary>
            /// Laâyoune-Boujdour-Sakia El Hamra
            /// </summary>
            [AliasInShort("15")][RegionCode(3_00_139_0015)] LaâyouneBoujdourSakiaElHamra,

            /// <summary>
            /// Oued Ed-Dahab-Lagouira
            /// </summary>
            [AliasInShort("16")][RegionCode(3_00_139_0016)] OuedEdDahabLagouira,

            /// <summary>
            /// Tangier-Tétouan
            /// </summary>
            [AliasInShort("01")][RegionCode(3_00_139_0001)] TangierTétouan,

            /// <summary>
            /// Gharb-Chrarda-Béni Hssen
            /// </summary>
            [AliasInShort("02")][RegionCode(3_00_139_0002)] GharbChrardaBéniHssen,

            /// <summary>
            /// Taza-Al Hoceima-Taounate
            /// </summary>
            [AliasInShort("03")][RegionCode(3_00_139_0003)] TazaAlHoceimaTaounate,

            /// <summary>
            /// Oriental
            /// </summary>
            [AliasInShort("04")][RegionCode(3_00_139_0004)] Oriental,

            /// <summary>
            /// Fès-Boulemane
            /// </summary>
            [AliasInShort("05")][RegionCode(3_00_139_0005)] FèsBoulemane,

            /// <summary>
            /// Meknès-Tafilalet
            /// </summary>
            [AliasInShort("06")][RegionCode(3_00_139_0006)] MeknèsTafilalet,

            /// <summary>
            /// Rabat-Salé-Zemmour-Zaer
            /// </summary>
            [AliasInShort("07")][RegionCode(3_00_139_0007)] RabatSaléZemmourZaer,

            /// <summary>
            /// Grand Casablanca
            /// </summary>
            [AliasInShort("08")][RegionCode(3_00_139_0008)] GrandCasablanca,

            /// <summary>
            /// Chaouia-Ouardigha
            /// </summary>
            [AliasInShort("09")][RegionCode(3_00_139_0009)] ChaouiaOuardigha,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
        }

        #endregion

        #region All regions getter

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}