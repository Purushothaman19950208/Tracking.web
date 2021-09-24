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

    public partial class Vehicles : XPLiteObject
    {
        long fId;
        [Key(true)]
        public long Id
        {
            get { return fId; }
            set { SetPropertyValue<long>(nameof(Id), ref fId, value); }
        }
        string fVehicleID;
        [Size(SizeAttribute.Unlimited)]
        public string VehicleID
        {
            get { return fVehicleID; }
            set { SetPropertyValue<string>(nameof(VehicleID), ref fVehicleID, value); }
        }
        string fShippingCompany;
        [Size(SizeAttribute.Unlimited)]
        public string ShippingCompany
        {
            get { return fShippingCompany; }
            set { SetPropertyValue<string>(nameof(ShippingCompany), ref fShippingCompany, value); }
        }
        int fFormat;
        public int Format
        {
            get { return fFormat; }
            set { SetPropertyValue<int>(nameof(Format), ref fFormat, value); }
        }
        double fVehicleWeight;
        public double VehicleWeight
        {
            get { return fVehicleWeight; }
            set { SetPropertyValue<double>(nameof(VehicleWeight), ref fVehicleWeight, value); }
        }
        int fVehicleType;
        public int VehicleType
        {
            get { return fVehicleType; }
            set { SetPropertyValue<int>(nameof(VehicleType), ref fVehicleType, value); }
        }
        int fVehicleNumber;
        public int VehicleNumber
        {
            get { return fVehicleNumber; }
            set { SetPropertyValue<int>(nameof(VehicleNumber), ref fVehicleNumber, value); }
        }
        bool fPowergate;
        public bool Powergate
        {
            get { return fPowergate; }
            set { SetPropertyValue<bool>(nameof(Powergate), ref fPowergate, value); }
        }
        bool fCushioningMaterial;
        public bool CushioningMaterial
        {
            get { return fCushioningMaterial; }
            set { SetPropertyValue<bool>(nameof(CushioningMaterial), ref fCushioningMaterial, value); }
        }
        bool fColdInsulation;
        public bool ColdInsulation
        {
            get { return fColdInsulation; }
            set { SetPropertyValue<bool>(nameof(ColdInsulation), ref fColdInsulation, value); }
        }
        int fStatus;
        public int Status
        {
            get { return fStatus; }
            set { SetPropertyValue<int>(nameof(Status), ref fStatus, value); }
        }
        string fLastUpdater;
        [Size(SizeAttribute.Unlimited)]
        public string LastUpdater
        {
            get { return fLastUpdater; }
            set { SetPropertyValue<string>(nameof(LastUpdater), ref fLastUpdater, value); }
        }
        DateTime fLastUpdatedDate;
        public DateTime LastUpdatedDate
        {
            get { return fLastUpdatedDate; }
            set { SetPropertyValue<DateTime>(nameof(LastUpdatedDate), ref fLastUpdatedDate, value); }
        }
        string fIMSI;
        [Size(SizeAttribute.Unlimited)]
        public string IMSI
        {
            get { return fIMSI; }
            set { SetPropertyValue<string>(nameof(IMSI), ref fIMSI, value); }
        }
        DateTime fInventoryDate;
        public DateTime InventoryDate
        {
            get { return fInventoryDate; }
            set { SetPropertyValue<DateTime>(nameof(InventoryDate), ref fInventoryDate, value); }
        }
        double fLat;
        public double Lat
        {
            get { return fLat; }
            set { SetPropertyValue<double>(nameof(Lat), ref fLat, value); }
        }
        int fLocationStatus;
        [ColumnDbDefaultValue("((1))")]
        public int LocationStatus
        {
            get { return fLocationStatus; }
            set { SetPropertyValue<int>(nameof(LocationStatus), ref fLocationStatus, value); }
        }
        double fLon;
        public double Lon
        {
            get { return fLon; }
            set { SetPropertyValue<double>(nameof(Lon), ref fLon, value); }
        }
        string fTruckComapnyAddress;
        [Size(SizeAttribute.Unlimited)]
        public string TruckComapnyAddress
        {
            get { return fTruckComapnyAddress; }
            set { SetPropertyValue<string>(nameof(TruckComapnyAddress), ref fTruckComapnyAddress, value); }
        }
        string fTruckCompany;
        [Size(SizeAttribute.Unlimited)]
        public string TruckCompany
        {
            get { return fTruckCompany; }
            set { SetPropertyValue<string>(nameof(TruckCompany), ref fTruckCompany, value); }
        }
    }

}