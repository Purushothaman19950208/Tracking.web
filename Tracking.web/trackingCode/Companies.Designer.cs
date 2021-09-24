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

    public partial class Companies : XPLiteObject
    {
        Guid fId;
        [Key(true)]
        public Guid Id
        {
            get { return fId; }
            set { SetPropertyValue<Guid>(nameof(Id), ref fId, value); }
        }
        string fName;
        [Size(SizeAttribute.Unlimited)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fAddress;
        [Size(SizeAttribute.Unlimited)]
        public string Address
        {
            get { return fAddress; }
            set { SetPropertyValue<string>(nameof(Address), ref fAddress, value); }
        }
        string fDepartment;
        [Size(SizeAttribute.Unlimited)]
        public string Department
        {
            get { return fDepartment; }
            set { SetPropertyValue<string>(nameof(Department), ref fDepartment, value); }
        }
        int fCompanyType;
        [ColumnDbDefaultValue("((0))")]
        public int CompanyType
        {
            get { return fCompanyType; }
            set { SetPropertyValue<int>(nameof(CompanyType), ref fCompanyType, value); }
        }
        string fPartnerCode;
        [Indexed(Name = @"IX_Companies_PartnerCode", Unique = true)]
        [Size(10)]
        public string PartnerCode
        {
            get { return fPartnerCode; }
            set { SetPropertyValue<string>(nameof(PartnerCode), ref fPartnerCode, value); }
        }
        string fPythagora;
        [Size(10)]
        public string Pythagora
        {
            get { return fPythagora; }
            set { SetPropertyValue<string>(nameof(Pythagora), ref fPythagora, value); }
        }
        string fTsunagute;
        [Size(10)]
        public string Tsunagute
        {
            get { return fTsunagute; }
            set { SetPropertyValue<string>(nameof(Tsunagute), ref fTsunagute, value); }
        }
        [Association(@"ApplicationUsersReferencesCompanies")]
        public XPCollection<ApplicationUsers> ApplicationUsersCollection { get { return GetCollection<ApplicationUsers>(nameof(ApplicationUsersCollection)); } }
        [Association(@"CompanyPermissionsReferencesCompanies")]
        public XPCollection<CompanyPermissions> CompanyPermissionsCollection { get { return GetCollection<CompanyPermissions>(nameof(CompanyPermissionsCollection)); } }
        [Association(@"InvitedUsersReferencesCompanies")]
        public XPCollection<InvitedUsers> InvitedUsersCollection { get { return GetCollection<InvitedUsers>(nameof(InvitedUsersCollection)); } }
    }

}
