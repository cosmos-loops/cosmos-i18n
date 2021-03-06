using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Congo Brazzaville regions
    /// </summary>
    public static partial class CongoBrazzaville
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Lékoumou
            /// </summary>
            public static EnumValues Lékoumou => EnumValues.Lékoumou;

            /// <summary>
            /// Kouilou
            /// </summary>
            public static EnumValues Kouilou => EnumValues.Kouilou;

            /// <summary>
            /// Likouala
            /// </summary>
            public static EnumValues Likouala => EnumValues.Likouala;

            /// <summary>
            /// Cuvette
            /// </summary>
            public static EnumValues Cuvette => EnumValues.Cuvette;

            /// <summary>
            /// Niari
            /// </summary>
            public static EnumValues Niari => EnumValues.Niari;

            /// <summary>
            /// Bouenza
            /// </summary>
            public static EnumValues Bouenza => EnumValues.Bouenza;

            /// <summary>
            /// Pool
            /// </summary>
            public static EnumValues Pool => EnumValues.Pool;

            /// <summary>
            /// Sangha
            /// </summary>
            public static EnumValues Sangha => EnumValues.Sangha;

            /// <summary>
            /// Plateaux
            /// </summary>
            public static EnumValues Plateaux => EnumValues.Plateaux;

            /// <summary>
            /// Cuvette-Ouest
            /// </summary>
            public static EnumValues CuvetteOuest => EnumValues.CuvetteOuest;

            /// <summary>
            /// Pointe-Noire
            /// </summary>
            public static EnumValues PointeNoire => EnumValues.PointeNoire;

            /// <summary>
            /// Brazzaville
            /// </summary>
            public static EnumValues Brazzaville => EnumValues.Brazzaville;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Congo Brazzaville regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Lékoumou
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(3_00_112_0002)]
            Lékoumou,

            /// <summary>
            /// Kouilou
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(3_00_112_0005)]
            Kouilou,

            /// <summary>
            /// Likouala
            /// </summary>
            [AliasInShort("7")]
            [RegionCode(3_00_112_0007)]
            Likouala,

            /// <summary>
            /// Cuvette
            /// </summary>
            [AliasInShort("8")]
            [RegionCode(3_00_112_0008)]
            Cuvette,

            /// <summary>
            /// Niari
            /// </summary>
            [AliasInShort("9")]
            [RegionCode(3_00_112_0009)]
            Niari,

            /// <summary>
            /// Bouenza
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(3_00_112_0011)]
            Bouenza,

            /// <summary>
            /// Pool
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(3_00_112_0012)]
            Pool,

            /// <summary>
            /// Sangha
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(3_00_112_0013)]
            Sangha,

            /// <summary>
            /// Plateaux
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(3_00_112_0014)]
            Plateaux,

            /// <summary>
            /// Cuvette-Ouest
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(3_00_112_0015)]
            CuvetteOuest,

            /// <summary>
            /// Pointe-Noire
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(3_00_112_0016)]
            PointeNoire,

            /// <summary>
            /// Brazzaville
            /// </summary>
            [AliasInShort("BZV")]
            [RegionCode(3_00_112_0001)]
            Brazzaville,

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