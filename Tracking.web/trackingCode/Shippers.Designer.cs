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

    public partial class Shippers : XPLiteObject
    {
        string fShipperCode;
        [Key]
        [Size(450)]
        public string ShipperCode
        {
            get { return fShipperCode; }
            set { SetPropertyValue<string>(nameof(ShipperCode), ref fShipperCode, value); }
        }
        string fShipperFullName;
        [Size(SizeAttribute.Unlimited)]
        public string ShipperFullName
        {
            get { return fShipperFullName; }
            set { SetPropertyValue<string>(nameof(ShipperFullName), ref fShipperFullName, value); }
        }
        string fShipperShortName;
        [Size(SizeAttribute.Unlimited)]
        public string ShipperShortName
        {
            get { return fShipperShortName; }
            set { SetPropertyValue<string>(nameof(ShipperShortName), ref fShipperShortName, value); }
        }
    }

}
