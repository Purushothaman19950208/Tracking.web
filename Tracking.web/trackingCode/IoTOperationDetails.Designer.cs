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

    [Indices(@"IMSI", "IMSI;ReceivedAt")]
    public partial class IoTOperationDetails : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>(nameof(Id), ref fId, value); }
        }
        long fTimestamp;
        public long Timestamp
        {
            get { return fTimestamp; }
            set { SetPropertyValue<long>(nameof(Timestamp), ref fTimestamp, value); }
        }
        DateTime fReceivedAt;
        public DateTime ReceivedAt
        {
            get { return fReceivedAt; }
            set { SetPropertyValue<DateTime>(nameof(ReceivedAt), ref fReceivedAt, value); }
        }
        int fBat;
        public int Bat
        {
            get { return fBat; }
            set { SetPropertyValue<int>(nameof(Bat), ref fBat, value); }
        }
        float fTemp;
        public float Temp
        {
            get { return fTemp; }
            set { SetPropertyValue<float>(nameof(Temp), ref fTemp, value); }
        }
        int fRs;
        public int Rs
        {
            get { return fRs; }
            set { SetPropertyValue<int>(nameof(Rs), ref fRs, value); }
        }
        double fLon;
        public double Lon
        {
            get { return fLon; }
            set { SetPropertyValue<double>(nameof(Lon), ref fLon, value); }
        }
        double fLat;
        public double Lat
        {
            get { return fLat; }
            set { SetPropertyValue<double>(nameof(Lat), ref fLat, value); }
        }
        string fY;
        [Size(SizeAttribute.Unlimited)]
        public string Y
        {
            get { return fY; }
            set { SetPropertyValue<string>(nameof(Y), ref fY, value); }
        }
        string fX;
        [Size(SizeAttribute.Unlimited)]
        public string X
        {
            get { return fX; }
            set { SetPropertyValue<string>(nameof(X), ref fX, value); }
        }
        string fZ;
        [Size(SizeAttribute.Unlimited)]
        public string Z
        {
            get { return fZ; }
            set { SetPropertyValue<string>(nameof(Z), ref fZ, value); }
        }
        float fHumi;
        public float Humi
        {
            get { return fHumi; }
            set { SetPropertyValue<float>(nameof(Humi), ref fHumi, value); }
        }
        string fIMSI;
        [Indexed(@"Timestamp", Name = @"IX_IoTOperationDetails_IMSI_Timestamp", Unique = true)]
        [Size(450)]
        public string IMSI
        {
            get { return fIMSI; }
            set { SetPropertyValue<string>(nameof(IMSI), ref fIMSI, value); }
        }
        string fFileName;
        [Size(SizeAttribute.Unlimited)]
        public string FileName
        {
            get { return fFileName; }
            set { SetPropertyValue<string>(nameof(FileName), ref fFileName, value); }
        }
    }

}
