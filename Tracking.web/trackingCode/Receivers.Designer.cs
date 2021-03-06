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

    public partial class Receivers : XPLiteObject
    {
        int fID;
        [Key(true)]
        public int ID
        {
            get { return fID; }
            set { SetPropertyValue<int>(nameof(ID), ref fID, value); }
        }
        string fShipperCode;
        [Size(10)]
        public string ShipperCode
        {
            get { return fShipperCode; }
            set { SetPropertyValue<string>(nameof(ShipperCode), ref fShipperCode, value); }
        }
        string fDeliveryCode;
        [Size(SizeAttribute.Unlimited)]
        public string DeliveryCode
        {
            get { return fDeliveryCode; }
            set { SetPropertyValue<string>(nameof(DeliveryCode), ref fDeliveryCode, value); }
        }
        string fReceiverName1;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverName1
        {
            get { return fReceiverName1; }
            set { SetPropertyValue<string>(nameof(ReceiverName1), ref fReceiverName1, value); }
        }
        string fReceiverName2;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverName2
        {
            get { return fReceiverName2; }
            set { SetPropertyValue<string>(nameof(ReceiverName2), ref fReceiverName2, value); }
        }
        string fReceiverName3;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverName3
        {
            get { return fReceiverName3; }
            set { SetPropertyValue<string>(nameof(ReceiverName3), ref fReceiverName3, value); }
        }
        string fReceiverAddress1;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverAddress1
        {
            get { return fReceiverAddress1; }
            set { SetPropertyValue<string>(nameof(ReceiverAddress1), ref fReceiverAddress1, value); }
        }
        string fReceiverAddress2;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverAddress2
        {
            get { return fReceiverAddress2; }
            set { SetPropertyValue<string>(nameof(ReceiverAddress2), ref fReceiverAddress2, value); }
        }
        string fReceiverAddress3;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverAddress3
        {
            get { return fReceiverAddress3; }
            set { SetPropertyValue<string>(nameof(ReceiverAddress3), ref fReceiverAddress3, value); }
        }
        string fReceiverTel;
        [Size(SizeAttribute.Unlimited)]
        public string ReceiverTel
        {
            get { return fReceiverTel; }
            set { SetPropertyValue<string>(nameof(ReceiverTel), ref fReceiverTel, value); }
        }
        DateTime fLastUpdatedAt;
        [ColumnDbDefaultValue("('0001-01-01T00:00:00.0000000')")]
        public DateTime LastUpdatedAt
        {
            get { return fLastUpdatedAt; }
            set { SetPropertyValue<DateTime>(nameof(LastUpdatedAt), ref fLastUpdatedAt, value); }
        }
        double fLat;
        public double Lat
        {
            get { return fLat; }
            set { SetPropertyValue<double>(nameof(Lat), ref fLat, value); }
        }
        double fLon;
        public double Lon
        {
            get { return fLon; }
            set { SetPropertyValue<double>(nameof(Lon), ref fLon, value); }
        }
        int fLocationStatus;
        [ColumnDbDefaultValue("((0))")]
        public int LocationStatus
        {
            get { return fLocationStatus; }
            set { SetPropertyValue<int>(nameof(LocationStatus), ref fLocationStatus, value); }
        }
    }

}
