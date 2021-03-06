//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Tracking.web.sql_trackingdb_stag
{

    [Indices(@"DataTeikyoumotoCD", "DenpyoGyoEdaNO", "DenpyoGyoNO", "DenpyoNO", "DenpyoYMD", "KanriNO1", "NohinsakiCD", "NohinYoteiYMD", "NouhinJigyoushaCD", "sales_office_code", "shipper_code", "ShukkaYoteiYMD", "UnsouKaishaCD")]
    public partial class TelesaMovesV1 : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>(nameof(id), ref fid, value); }
        }
        string fDataTeikyoumotoCD;
        [Indexed(@"shipper_code;sales_office_code;NouhinJigyoushaCD;KanriNO1;DenpyoYMD;DenpyoNO;DenpyoGyoNO;DenpyoGyoEdaNO;ShukkaYoteiYMD;NohinYoteiYMD;NohinsakiCD;UnsouKaishaCD", Name = @"IX_TelesaMovesV1_DataTeikyoumotoCD_shipper_code_sales_office_code_NouhinJigyoushaCD_KanriNO1_DenpyoYMD_DenpyoNO_DenpyoGyoNO_Den~", Unique = true)]
        [Size(450)]
        public string DataTeikyoumotoCD
        {
            get { return fDataTeikyoumotoCD; }
            set { SetPropertyValue<string>(nameof(DataTeikyoumotoCD), ref fDataTeikyoumotoCD, value); }
        }
        string fMakerCD;
        [Size(SizeAttribute.Unlimited)]
        public string MakerCD
        {
            get { return fMakerCD; }
            set { SetPropertyValue<string>(nameof(MakerCD), ref fMakerCD, value); }
        }
        string fMakerName;
        [Size(SizeAttribute.Unlimited)]
        public string MakerName
        {
            get { return fMakerName; }
            set { SetPropertyValue<string>(nameof(MakerName), ref fMakerName, value); }
        }
        string fButsuryuBotenCD;
        [Size(SizeAttribute.Unlimited)]
        public string ButsuryuBotenCD
        {
            get { return fButsuryuBotenCD; }
            set { SetPropertyValue<string>(nameof(ButsuryuBotenCD), ref fButsuryuBotenCD, value); }
        }
        string fButsuryuBotenName;
        [Size(SizeAttribute.Unlimited)]
        public string ButsuryuBotenName
        {
            get { return fButsuryuBotenName; }
            set { SetPropertyValue<string>(nameof(ButsuryuBotenName), ref fButsuryuBotenName, value); }
        }
        string fNouhinJigyoushaCD;
        [Size(450)]
        public string NouhinJigyoushaCD
        {
            get { return fNouhinJigyoushaCD; }
            set { SetPropertyValue<string>(nameof(NouhinJigyoushaCD), ref fNouhinJigyoushaCD, value); }
        }
        string fNouhinJigyoushaName;
        [Size(SizeAttribute.Unlimited)]
        public string NouhinJigyoushaName
        {
            get { return fNouhinJigyoushaName; }
            set { SetPropertyValue<string>(nameof(NouhinJigyoushaName), ref fNouhinJigyoushaName, value); }
        }
        string fKanriNO1;
        [Size(450)]
        public string KanriNO1
        {
            get { return fKanriNO1; }
            set { SetPropertyValue<string>(nameof(KanriNO1), ref fKanriNO1, value); }
        }
        string fKanriNO2;
        [Size(SizeAttribute.Unlimited)]
        public string KanriNO2
        {
            get { return fKanriNO2; }
            set { SetPropertyValue<string>(nameof(KanriNO2), ref fKanriNO2, value); }
        }
        string fKanriNO3;
        [Size(SizeAttribute.Unlimited)]
        public string KanriNO3
        {
            get { return fKanriNO3; }
            set { SetPropertyValue<string>(nameof(KanriNO3), ref fKanriNO3, value); }
        }
        DateTime fShukkaYoteiYMD;
        public DateTime ShukkaYoteiYMD
        {
            get { return fShukkaYoteiYMD; }
            set { SetPropertyValue<DateTime>(nameof(ShukkaYoteiYMD), ref fShukkaYoteiYMD, value); }
        }
        DateTime fNohinYoteiYMD;
        public DateTime NohinYoteiYMD
        {
            get { return fNohinYoteiYMD; }
            set { SetPropertyValue<DateTime>(nameof(NohinYoteiYMD), ref fNohinYoteiYMD, value); }
        }
        string fHacchuYMD;
        [Size(SizeAttribute.Unlimited)]
        public string HacchuYMD
        {
            get { return fHacchuYMD; }
            set { SetPropertyValue<string>(nameof(HacchuYMD), ref fHacchuYMD, value); }
        }
        string fHacchuNO;
        [Size(SizeAttribute.Unlimited)]
        public string HacchuNO
        {
            get { return fHacchuNO; }
            set { SetPropertyValue<string>(nameof(HacchuNO), ref fHacchuNO, value); }
        }
        string fDenpyoYMD;
        [Size(450)]
        public string DenpyoYMD
        {
            get { return fDenpyoYMD; }
            set { SetPropertyValue<string>(nameof(DenpyoYMD), ref fDenpyoYMD, value); }
        }
        string fDenpyoNO;
        [Size(450)]
        public string DenpyoNO
        {
            get { return fDenpyoNO; }
            set { SetPropertyValue<string>(nameof(DenpyoNO), ref fDenpyoNO, value); }
        }
        string fNinushiTorihikiCD;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiTorihikiCD
        {
            get { return fNinushiTorihikiCD; }
            set { SetPropertyValue<string>(nameof(NinushiTorihikiCD), ref fNinushiTorihikiCD, value); }
        }
        string fNinushiTorihikiName;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiTorihikiName
        {
            get { return fNinushiTorihikiName; }
            set { SetPropertyValue<string>(nameof(NinushiTorihikiName), ref fNinushiTorihikiName, value); }
        }
        string fTeiseiKbn;
        [Size(SizeAttribute.Unlimited)]
        public string TeiseiKbn
        {
            get { return fTeiseiKbn; }
            set { SetPropertyValue<string>(nameof(TeiseiKbn), ref fTeiseiKbn, value); }
        }
        string fNinushiName;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiName
        {
            get { return fNinushiName; }
            set { SetPropertyValue<string>(nameof(NinushiName), ref fNinushiName, value); }
        }
        string fNinushiZipCD;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiZipCD
        {
            get { return fNinushiZipCD; }
            set { SetPropertyValue<string>(nameof(NinushiZipCD), ref fNinushiZipCD, value); }
        }
        string fNinushiAddress;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiAddress
        {
            get { return fNinushiAddress; }
            set { SetPropertyValue<string>(nameof(NinushiAddress), ref fNinushiAddress, value); }
        }
        string fNinushiTel;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiTel
        {
            get { return fNinushiTel; }
            set { SetPropertyValue<string>(nameof(NinushiTel), ref fNinushiTel, value); }
        }
        string fNinushiChikuCD;
        [Size(SizeAttribute.Unlimited)]
        public string NinushiChikuCD
        {
            get { return fNinushiChikuCD; }
            set { SetPropertyValue<string>(nameof(NinushiChikuCD), ref fNinushiChikuCD, value); }
        }
        string fToiawasesakiName;
        [Size(SizeAttribute.Unlimited)]
        public string ToiawasesakiName
        {
            get { return fToiawasesakiName; }
            set { SetPropertyValue<string>(nameof(ToiawasesakiName), ref fToiawasesakiName, value); }
        }
        string fToiawasesakiZipCD;
        [Size(SizeAttribute.Unlimited)]
        public string ToiawasesakiZipCD
        {
            get { return fToiawasesakiZipCD; }
            set { SetPropertyValue<string>(nameof(ToiawasesakiZipCD), ref fToiawasesakiZipCD, value); }
        }
        string fToiawasesakiAddress;
        [Size(SizeAttribute.Unlimited)]
        public string ToiawasesakiAddress
        {
            get { return fToiawasesakiAddress; }
            set { SetPropertyValue<string>(nameof(ToiawasesakiAddress), ref fToiawasesakiAddress, value); }
        }
        string fToiawasesakiTel;
        [Size(SizeAttribute.Unlimited)]
        public string ToiawasesakiTel
        {
            get { return fToiawasesakiTel; }
            set { SetPropertyValue<string>(nameof(ToiawasesakiTel), ref fToiawasesakiTel, value); }
        }
        string fToiawasesakiChikuCD;
        [Size(SizeAttribute.Unlimited)]
        public string ToiawasesakiChikuCD
        {
            get { return fToiawasesakiChikuCD; }
            set { SetPropertyValue<string>(nameof(ToiawasesakiChikuCD), ref fToiawasesakiChikuCD, value); }
        }
        string fNohinsakiCD;
        [Size(450)]
        public string NohinsakiCD
        {
            get { return fNohinsakiCD; }
            set { SetPropertyValue<string>(nameof(NohinsakiCD), ref fNohinsakiCD, value); }
        }
        string fOtodokesakiName;
        [Size(SizeAttribute.Unlimited)]
        public string OtodokesakiName
        {
            get { return fOtodokesakiName; }
            set { SetPropertyValue<string>(nameof(OtodokesakiName), ref fOtodokesakiName, value); }
        }
        string fOtodokesakiZipCD;
        [Size(SizeAttribute.Unlimited)]
        public string OtodokesakiZipCD
        {
            get { return fOtodokesakiZipCD; }
            set { SetPropertyValue<string>(nameof(OtodokesakiZipCD), ref fOtodokesakiZipCD, value); }
        }
        string fOtodokesakiAddress;
        [Size(SizeAttribute.Unlimited)]
        public string OtodokesakiAddress
        {
            get { return fOtodokesakiAddress; }
            set { SetPropertyValue<string>(nameof(OtodokesakiAddress), ref fOtodokesakiAddress, value); }
        }
        string fOtodokesakiTel;
        [Size(SizeAttribute.Unlimited)]
        public string OtodokesakiTel
        {
            get { return fOtodokesakiTel; }
            set { SetPropertyValue<string>(nameof(OtodokesakiTel), ref fOtodokesakiTel, value); }
        }
        string fOtodokesakiChikuCD;
        [Size(SizeAttribute.Unlimited)]
        public string OtodokesakiChikuCD
        {
            get { return fOtodokesakiChikuCD; }
            set { SetPropertyValue<string>(nameof(OtodokesakiChikuCD), ref fOtodokesakiChikuCD, value); }
        }
        string fChoaisakiCD1;
        [Size(SizeAttribute.Unlimited)]
        public string ChoaisakiCD1
        {
            get { return fChoaisakiCD1; }
            set { SetPropertyValue<string>(nameof(ChoaisakiCD1), ref fChoaisakiCD1, value); }
        }
        string fChoaisakiName1;
        [Size(SizeAttribute.Unlimited)]
        public string ChoaisakiName1
        {
            get { return fChoaisakiName1; }
            set { SetPropertyValue<string>(nameof(ChoaisakiName1), ref fChoaisakiName1, value); }
        }
        string fChoaisakiCD2;
        [Size(SizeAttribute.Unlimited)]
        public string ChoaisakiCD2
        {
            get { return fChoaisakiCD2; }
            set { SetPropertyValue<string>(nameof(ChoaisakiCD2), ref fChoaisakiCD2, value); }
        }
        string fChoaisakiName2;
        [Size(SizeAttribute.Unlimited)]
        public string ChoaisakiName2
        {
            get { return fChoaisakiName2; }
            set { SetPropertyValue<string>(nameof(ChoaisakiName2), ref fChoaisakiName2, value); }
        }
        string fUnsouKaishaCD;
        [Size(450)]
        public string UnsouKaishaCD
        {
            get { return fUnsouKaishaCD; }
            set { SetPropertyValue<string>(nameof(UnsouKaishaCD), ref fUnsouKaishaCD, value); }
        }
        string fUnsoukaishaName;
        [Size(SizeAttribute.Unlimited)]
        public string UnsoukaishaName
        {
            get { return fUnsoukaishaName; }
            set { SetPropertyValue<string>(nameof(UnsoukaishaName), ref fUnsoukaishaName, value); }
        }
        string fDenpyoGokeiKokuchiNum;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoGokeiKokuchiNum
        {
            get { return fDenpyoGokeiKokuchiNum; }
            set { SetPropertyValue<string>(nameof(DenpyoGokeiKokuchiNum), ref fDenpyoGokeiKokuchiNum, value); }
        }
        string fDenpyoGokeiJuryo;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoGokeiJuryo
        {
            get { return fDenpyoGokeiJuryo; }
            set { SetPropertyValue<string>(nameof(DenpyoGokeiJuryo), ref fDenpyoGokeiJuryo, value); }
        }
        string fDenpyoGokeiJuchuNum;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoGokeiJuchuNum
        {
            get { return fDenpyoGokeiJuchuNum; }
            set { SetPropertyValue<string>(nameof(DenpyoGokeiJuchuNum), ref fDenpyoGokeiJuchuNum, value); }
        }
        string fDenpyoGokeiBaraNum;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoGokeiBaraNum
        {
            get { return fDenpyoGokeiBaraNum; }
            set { SetPropertyValue<string>(nameof(DenpyoGokeiBaraNum), ref fDenpyoGokeiBaraNum, value); }
        }
        string fNohinGokeiKokuchiNum;
        [Size(SizeAttribute.Unlimited)]
        public string NohinGokeiKokuchiNum
        {
            get { return fNohinGokeiKokuchiNum; }
            set { SetPropertyValue<string>(nameof(NohinGokeiKokuchiNum), ref fNohinGokeiKokuchiNum, value); }
        }
        string fNohinGokeiJuryo;
        [Size(SizeAttribute.Unlimited)]
        public string NohinGokeiJuryo
        {
            get { return fNohinGokeiJuryo; }
            set { SetPropertyValue<string>(nameof(NohinGokeiJuryo), ref fNohinGokeiJuryo, value); }
        }
        string fJikanshiteiFrom;
        [Size(SizeAttribute.Unlimited)]
        public string JikanshiteiFrom
        {
            get { return fJikanshiteiFrom; }
            set { SetPropertyValue<string>(nameof(JikanshiteiFrom), ref fJikanshiteiFrom, value); }
        }
        string fJikanshiteiTo;
        [Size(SizeAttribute.Unlimited)]
        public string JikanshiteiTo
        {
            get { return fJikanshiteiTo; }
            set { SetPropertyValue<string>(nameof(JikanshiteiTo), ref fJikanshiteiTo, value); }
        }
        string fDenpyoBikou1;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoBikou1
        {
            get { return fDenpyoBikou1; }
            set { SetPropertyValue<string>(nameof(DenpyoBikou1), ref fDenpyoBikou1, value); }
        }
        string fDenpyoBikou2;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoBikou2
        {
            get { return fDenpyoBikou2; }
            set { SetPropertyValue<string>(nameof(DenpyoBikou2), ref fDenpyoBikou2, value); }
        }
        string fDenpyoBikou3;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoBikou3
        {
            get { return fDenpyoBikou3; }
            set { SetPropertyValue<string>(nameof(DenpyoBikou3), ref fDenpyoBikou3, value); }
        }
        string fDenpyoBikou4;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoBikou4
        {
            get { return fDenpyoBikou4; }
            set { SetPropertyValue<string>(nameof(DenpyoBikou4), ref fDenpyoBikou4, value); }
        }
        string fDenpyoBikou5;
        [Size(SizeAttribute.Unlimited)]
        public string DenpyoBikou5
        {
            get { return fDenpyoBikou5; }
            set { SetPropertyValue<string>(nameof(DenpyoBikou5), ref fDenpyoBikou5, value); }
        }
        string fKoyuran1;
        [Size(SizeAttribute.Unlimited)]
        public string Koyuran1
        {
            get { return fKoyuran1; }
            set { SetPropertyValue<string>(nameof(Koyuran1), ref fKoyuran1, value); }
        }
        string fKoyuran2;
        [Size(SizeAttribute.Unlimited)]
        public string Koyuran2
        {
            get { return fKoyuran2; }
            set { SetPropertyValue<string>(nameof(Koyuran2), ref fKoyuran2, value); }
        }
        string fKoyuran3;
        [Size(SizeAttribute.Unlimited)]
        public string Koyuran3
        {
            get { return fKoyuran3; }
            set { SetPropertyValue<string>(nameof(Koyuran3), ref fKoyuran3, value); }
        }
        string fKoyuran4;
        [Size(SizeAttribute.Unlimited)]
        public string Koyuran4
        {
            get { return fKoyuran4; }
            set { SetPropertyValue<string>(nameof(Koyuran4), ref fKoyuran4, value); }
        }
        string fHacchuGyoNO;
        [Size(SizeAttribute.Unlimited)]
        public string HacchuGyoNO
        {
            get { return fHacchuGyoNO; }
            set { SetPropertyValue<string>(nameof(HacchuGyoNO), ref fHacchuGyoNO, value); }
        }
        string fDenpyoGyoNO;
        [Size(450)]
        public string DenpyoGyoNO
        {
            get { return fDenpyoGyoNO; }
            set { SetPropertyValue<string>(nameof(DenpyoGyoNO), ref fDenpyoGyoNO, value); }
        }
        string fDenpyoGyoEdaNO;
        [Size(450)]
        public string DenpyoGyoEdaNO
        {
            get { return fDenpyoGyoEdaNO; }
            set { SetPropertyValue<string>(nameof(DenpyoGyoEdaNO), ref fDenpyoGyoEdaNO, value); }
        }
        string fShohinCD;
        [Size(SizeAttribute.Unlimited)]
        public string ShohinCD
        {
            get { return fShohinCD; }
            set { SetPropertyValue<string>(nameof(ShohinCD), ref fShohinCD, value); }
        }
        string fShohinOroshiPrivateCD;
        [Size(SizeAttribute.Unlimited)]
        public string ShohinOroshiPrivateCD
        {
            get { return fShohinOroshiPrivateCD; }
            set { SetPropertyValue<string>(nameof(ShohinOroshiPrivateCD), ref fShohinOroshiPrivateCD, value); }
        }
        string fJANKbn;
        [Size(SizeAttribute.Unlimited)]
        public string JANKbn
        {
            get { return fJANKbn; }
            set { SetPropertyValue<string>(nameof(JANKbn), ref fJANKbn, value); }
        }
        string fShohinKigou1;
        [Size(SizeAttribute.Unlimited)]
        public string ShohinKigou1
        {
            get { return fShohinKigou1; }
            set { SetPropertyValue<string>(nameof(ShohinKigou1), ref fShohinKigou1, value); }
        }
        string fShohinKigou2;
        [Size(SizeAttribute.Unlimited)]
        public string ShohinKigou2
        {
            get { return fShohinKigou2; }
            set { SetPropertyValue<string>(nameof(ShohinKigou2), ref fShohinKigou2, value); }
        }
        string fShohinName;
        [Size(SizeAttribute.Unlimited)]
        public string ShohinName
        {
            get { return fShohinName; }
            set { SetPropertyValue<string>(nameof(ShohinName), ref fShohinName, value); }
        }
        string fKikaku;
        [Size(SizeAttribute.Unlimited)]
        public string Kikaku
        {
            get { return fKikaku; }
            set { SetPropertyValue<string>(nameof(Kikaku), ref fKikaku, value); }
        }
        string fSeizouNO;
        [Size(SizeAttribute.Unlimited)]
        public string SeizouNO
        {
            get { return fSeizouNO; }
            set { SetPropertyValue<string>(nameof(SeizouNO), ref fSeizouNO, value); }
        }
        string fShiyouKigen;
        [Size(SizeAttribute.Unlimited)]
        public string ShiyouKigen
        {
            get { return fShiyouKigen; }
            set { SetPropertyValue<string>(nameof(ShiyouKigen), ref fShiyouKigen, value); }
        }
        string fLotHyojiFlag;
        [Size(SizeAttribute.Unlimited)]
        public string LotHyojiFlag
        {
            get { return fLotHyojiFlag; }
            set { SetPropertyValue<string>(nameof(LotHyojiFlag), ref fLotHyojiFlag, value); }
        }
        string fLotKichouGimuFlag;
        [Size(SizeAttribute.Unlimited)]
        public string LotKichouGimuFlag
        {
            get { return fLotKichouGimuFlag; }
            set { SetPropertyValue<string>(nameof(LotKichouGimuFlag), ref fLotKichouGimuFlag, value); }
        }
        string fSeibutsuYuraiFlag;
        [Size(SizeAttribute.Unlimited)]
        public string SeibutsuYuraiFlag
        {
            get { return fSeibutsuYuraiFlag; }
            set { SetPropertyValue<string>(nameof(SeibutsuYuraiFlag), ref fSeibutsuYuraiFlag, value); }
        }
        string fCaseIrisu;
        [Size(SizeAttribute.Unlimited)]
        public string CaseIrisu
        {
            get { return fCaseIrisu; }
            set { SetPropertyValue<string>(nameof(CaseIrisu), ref fCaseIrisu, value); }
        }
        string fJuchuSuryo;
        [Size(SizeAttribute.Unlimited)]
        public string JuchuSuryo
        {
            get { return fJuchuSuryo; }
            set { SetPropertyValue<string>(nameof(JuchuSuryo), ref fJuchuSuryo, value); }
        }
        string fSuryo;
        [Size(SizeAttribute.Unlimited)]
        public string Suryo
        {
            get { return fSuryo; }
            set { SetPropertyValue<string>(nameof(Suryo), ref fSuryo, value); }
        }
        string fSouBaraSuryo;
        [Size(SizeAttribute.Unlimited)]
        public string SouBaraSuryo
        {
            get { return fSouBaraSuryo; }
            set { SetPropertyValue<string>(nameof(SouBaraSuryo), ref fSouBaraSuryo, value); }
        }
        string fLotSuryo;
        [Size(SizeAttribute.Unlimited)]
        public string LotSuryo
        {
            get { return fLotSuryo; }
            set { SetPropertyValue<string>(nameof(LotSuryo), ref fLotSuryo, value); }
        }
        string fLotSouBaraSuryo;
        [Size(SizeAttribute.Unlimited)]
        public string LotSouBaraSuryo
        {
            get { return fLotSouBaraSuryo; }
            set { SetPropertyValue<string>(nameof(LotSouBaraSuryo), ref fLotSouBaraSuryo, value); }
        }
        string fKonsu;
        [Size(SizeAttribute.Unlimited)]
        public string Konsu
        {
            get { return fKonsu; }
            set { SetPropertyValue<string>(nameof(Konsu), ref fKonsu, value); }
        }
        string fHasu;
        [Size(SizeAttribute.Unlimited)]
        public string Hasu
        {
            get { return fHasu; }
            set { SetPropertyValue<string>(nameof(Hasu), ref fHasu, value); }
        }
        string fNisugataTani;
        [Size(SizeAttribute.Unlimited)]
        public string NisugataTani
        {
            get { return fNisugataTani; }
            set { SetPropertyValue<string>(nameof(NisugataTani), ref fNisugataTani, value); }
        }
        string fMeisaiBikou;
        [Size(SizeAttribute.Unlimited)]
        public string MeisaiBikou
        {
            get { return fMeisaiBikou; }
            set { SetPropertyValue<string>(nameof(MeisaiBikou), ref fMeisaiBikou, value); }
        }
        string fCaseJuryo;
        [Size(SizeAttribute.Unlimited)]
        public string CaseJuryo
        {
            get { return fCaseJuryo; }
            set { SetPropertyValue<string>(nameof(CaseJuryo), ref fCaseJuryo, value); }
        }
        string fUnchinJuryo;
        [Size(SizeAttribute.Unlimited)]
        public string UnchinJuryo
        {
            get { return fUnchinJuryo; }
            set { SetPropertyValue<string>(nameof(UnchinJuryo), ref fUnchinJuryo, value); }
        }
        string fCaseSaisu;
        [Size(SizeAttribute.Unlimited)]
        public string CaseSaisu
        {
            get { return fCaseSaisu; }
            set { SetPropertyValue<string>(nameof(CaseSaisu), ref fCaseSaisu, value); }
        }
        string fCaseYouseki;
        [Size(SizeAttribute.Unlimited)]
        public string CaseYouseki
        {
            get { return fCaseYouseki; }
            set { SetPropertyValue<string>(nameof(CaseYouseki), ref fCaseYouseki, value); }
        }
        string fYobi1;
        [Size(SizeAttribute.Unlimited)]
        public string Yobi1
        {
            get { return fYobi1; }
            set { SetPropertyValue<string>(nameof(Yobi1), ref fYobi1, value); }
        }
        string fYobi2;
        [Size(SizeAttribute.Unlimited)]
        public string Yobi2
        {
            get { return fYobi2; }
            set { SetPropertyValue<string>(nameof(Yobi2), ref fYobi2, value); }
        }
        string fYobi3;
        [Size(SizeAttribute.Unlimited)]
        public string Yobi3
        {
            get { return fYobi3; }
            set { SetPropertyValue<string>(nameof(Yobi3), ref fYobi3, value); }
        }
        string fYobi4;
        [Size(SizeAttribute.Unlimited)]
        public string Yobi4
        {
            get { return fYobi4; }
            set { SetPropertyValue<string>(nameof(Yobi4), ref fYobi4, value); }
        }
        string fYobi5;
        [Size(SizeAttribute.Unlimited)]
        public string Yobi5
        {
            get { return fYobi5; }
            set { SetPropertyValue<string>(nameof(Yobi5), ref fYobi5, value); }
        }
        string fMeisaiyobi1;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi1
        {
            get { return fMeisaiyobi1; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi1), ref fMeisaiyobi1, value); }
        }
        string fMeisaiyobi2;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi2
        {
            get { return fMeisaiyobi2; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi2), ref fMeisaiyobi2, value); }
        }
        string fMeisaiyobi3;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi3
        {
            get { return fMeisaiyobi3; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi3), ref fMeisaiyobi3, value); }
        }
        string fMeisaiyobi4;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi4
        {
            get { return fMeisaiyobi4; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi4), ref fMeisaiyobi4, value); }
        }
        string fMeisaiyobi5;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi5
        {
            get { return fMeisaiyobi5; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi5), ref fMeisaiyobi5, value); }
        }
        string fMeisaiyobi6;
        [Size(SizeAttribute.Unlimited)]
        public string Meisaiyobi6
        {
            get { return fMeisaiyobi6; }
            set { SetPropertyValue<string>(nameof(Meisaiyobi6), ref fMeisaiyobi6, value); }
        }
        string fTorikomiYMD;
        [Size(SizeAttribute.Unlimited)]
        public string TorikomiYMD
        {
            get { return fTorikomiYMD; }
            set { SetPropertyValue<string>(nameof(TorikomiYMD), ref fTorikomiYMD, value); }
        }
        string fTorikomiHMI;
        [Size(SizeAttribute.Unlimited)]
        public string TorikomiHMI
        {
            get { return fTorikomiHMI; }
            set { SetPropertyValue<string>(nameof(TorikomiHMI), ref fTorikomiHMI, value); }
        }
        string fNohinStatusName;
        [Size(SizeAttribute.Unlimited)]
        public string NohinStatusName
        {
            get { return fNohinStatusName; }
            set { SetPropertyValue<string>(nameof(NohinStatusName), ref fNohinStatusName, value); }
        }
        DateTime fNohinStatusUpdDateTime;
        public DateTime NohinStatusUpdDateTime
        {
            get { return fNohinStatusUpdDateTime; }
            set { SetPropertyValue<DateTime>(nameof(NohinStatusUpdDateTime), ref fNohinStatusUpdDateTime, value); }
        }
        string fERStatusName;
        [Size(SizeAttribute.Unlimited)]
        public string ERStatusName
        {
            get { return fERStatusName; }
            set { SetPropertyValue<string>(nameof(ERStatusName), ref fERStatusName, value); }
        }
        DateTime fERStatusUpdDateTime;
        public DateTime ERStatusUpdDateTime
        {
            get { return fERStatusUpdDateTime; }
            set { SetPropertyValue<DateTime>(nameof(ERStatusUpdDateTime), ref fERStatusUpdDateTime, value); }
        }
        string fERStatusUpdUserID;
        [Size(SizeAttribute.Unlimited)]
        public string ERStatusUpdUserID
        {
            get { return fERStatusUpdUserID; }
            set { SetPropertyValue<string>(nameof(ERStatusUpdUserID), ref fERStatusUpdUserID, value); }
        }
        string fERStatusUpdUserName;
        [Size(SizeAttribute.Unlimited)]
        public string ERStatusUpdUserName
        {
            get { return fERStatusUpdUserName; }
            set { SetPropertyValue<string>(nameof(ERStatusUpdUserName), ref fERStatusUpdUserName, value); }
        }
        string fERActualQuantityCase;
        [Size(SizeAttribute.Unlimited)]
        public string ERActualQuantityCase
        {
            get { return fERActualQuantityCase; }
            set { SetPropertyValue<string>(nameof(ERActualQuantityCase), ref fERActualQuantityCase, value); }
        }
        string fERActualQuantityFraction;
        [Size(SizeAttribute.Unlimited)]
        public string ERActualQuantityFraction
        {
            get { return fERActualQuantityFraction; }
            set { SetPropertyValue<string>(nameof(ERActualQuantityFraction), ref fERActualQuantityFraction, value); }
        }
        string fERComment;
        [Size(SizeAttribute.Unlimited)]
        public string ERComment
        {
            get { return fERComment; }
            set { SetPropertyValue<string>(nameof(ERComment), ref fERComment, value); }
        }
        string fCoordinationUserID;
        [Size(SizeAttribute.Unlimited)]
        public string CoordinationUserID
        {
            get { return fCoordinationUserID; }
            set { SetPropertyValue<string>(nameof(CoordinationUserID), ref fCoordinationUserID, value); }
        }
        string fsales_office_code;
        [Size(450)]
        public string sales_office_code
        {
            get { return fsales_office_code; }
            set { SetPropertyValue<string>(nameof(sales_office_code), ref fsales_office_code, value); }
        }
        string fsales_office_name;
        [Size(SizeAttribute.Unlimited)]
        public string sales_office_name
        {
            get { return fsales_office_name; }
            set { SetPropertyValue<string>(nameof(sales_office_name), ref fsales_office_name, value); }
        }
        string fshipper_code;
        [Size(450)]
        public string shipper_code
        {
            get { return fshipper_code; }
            set { SetPropertyValue<string>(nameof(shipper_code), ref fshipper_code, value); }
        }
        string fshipper_name;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_name
        {
            get { return fshipper_name; }
            set { SetPropertyValue<string>(nameof(shipper_name), ref fshipper_name, value); }
        }
        string fentity;
        [Size(SizeAttribute.Unlimited)]
        public string entity
        {
            get { return fentity; }
            set { SetPropertyValue<string>(nameof(entity), ref fentity, value); }
        }
        DateTime ftimestamp;
        [Indexed(Name = @"nci_wi_TelesaMovesV1_0D22A1088A20D801E5A63EF90BE53C81")]
        [ColumnDbDefaultValue("('0001-01-01T00:00:00.0000000')")]
        public DateTime timestamp
        {
            get { return ftimestamp; }
            set { SetPropertyValue<DateTime>(nameof(timestamp), ref ftimestamp, value); }
        }
    }

}
