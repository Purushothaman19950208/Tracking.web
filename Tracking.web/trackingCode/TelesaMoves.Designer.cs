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

    public partial class TelesaMoves : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string f伝票番号;
        [Indexed(Name = @"IX_TelesaMoves_伝票番号")]
        [Size(450)]
        public string 伝票番号
        {
            get { return f伝票番号; }
            set { SetPropertyValue<string>(nameof(伝票番号), ref f伝票番号, value); }
        }
        DateTime f出荷予定日;
        [Indexed(Name = @"IX_TelesaMoves_出荷予定日")]
        public DateTime 出荷予定日
        {
            get { return f出荷予定日; }
            set { SetPropertyValue<DateTime>(nameof(出荷予定日), ref f出荷予定日, value); }
        }
        DateTime f納品予定日;
        [Indexed(Name = @"IX_TelesaMoves_納品予定日")]
        public DateTime 納品予定日
        {
            get { return f納品予定日; }
            set { SetPropertyValue<DateTime>(nameof(納品予定日), ref f納品予定日, value); }
        }
        string fメーカーコード;
        [Indexed(Name = @"IX_TelesaMoves_メーカーコード")]
        [Size(450)]
        public string メーカーコード
        {
            get { return fメーカーコード; }
            set { SetPropertyValue<string>(nameof(メーカーコード), ref fメーカーコード, value); }
        }
        string f物流母店コード;
        [Indexed(Name = @"IX_TelesaMoves_物流母店コード")]
        [Size(450)]
        public string 物流母店コード
        {
            get { return f物流母店コード; }
            set { SetPropertyValue<string>(nameof(物流母店コード), ref f物流母店コード, value); }
        }
        string f運送会社コード;
        [Indexed(Name = @"IX_TelesaMoves_運送会社コード")]
        [Size(450)]
        public string 運送会社コード
        {
            get { return f運送会社コード; }
            set { SetPropertyValue<string>(nameof(運送会社コード), ref f運送会社コード, value); }
        }
        string f着荷ステータス;
        [Indexed(Name = @"IX_TelesaMoves_着荷ステータス")]
        [Size(450)]
        public string 着荷ステータス
        {
            get { return f着荷ステータス; }
            set { SetPropertyValue<string>(nameof(着荷ステータス), ref f着荷ステータス, value); }
        }
        DateTime f納品ステータス更新日時;
        public DateTime 納品ステータス更新日時
        {
            get { return f納品ステータス更新日時; }
            set { SetPropertyValue<DateTime>(nameof(納品ステータス更新日時), ref f納品ステータス更新日時, value); }
        }
    }

}
