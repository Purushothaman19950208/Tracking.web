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

    public partial class PitagoraMasterJoined : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        DateTime fretrieval_date;
        public DateTime retrieval_date
        {
            get { return fretrieval_date; }
            set { SetPropertyValue<DateTime>(nameof(retrieval_date), ref fretrieval_date, value); }
        }
        DateTime farrival_datetime;
        public DateTime arrival_datetime
        {
            get { return farrival_datetime; }
            set { SetPropertyValue<DateTime>(nameof(arrival_datetime), ref farrival_datetime, value); }
        }
        DateTime fdeparture_datetime;
        public DateTime departure_datetime
        {
            get { return fdeparture_datetime; }
            set { SetPropertyValue<DateTime>(nameof(departure_datetime), ref fdeparture_datetime, value); }
        }
        string funsksptncd;
        [Size(SizeAttribute.Unlimited)]
        public string unsksptncd
        {
            get { return funsksptncd; }
            set { SetPropertyValue<string>(nameof(unsksptncd), ref funsksptncd, value); }
        }
        string funsksptnnm;
        [Size(SizeAttribute.Unlimited)]
        public string unsksptnnm
        {
            get { return funsksptnnm; }
            set { SetPropertyValue<string>(nameof(unsksptnnm), ref funsksptnnm, value); }
        }
        string ftmcptncd;
        [Size(SizeAttribute.Unlimited)]
        public string tmcptncd
        {
            get { return ftmcptncd; }
            set { SetPropertyValue<string>(nameof(tmcptncd), ref ftmcptncd, value); }
        }
        string ftmcptnnm;
        [Size(SizeAttribute.Unlimited)]
        public string tmcptnnm
        {
            get { return ftmcptnnm; }
            set { SetPropertyValue<string>(nameof(tmcptnnm), ref ftmcptnnm, value); }
        }
        string fckcptncd;
        [Size(SizeAttribute.Unlimited)]
        public string ckcptncd
        {
            get { return fckcptncd; }
            set { SetPropertyValue<string>(nameof(ckcptncd), ref fckcptncd, value); }
        }
        string fckcptnnm;
        [Size(SizeAttribute.Unlimited)]
        public string ckcptnnm
        {
            get { return fckcptnnm; }
            set { SetPropertyValue<string>(nameof(ckcptnnm), ref fckcptnnm, value); }
        }
        string ftransporter_name;
        [Size(SizeAttribute.Unlimited)]
        public string transporter_name
        {
            get { return ftransporter_name; }
            set { SetPropertyValue<string>(nameof(transporter_name), ref ftransporter_name, value); }
        }
        string fshaban;
        [Size(SizeAttribute.Unlimited)]
        public string shaban
        {
            get { return fshaban; }
            set { SetPropertyValue<string>(nameof(shaban), ref fshaban, value); }
        }
        string fkizai;
        [Size(SizeAttribute.Unlimited)]
        public string kizai
        {
            get { return fkizai; }
            set { SetPropertyValue<string>(nameof(kizai), ref fkizai, value); }
        }
        string fjomuin;
        [Size(SizeAttribute.Unlimited)]
        public string jomuin
        {
            get { return fjomuin; }
            set { SetPropertyValue<string>(nameof(jomuin), ref fjomuin, value); }
        }
        string ftel;
        [Size(SizeAttribute.Unlimited)]
        public string tel
        {
            get { return ftel; }
            set { SetPropertyValue<string>(nameof(tel), ref ftel, value); }
        }
        string fremarks;
        [Size(SizeAttribute.Unlimited)]
        public string remarks
        {
            get { return fremarks; }
            set { SetPropertyValue<string>(nameof(remarks), ref fremarks, value); }
        }
        string f積地センターコード;
        [Size(SizeAttribute.Unlimited)]
        public string 積地センターコード
        {
            get { return f積地センターコード; }
            set { SetPropertyValue<string>(nameof(積地センターコード), ref f積地センターコード, value); }
        }
        string f納品先コード;
        [Size(SizeAttribute.Unlimited)]
        public string 納品先コード
        {
            get { return f納品先コード; }
            set { SetPropertyValue<string>(nameof(納品先コード), ref f納品先コード, value); }
        }
        string fNNSICD;
        [Size(SizeAttribute.Unlimited)]
        public string NNSICD
        {
            get { return fNNSICD; }
            set { SetPropertyValue<string>(nameof(NNSICD), ref fNNSICD, value); }
        }
        string fJGSCD;
        [Size(SizeAttribute.Unlimited)]
        public string JGSCD
        {
            get { return fJGSCD; }
            set { SetPropertyValue<string>(nameof(JGSCD), ref fJGSCD, value); }
        }
        string fSNTCD;
        [Size(SizeAttribute.Unlimited)]
        public string SNTCD
        {
            get { return fSNTCD; }
            set { SetPropertyValue<string>(nameof(SNTCD), ref fSNTCD, value); }
        }
        string fUNSKSCD;
        [Size(SizeAttribute.Unlimited)]
        public string UNSKSCD
        {
            get { return fUNSKSCD; }
            set { SetPropertyValue<string>(nameof(UNSKSCD), ref fUNSKSCD, value); }
        }
        DateTime fPitagoraV1TimeStamp;
        [ColumnDbDefaultValue("('0001-01-01T00:00:00.0000000')")]
        public DateTime PitagoraV1TimeStamp
        {
            get { return fPitagoraV1TimeStamp; }
            set { SetPropertyValue<DateTime>(nameof(PitagoraV1TimeStamp), ref fPitagoraV1TimeStamp, value); }
        }
        long fPitagorasV1ID;
        [ColumnDbDefaultValue("(CONVERT([bigint],(0)))")]
        public long PitagorasV1ID
        {
            get { return fPitagorasV1ID; }
            set { SetPropertyValue<long>(nameof(PitagorasV1ID), ref fPitagorasV1ID, value); }
        }
    }

}
