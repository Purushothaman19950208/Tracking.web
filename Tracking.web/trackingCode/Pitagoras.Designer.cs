﻿//------------------------------------------------------------------------------
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

    public partial class Pitagoras : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        DateTime f伝票日付;
        [Indexed(Name = @"IX_Pitagoras_伝票日付")]
        public DateTime 伝票日付
        {
            get { return f伝票日付; }
            set { SetPropertyValue<DateTime>(nameof(伝票日付), ref f伝票日付, value); }
        }
        string f荷主;
        [Size(SizeAttribute.Unlimited)]
        public string 荷主
        {
            get { return f荷主; }
            set { SetPropertyValue<string>(nameof(荷主), ref f荷主, value); }
        }
        string f運送会社コード;
        [Size(SizeAttribute.Unlimited)]
        public string 運送会社コード
        {
            get { return f運送会社コード; }
            set { SetPropertyValue<string>(nameof(運送会社コード), ref f運送会社コード, value); }
        }
        string f運送会社名称;
        [Size(SizeAttribute.Unlimited)]
        public string 運送会社名称
        {
            get { return f運送会社名称; }
            set { SetPropertyValue<string>(nameof(運送会社名称), ref f運送会社名称, value); }
        }
        string f積地センターコード;
        [Size(SizeAttribute.Unlimited)]
        public string 積地センターコード
        {
            get { return f積地センターコード; }
            set { SetPropertyValue<string>(nameof(積地センターコード), ref f積地センターコード, value); }
        }
        string f積地センター名称;
        [Size(SizeAttribute.Unlimited)]
        public string 積地センター名称
        {
            get { return f積地センター名称; }
            set { SetPropertyValue<string>(nameof(積地センター名称), ref f積地センター名称, value); }
        }
        string f納品先コード;
        [Size(SizeAttribute.Unlimited)]
        public string 納品先コード
        {
            get { return f納品先コード; }
            set { SetPropertyValue<string>(nameof(納品先コード), ref f納品先コード, value); }
        }
        string f納品先名称;
        [Size(SizeAttribute.Unlimited)]
        public string 納品先名称
        {
            get { return f納品先名称; }
            set { SetPropertyValue<string>(nameof(納品先名称), ref f納品先名称, value); }
        }
        string f納品先住所;
        [Size(SizeAttribute.Unlimited)]
        public string 納品先住所
        {
            get { return f納品先住所; }
            set { SetPropertyValue<string>(nameof(納品先住所), ref f納品先住所, value); }
        }
        string f運送会社名;
        [Size(SizeAttribute.Unlimited)]
        public string 運送会社名
        {
            get { return f運送会社名; }
            set { SetPropertyValue<string>(nameof(運送会社名), ref f運送会社名, value); }
        }
        string f車番;
        [Size(SizeAttribute.Unlimited)]
        public string 車番
        {
            get { return f車番; }
            set { SetPropertyValue<string>(nameof(車番), ref f車番, value); }
        }
        string f機材;
        [Size(SizeAttribute.Unlimited)]
        public string 機材
        {
            get { return f機材; }
            set { SetPropertyValue<string>(nameof(機材), ref f機材, value); }
        }
        string f乗務員;
        [Size(SizeAttribute.Unlimited)]
        public string 乗務員
        {
            get { return f乗務員; }
            set { SetPropertyValue<string>(nameof(乗務員), ref f乗務員, value); }
        }
        DateTime f出発日時;
        public DateTime 出発日時
        {
            get { return f出発日時; }
            set { SetPropertyValue<DateTime>(nameof(出発日時), ref f出発日時, value); }
        }
        DateTime f到着日時;
        public DateTime 到着日時
        {
            get { return f到着日時; }
            set { SetPropertyValue<DateTime>(nameof(到着日時), ref f到着日時, value); }
        }
        string fインデックス;
        [Size(SizeAttribute.Unlimited)]
        public string インデックス
        {
            get { return fインデックス; }
            set { SetPropertyValue<string>(nameof(インデックス), ref fインデックス, value); }
        }
        string f積地_着地;
        [Size(SizeAttribute.Unlimited)]
        public string 積地_着地
        {
            get { return f積地_着地; }
            set { SetPropertyValue<string>(nameof(積地_着地), ref f積地_着地, value); }
        }
        string f送信条件マスター2_Tsumichi;
        [Size(SizeAttribute.Unlimited)]
        public string 送信条件マスター2_Tsumichi
        {
            get { return f送信条件マスター2_Tsumichi; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_Tsumichi), ref f送信条件マスター2_Tsumichi, value); }
        }
        string f送信条件マスター2_Cyakuchi;
        [Size(SizeAttribute.Unlimited)]
        public string 送信条件マスター2_Cyakuchi
        {
            get { return f送信条件マスター2_Cyakuchi; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_Cyakuchi), ref f送信条件マスター2_Cyakuchi, value); }
        }
        string f送信条件マスター2_NNSICD;
        [Indexed(Name = @"IX_Pitagoras_送信条件マスター2_NNSICD")]
        [Size(450)]
        public string 送信条件マスター2_NNSICD
        {
            get { return f送信条件マスター2_NNSICD; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_NNSICD), ref f送信条件マスター2_NNSICD, value); }
        }
        string f送信条件マスター2_JGSCD;
        [Indexed(Name = @"IX_Pitagoras_送信条件マスター2_JGSCD")]
        [Size(450)]
        public string 送信条件マスター2_JGSCD
        {
            get { return f送信条件マスター2_JGSCD; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_JGSCD), ref f送信条件マスター2_JGSCD, value); }
        }
        string f送信条件マスター2_SNTCD;
        [Indexed(Name = @"IX_Pitagoras_送信条件マスター2_SNTCD")]
        [Size(450)]
        public string 送信条件マスター2_SNTCD
        {
            get { return f送信条件マスター2_SNTCD; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_SNTCD), ref f送信条件マスター2_SNTCD, value); }
        }
        string f送信条件マスター2_UNSKSCD;
        [Indexed(Name = @"IX_Pitagoras_送信条件マスター2_UNSKSCD")]
        [Size(450)]
        public string 送信条件マスター2_UNSKSCD
        {
            get { return f送信条件マスター2_UNSKSCD; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_UNSKSCD), ref f送信条件マスター2_UNSKSCD, value); }
        }
        string f送信条件マスター2_積地_着地;
        [Size(SizeAttribute.Unlimited)]
        public string 送信条件マスター2_積地_着地
        {
            get { return f送信条件マスター2_積地_着地; }
            set { SetPropertyValue<string>(nameof(送信条件マスター2_積地_着地), ref f送信条件マスター2_積地_着地, value); }
        }
    }

}
