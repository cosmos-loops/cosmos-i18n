using System.Collections.Generic;

namespace Cosmos.I18N.Countries {
    public static partial class CountryManager {
        private static partial class InitOpts {
            public static Dictionary<Country, CountryCode> Map1 = new Dictionary<Country, CountryCode> {
                {Country.Andorra, CountryCode.AD},
                {Country.Afghanistan, CountryCode.AF},
                {Country.Algeria, CountryCode.DZ},
                {Country.AntiguaAndBarbuda, CountryCode.AG},
                {Country.Anguilla, CountryCode.AI},
                {Country.Armenia, CountryCode.AM},
                {Country.Angola, CountryCode.AO},
                {Country.Antarctica, CountryCode.AQ},
                {Country.Argentina, CountryCode.AR},
                {Country.AmericanSamoa, CountryCode.AS},
                {Country.Austria, CountryCode.AT},
                {Country.Australia, CountryCode.AU},
                {Country.AlandIslands, CountryCode.AX},
                {Country.Aruba, CountryCode.AW},
                {Country.Azerbaijan, CountryCode.AZ},
                {Country.BosniaAndHerzegovina, CountryCode.BA},
                {Country.Barbados, CountryCode.BB},
                {Country.Bangladesh, CountryCode.BD},
                {Country.Belgium, CountryCode.BE},
                {Country.BurkinaFaso, CountryCode.BF},
                {Country.Bulgaria, CountryCode.BG},
                {Country.Bahrain, CountryCode.BH},
                {Country.Burundi, CountryCode.BI},
                {Country.Benin, CountryCode.BJ},
                {Country.Bermuda, CountryCode.BM},
                {Country.Brunei, CountryCode.BN},
                {Country.Bolivia, CountryCode.BO},
                {Country.Bonaire, CountryCode.BQ},
                {Country.Brazil, CountryCode.BR},
                {Country.Bahamas, CountryCode.BS},
                {Country.Bhutan, CountryCode.BT},
                {Country.BouvetIsland, CountryCode.BV},
                {Country.Botswana, CountryCode.BW},
                {Country.Belarus, CountryCode.BY},
                {Country.Belize, CountryCode.BZ},
                {Country.Cameroun, CountryCode.CM},
                {Country.Canada, CountryCode.CA},
                {Country.CapeVerde, CountryCode.CV},
                {Country.China, CountryCode.CN},
                {Country.Chile, CountryCode.CL},
                {Country.Colombia, CountryCode.CO},
                {Country.CongoBrazzaville, CountryCode.CG},
                {Country.CentralAfrican, CountryCode.CF},
                {Country.CongoKinshasa, CountryCode.CD},
                {Country.CocosIslands, CountryCode.CC},
                {Country.CostaRica, CountryCode.CR},
                {Country.CookIslands, CountryCode.CK},
                {Country.CotedIvoire, CountryCode.CI},
                {Country.Cuba, CountryCode.CU},
                {Country.Curaçao, CountryCode.CW},
                {Country.ChristmasIsland, CountryCode.CX},
                {Country.Cyprus, CountryCode.CY},
                {Country.Czechia, CountryCode.CZ},
                {Country.Denmark, CountryCode.DK},
                {Country.Dominica, CountryCode.DM},
                {Country.Dominican, CountryCode.DO},
                {Country.Djibouti, CountryCode.DJ},
                {Country.Ecuador, CountryCode.EC},
                {Country.Estonia, CountryCode.EE},
                {Country.Egypt, CountryCode.EG},
                {Country.Eritrea, CountryCode.ER},
                {Country.Ethiopia, CountryCode.ET},
                {Country.FalklandIslands, CountryCode.FK},
                {Country.Faroe, CountryCode.FO},
                {Country.Fiji, CountryCode.FJ},
                {Country.Finland, CountryCode.FI},
                {Country.France, CountryCode.FR},
                {Country.Georgia, CountryCode.GE},
                {Country.Germany, CountryCode.DE},
                {Country.Grenada, CountryCode.GD},
                {Country.Guiana, CountryCode.GF},
                {Country.Guinea, CountryCode.GN},
                {Country.GuineaBissau, CountryCode.GW},
                {Country.EquatorialGuinea, CountryCode.GQ},
                {Country.Gabon, CountryCode.GA},
                {Country.Ghana, CountryCode.GH},
                {Country.Gibraltar, CountryCode.GI},
                {Country.Greenland, CountryCode.GL},
                {Country.Gambia, CountryCode.GM},
                {Country.Guadeloupe, CountryCode.GP},
                {Country.Guatemala, CountryCode.GT},
                {Country.Guam, CountryCode.GU},
                {Country.Greece, CountryCode.GR},
                {Country.Guyana, CountryCode.GY},
                {Country.HIMI, CountryCode.HM},
                {Country.Honduras, CountryCode.HN},
                {Country.HongKong, CountryCode.HK},
                {Country.Croatia, CountryCode.HR},
                {Country.Haiti, CountryCode.HT},
                {Country.Hungary, CountryCode.HU},
                {Country.Vatican, CountryCode.VA},
                {Country.Indonesia, CountryCode.ID},
                {Country.Israel, CountryCode.IL},
                {Country.India, CountryCode.IN},
                {Country.Iraq, CountryCode.IQ},
                {Country.Iran, CountryCode.IR},
                {Country.Iceland, CountryCode.IS},
                {Country.Ireland, CountryCode.IE},
                {Country.Italy, CountryCode.IT},
                {Country.BritishIndianOceanTerritory, CountryCode.IO},
                {Country.Japan, CountryCode.JP},
                {Country.Jamaica, CountryCode.JM},
                {Country.Jersey, CountryCode.JE},
                {Country.Jordan, CountryCode.JO},
                {Country.Kenya, CountryCode.KE},
                {Country.Kiribati, CountryCode.KI},
                {Country.Kyrgyzstan, CountryCode.KG},
                {Country.Comoros, CountryCode.KM},
                {Country.SaintKittsAndNevis, CountryCode.KN},
                {Country.NorthKorea, CountryCode.KP},
                {Country.SouthKorea, CountryCode.KR},
                {Country.Cambodia, CountryCode.KH},
                {Country.CaymanIslands, CountryCode.KY},
                {Country.Kuwait, CountryCode.KW},
                {Country.Kazakhstan, CountryCode.KZ},
                {Country.LaoPDR, CountryCode.LA},
                {Country.Lebanon, CountryCode.LB},
                {Country.SaintLucia, CountryCode.LC},
                {Country.Liechtenstein, CountryCode.LI},
                {Country.SriLanka, CountryCode.LK},
                {Country.Liberia, CountryCode.LR},
                {Country.Lesotho, CountryCode.LS},
                {Country.Lithuania, CountryCode.LT},
                {Country.Luxembourg, CountryCode.LU},
                {Country.Latvia, CountryCode.LV},
                {Country.Libya, CountryCode.LY},
                {Country.Macao, CountryCode.MO},
                {Country.Mann, CountryCode.IM},
                {Country.Mayotte, CountryCode.YT},
                {Country.Micronesia, CountryCode.FM},
                {Country.Morocco, CountryCode.MA},
                {Country.Monaco, CountryCode.MC},
                {Country.Moldova, CountryCode.MD},
                {Country.Montenegro, CountryCode.ME},
                {Country.SaintMartinFrenchPart, CountryCode.MF},
                {Country.SintMaartenDutchPart, CountryCode.SX},
                {Country.Syrian, CountryCode.SY},
                {Country.Swaziland, CountryCode.SZ},
                {Country.Madagascar, CountryCode.MG},
                {Country.MarshallIslands, CountryCode.MH},
                {Country.Macedonia, CountryCode.MK},
                {Country.Mali, CountryCode.ML},
                {Country.Myanmar, CountryCode.MM},
                {Country.Mongolia, CountryCode.MN},
                {Country.NorthernMarianaIslands, CountryCode.MP},
                {Country.Martinique, CountryCode.MQ},
                {Country.Mauritania, CountryCode.MR},
                {Country.Montserrat, CountryCode.MS},
                {Country.Malta, CountryCode.MT},
                {Country.Mauritius, CountryCode.MU},
                {Country.Maldives, CountryCode.MV},
                {Country.Malawi, CountryCode.MW},
                {Country.Malaysia, CountryCode.MY},
                {Country.Mozambique, CountryCode.MZ},
                {Country.Namibia, CountryCode.NA},
                {Country.Mexico, CountryCode.MX},
                {Country.NewCaledonia, CountryCode.NC},
                {Country.NorfolkIsland, CountryCode.NF},
                {Country.Nepal, CountryCode.NP},
                {Country.Nauru, CountryCode.NR},
                {Country.Nicaragua, CountryCode.NI},
                {Country.Niue, CountryCode.NU},
                {Country.NewZealand, CountryCode.NZ},
                {Country.Niger, CountryCode.NE},
                {Country.Nigeria, CountryCode.NG},
                {Country.Netherlands, CountryCode.NL},
                {Country.Oman, CountryCode.OM},
                {Country.Panama, CountryCode.PA},
                {Country.Paraguay, CountryCode.PY},
                {Country.Peru, CountryCode.PE},
                {Country.Polynesia, CountryCode.PF},
                {Country.PapuaNewGuinea, CountryCode.PG},
                {Country.Philippines, CountryCode.PH},
                {Country.Pakistan, CountryCode.PK},
                {Country.Poland, CountryCode.PL},
                {Country.SaintPierreAndMiquelon, CountryCode.PM},
                {Country.Pitcairn, CountryCode.PN},
                {Country.PuertoRico, CountryCode.PR},
                {Country.Palestine, CountryCode.PS},
                {Country.Portugal, CountryCode.PT},
                {Country.Palau, CountryCode.PW},
                {Country.Qatar, CountryCode.QA},
                {Country.Réunion, CountryCode.RE},
                {Country.Romania, CountryCode.RO},
                {Country.Norway, CountryCode.NO},
                {Country.Russia, CountryCode.RU},
                {Country.Rwanda, CountryCode.RW},
                {Country.SGSSI, CountryCode.GS},
                {Country.SaintBarts, CountryCode.BL},
                {Country.Samoa, CountryCode.WS},
                {Country.Serbia, CountryCode.RS},
                {Country.SaudiArabia, CountryCode.SA},
                {Country.SolomonIslands, CountryCode.SB},
                {Country.Seychelles, CountryCode.SC},
                {Country.Sudan, CountryCode.SD},
                {Country.Sweden, CountryCode.SE},
                {Country.Singapore, CountryCode.SG},
                {Country.Slovenia, CountryCode.SI},
                {Country.SaintHelena, CountryCode.SH},
                {Country.SvalbardAndJanMayen, CountryCode.SJ},
                {Country.SouthAfrica, CountryCode.ZA},
                {Country.Slovakia, CountryCode.SK},
                {Country.SierraLeone, CountryCode.SL},
                {Country.SanMarino, CountryCode.SM},
                {Country.Senegal, CountryCode.SN},
                {Country.Somalia, CountryCode.SO},
                {Country.Suriname, CountryCode.SR},
                {Country.SouthSudan, CountryCode.SS},
                {Country.SaoTomeAndPrincipe, CountryCode.ST},
                {Country.StVAndG, CountryCode.VC},
                {Country.Spain, CountryCode.ES},
                {Country.Switzerland, CountryCode.CH},
                {Country.ElSalvador, CountryCode.SV},
                {Country.Taiwan, CountryCode.TW},
                {Country.Tanzania, CountryCode.TZ},
                {Country.TrinidadAndTobago, CountryCode.TT},
                {Country.Turkey, CountryCode.TR},
                {Country.Tuvalu, CountryCode.TV},
                {Country.TurksAndCaicosIslands, CountryCode.TC},
                {Country.Chad, CountryCode.TD},
                {Country.FrenchSouthernTerritories, CountryCode.TF},
                {Country.Togo, CountryCode.TG},
                {Country.Thailand, CountryCode.TH},
                {Country.Tajikistan, CountryCode.TJ},
                {Country.Tokelau, CountryCode.TK},
                {Country.EastTimor, CountryCode.TL},
                {Country.Turkmenistan, CountryCode.TM},
                {Country.Tunisia, CountryCode.TN},
                {Country.Tonga, CountryCode.TO},
                {Country.Ukraine, CountryCode.UA},
                {Country.Uruguay, CountryCode.UY},
                {Country.Uganda, CountryCode.UG},
                {Country.UnitedKingdom, CountryCode.GB},
                {Country.UnitedStates, CountryCode.US},
                {Country.UnitedStatesMinorOutlyingIslands, CountryCode.UM},
                {Country.UnitedArabEmirates, CountryCode.AE},
                {Country.Uzbekistan, CountryCode.UZ},
                {Country.Venezuela, CountryCode.VE},
                {Country.Vietnam, CountryCode.VN},
                {Country.VirginIslandsBritish, CountryCode.VG},
                {Country.VirginIslandsUS, CountryCode.VI},
                {Country.Vanuatu, CountryCode.VU},
                {Country.WallisAndFutuna, CountryCode.WF},
                {Country.WesternSahara, CountryCode.EH},
                {Country.Kosovo, CountryCode.XK},
                {Country.Yemen, CountryCode.YE},
                {Country.Yugoslavia1992, CountryCode.YU},
                {Country.Zambia, CountryCode.ZM},
                {Country.Zimbabwe, CountryCode.ZW},
            };
        }
    }
}