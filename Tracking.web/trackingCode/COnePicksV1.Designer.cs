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

    [Indices(@"delivery_date", "item_line", "item_line_column", "sales_office_code", "shipper_code", "slip_number")]
    public partial class COnePicksV1 : XPLiteObject
    {
        long fid;
        [Key(true)]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>(nameof(id), ref fid, value); }
        }
        string fcontrol_number;
        [Size(SizeAttribute.Unlimited)]
        public string control_number
        {
            get { return fcontrol_number; }
            set { SetPropertyValue<string>(nameof(control_number), ref fcontrol_number, value); }
        }
        string fallocated_number;
        [Size(SizeAttribute.Unlimited)]
        public string allocated_number
        {
            get { return fallocated_number; }
            set { SetPropertyValue<string>(nameof(allocated_number), ref fallocated_number, value); }
        }
        string fdata_species;
        [Size(SizeAttribute.Unlimited)]
        public string data_species
        {
            get { return fdata_species; }
            set { SetPropertyValue<string>(nameof(data_species), ref fdata_species, value); }
        }
        string fred_and_black;
        [Size(SizeAttribute.Unlimited)]
        public string red_and_black
        {
            get { return fred_and_black; }
            set { SetPropertyValue<string>(nameof(red_and_black), ref fred_and_black, value); }
        }
        DateTime fretrieval_date;
        public DateTime retrieval_date
        {
            get { return fretrieval_date; }
            set { SetPropertyValue<DateTime>(nameof(retrieval_date), ref fretrieval_date, value); }
        }
        DateTime fdelivery_date;
        public DateTime delivery_date
        {
            get { return fdelivery_date; }
            set { SetPropertyValue<DateTime>(nameof(delivery_date), ref fdelivery_date, value); }
        }
        string fslip_number;
        [Indexed(@"item_line;item_line_column;shipper_code;sales_office_code;delivery_date", Name = @"IX_COnePicksV1_slip_number_item_line_item_line_column_shipper_code_sales_office_code_delivery_date", Unique = true)]
        [Size(450)]
        public string slip_number
        {
            get { return fslip_number; }
            set { SetPropertyValue<string>(nameof(slip_number), ref fslip_number, value); }
        }
        int fitem_line;
        public int item_line
        {
            get { return fitem_line; }
            set { SetPropertyValue<int>(nameof(item_line), ref fitem_line, value); }
        }
        int fitem_line_column;
        public int item_line_column
        {
            get { return fitem_line_column; }
            set { SetPropertyValue<int>(nameof(item_line_column), ref fitem_line_column, value); }
        }
        string fshipper_code;
        [Size(450)]
        public string shipper_code
        {
            get { return fshipper_code; }
            set { SetPropertyValue<string>(nameof(shipper_code), ref fshipper_code, value); }
        }
        string fshipper_code_for_work;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_code_for_work
        {
            get { return fshipper_code_for_work; }
            set { SetPropertyValue<string>(nameof(shipper_code_for_work), ref fshipper_code_for_work, value); }
        }
        string fshipper_name;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_name
        {
            get { return fshipper_name; }
            set { SetPropertyValue<string>(nameof(shipper_name), ref fshipper_name, value); }
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
        string fwarehouse_code;
        [Size(SizeAttribute.Unlimited)]
        public string warehouse_code
        {
            get { return fwarehouse_code; }
            set { SetPropertyValue<string>(nameof(warehouse_code), ref fwarehouse_code, value); }
        }
        string fwarehouse_name;
        [Size(SizeAttribute.Unlimited)]
        public string warehouse_name
        {
            get { return fwarehouse_name; }
            set { SetPropertyValue<string>(nameof(warehouse_name), ref fwarehouse_name, value); }
        }
        string fdelivery_code;
        [Size(SizeAttribute.Unlimited)]
        public string delivery_code
        {
            get { return fdelivery_code; }
            set { SetPropertyValue<string>(nameof(delivery_code), ref fdelivery_code, value); }
        }
        string fdelivery_name1;
        [Size(SizeAttribute.Unlimited)]
        public string delivery_name1
        {
            get { return fdelivery_name1; }
            set { SetPropertyValue<string>(nameof(delivery_name1), ref fdelivery_name1, value); }
        }
        string fdelivery_name2;
        [Size(SizeAttribute.Unlimited)]
        public string delivery_name2
        {
            get { return fdelivery_name2; }
            set { SetPropertyValue<string>(nameof(delivery_name2), ref fdelivery_name2, value); }
        }
        string fdelivery_name3;
        [Size(SizeAttribute.Unlimited)]
        public string delivery_name3
        {
            get { return fdelivery_name3; }
            set { SetPropertyValue<string>(nameof(delivery_name3), ref fdelivery_name3, value); }
        }
        string freceiver_code;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_code
        {
            get { return freceiver_code; }
            set { SetPropertyValue<string>(nameof(receiver_code), ref freceiver_code, value); }
        }
        string freceiver_name1;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_name1
        {
            get { return freceiver_name1; }
            set { SetPropertyValue<string>(nameof(receiver_name1), ref freceiver_name1, value); }
        }
        string freceiver_name2;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_name2
        {
            get { return freceiver_name2; }
            set { SetPropertyValue<string>(nameof(receiver_name2), ref freceiver_name2, value); }
        }
        string freceiver_name3;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_name3
        {
            get { return freceiver_name3; }
            set { SetPropertyValue<string>(nameof(receiver_name3), ref freceiver_name3, value); }
        }
        string ftransporter_code;
        [Size(SizeAttribute.Unlimited)]
        public string transporter_code
        {
            get { return ftransporter_code; }
            set { SetPropertyValue<string>(nameof(transporter_code), ref ftransporter_code, value); }
        }
        string ftransporter_name;
        [Size(SizeAttribute.Unlimited)]
        public string transporter_name
        {
            get { return ftransporter_name; }
            set { SetPropertyValue<string>(nameof(transporter_name), ref ftransporter_name, value); }
        }
        string fshipper_trading_code;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_trading_code
        {
            get { return fshipper_trading_code; }
            set { SetPropertyValue<string>(nameof(shipper_trading_code), ref fshipper_trading_code, value); }
        }
        string fshipper_trading_name;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_trading_name
        {
            get { return fshipper_trading_name; }
            set { SetPropertyValue<string>(nameof(shipper_trading_name), ref fshipper_trading_name, value); }
        }
        string fshipper_trading_short_name;
        [Size(SizeAttribute.Unlimited)]
        public string shipper_trading_short_name
        {
            get { return fshipper_trading_short_name; }
            set { SetPropertyValue<string>(nameof(shipper_trading_short_name), ref fshipper_trading_short_name, value); }
        }
        string fproduct_code;
        [Size(SizeAttribute.Unlimited)]
        public string product_code
        {
            get { return fproduct_code; }
            set { SetPropertyValue<string>(nameof(product_code), ref fproduct_code, value); }
        }
        string fproduct_name;
        [Size(SizeAttribute.Unlimited)]
        public string product_name
        {
            get { return fproduct_name; }
            set { SetPropertyValue<string>(nameof(product_name), ref fproduct_name, value); }
        }
        string fdenryaku;
        [Size(SizeAttribute.Unlimited)]
        public string denryaku
        {
            get { return fdenryaku; }
            set { SetPropertyValue<string>(nameof(denryaku), ref fdenryaku, value); }
        }
        string flot;
        [Size(SizeAttribute.Unlimited)]
        public string lot
        {
            get { return flot; }
            set { SetPropertyValue<string>(nameof(lot), ref flot, value); }
        }
        string fproduction_date;
        [Size(SizeAttribute.Unlimited)]
        public string production_date
        {
            get { return fproduction_date; }
            set { SetPropertyValue<string>(nameof(production_date), ref fproduction_date, value); }
        }
        string fexpiration_date;
        [Size(SizeAttribute.Unlimited)]
        public string expiration_date
        {
            get { return fexpiration_date; }
            set { SetPropertyValue<string>(nameof(expiration_date), ref fexpiration_date, value); }
        }
        string farrival_date;
        [Size(SizeAttribute.Unlimited)]
        public string arrival_date
        {
            get { return farrival_date; }
            set { SetPropertyValue<string>(nameof(arrival_date), ref farrival_date, value); }
        }
        int fquantity_per_package;
        public int quantity_per_package
        {
            get { return fquantity_per_package; }
            set { SetPropertyValue<int>(nameof(quantity_per_package), ref fquantity_per_package, value); }
        }
        string fquantity_per_carton;
        [Size(SizeAttribute.Unlimited)]
        public string quantity_per_carton
        {
            get { return fquantity_per_carton; }
            set { SetPropertyValue<string>(nameof(quantity_per_carton), ref fquantity_per_carton, value); }
        }
        string fquantity_per_fraction;
        [Size(SizeAttribute.Unlimited)]
        public string quantity_per_fraction
        {
            get { return fquantity_per_fraction; }
            set { SetPropertyValue<string>(nameof(quantity_per_fraction), ref fquantity_per_fraction, value); }
        }
        string fpackage_count;
        [Size(SizeAttribute.Unlimited)]
        public string package_count
        {
            get { return fpackage_count; }
            set { SetPropertyValue<string>(nameof(package_count), ref fpackage_count, value); }
        }
        string fcarton_count;
        [Size(SizeAttribute.Unlimited)]
        public string carton_count
        {
            get { return fcarton_count; }
            set { SetPropertyValue<string>(nameof(carton_count), ref fcarton_count, value); }
        }
        string ffraction;
        [Size(SizeAttribute.Unlimited)]
        public string fraction
        {
            get { return ffraction; }
            set { SetPropertyValue<string>(nameof(fraction), ref ffraction, value); }
        }
        string ftotal_fraction;
        [Size(SizeAttribute.Unlimited)]
        public string total_fraction
        {
            get { return ftotal_fraction; }
            set { SetPropertyValue<string>(nameof(total_fraction), ref ftotal_fraction, value); }
        }
        string funiversal_product_code;
        [Size(SizeAttribute.Unlimited)]
        public string universal_product_code
        {
            get { return funiversal_product_code; }
            set { SetPropertyValue<string>(nameof(universal_product_code), ref funiversal_product_code, value); }
        }
        string flogistics_code;
        [Size(SizeAttribute.Unlimited)]
        public string logistics_code
        {
            get { return flogistics_code; }
            set { SetPropertyValue<string>(nameof(logistics_code), ref flogistics_code, value); }
        }
        string fouter_product_code;
        [Size(SizeAttribute.Unlimited)]
        public string outer_product_code
        {
            get { return fouter_product_code; }
            set { SetPropertyValue<string>(nameof(outer_product_code), ref fouter_product_code, value); }
        }
        string funit_type;
        [Size(SizeAttribute.Unlimited)]
        public string unit_type
        {
            get { return funit_type; }
            set { SetPropertyValue<string>(nameof(unit_type), ref funit_type, value); }
        }
        string fdetail_order_number;
        [Size(SizeAttribute.Unlimited)]
        public string detail_order_number
        {
            get { return fdetail_order_number; }
            set { SetPropertyValue<string>(nameof(detail_order_number), ref fdetail_order_number, value); }
        }
        string fpackage_status;
        [Size(SizeAttribute.Unlimited)]
        public string package_status
        {
            get { return fpackage_status; }
            set { SetPropertyValue<string>(nameof(package_status), ref fpackage_status, value); }
        }
        string fcarton_status;
        [Size(SizeAttribute.Unlimited)]
        public string carton_status
        {
            get { return fcarton_status; }
            set { SetPropertyValue<string>(nameof(carton_status), ref fcarton_status, value); }
        }
        string ffraction_status;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_status
        {
            get { return ffraction_status; }
            set { SetPropertyValue<string>(nameof(fraction_status), ref ffraction_status, value); }
        }
        DateTime fpackage_dispatched_at;
        [Indexed(Name = @"IX_COnePicksV1_package_dispatched_at")]
        public DateTime package_dispatched_at
        {
            get { return fpackage_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(package_dispatched_at), ref fpackage_dispatched_at, value); }
        }
        string fpackage_dispatched_by;
        [Size(SizeAttribute.Unlimited)]
        public string package_dispatched_by
        {
            get { return fpackage_dispatched_by; }
            set { SetPropertyValue<string>(nameof(package_dispatched_by), ref fpackage_dispatched_by, value); }
        }
        DateTime fcarton_dispatched_at;
        [Indexed(Name = @"IX_COnePicksV1_carton_dispatched_at")]
        public DateTime carton_dispatched_at
        {
            get { return fcarton_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(carton_dispatched_at), ref fcarton_dispatched_at, value); }
        }
        string fcarton_dispatched_by;
        [Size(SizeAttribute.Unlimited)]
        public string carton_dispatched_by
        {
            get { return fcarton_dispatched_by; }
            set { SetPropertyValue<string>(nameof(carton_dispatched_by), ref fcarton_dispatched_by, value); }
        }
        DateTime ffraction_dispatched_at;
        [Indexed(Name = @"IX_COnePicksV1_fraction_dispatched_at")]
        public DateTime fraction_dispatched_at
        {
            get { return ffraction_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(fraction_dispatched_at), ref ffraction_dispatched_at, value); }
        }
        string ffraction_dispatched_by;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_dispatched_by
        {
            get { return ffraction_dispatched_by; }
            set { SetPropertyValue<string>(nameof(fraction_dispatched_by), ref ffraction_dispatched_by, value); }
        }
        string fcarton_packed_at;
        [Size(SizeAttribute.Unlimited)]
        public string carton_packed_at
        {
            get { return fcarton_packed_at; }
            set { SetPropertyValue<string>(nameof(carton_packed_at), ref fcarton_packed_at, value); }
        }
        string fcarton_packed_by;
        [Size(SizeAttribute.Unlimited)]
        public string carton_packed_by
        {
            get { return fcarton_packed_by; }
            set { SetPropertyValue<string>(nameof(carton_packed_by), ref fcarton_packed_by, value); }
        }
        string ffraction_packed_at;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_packed_at
        {
            get { return ffraction_packed_at; }
            set { SetPropertyValue<string>(nameof(fraction_packed_at), ref ffraction_packed_at, value); }
        }
        string ffraction_packed_by;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_packed_by
        {
            get { return ffraction_packed_by; }
            set { SetPropertyValue<string>(nameof(fraction_packed_by), ref ffraction_packed_by, value); }
        }
        string fpackage_inspected_1_at;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_1_at
        {
            get { return fpackage_inspected_1_at; }
            set { SetPropertyValue<string>(nameof(package_inspected_1_at), ref fpackage_inspected_1_at, value); }
        }
        string fpackage_inspected_1_by;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_1_by
        {
            get { return fpackage_inspected_1_by; }
            set { SetPropertyValue<string>(nameof(package_inspected_1_by), ref fpackage_inspected_1_by, value); }
        }
        string fcarton_inspected_1_at;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_1_at
        {
            get { return fcarton_inspected_1_at; }
            set { SetPropertyValue<string>(nameof(carton_inspected_1_at), ref fcarton_inspected_1_at, value); }
        }
        string fcarton_inspected_1_by;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_1_by
        {
            get { return fcarton_inspected_1_by; }
            set { SetPropertyValue<string>(nameof(carton_inspected_1_by), ref fcarton_inspected_1_by, value); }
        }
        string ffraction_inspected_1_at;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_1_at
        {
            get { return ffraction_inspected_1_at; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_1_at), ref ffraction_inspected_1_at, value); }
        }
        string ffraction_inspected_1_by;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_1_by
        {
            get { return ffraction_inspected_1_by; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_1_by), ref ffraction_inspected_1_by, value); }
        }
        string fpackage_inspected_2_at;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_2_at
        {
            get { return fpackage_inspected_2_at; }
            set { SetPropertyValue<string>(nameof(package_inspected_2_at), ref fpackage_inspected_2_at, value); }
        }
        string fpackage_inspected_2_by;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_2_by
        {
            get { return fpackage_inspected_2_by; }
            set { SetPropertyValue<string>(nameof(package_inspected_2_by), ref fpackage_inspected_2_by, value); }
        }
        string fcarton_inspected_2_at;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_2_at
        {
            get { return fcarton_inspected_2_at; }
            set { SetPropertyValue<string>(nameof(carton_inspected_2_at), ref fcarton_inspected_2_at, value); }
        }
        string fcarton_inspected_2_by;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_2_by
        {
            get { return fcarton_inspected_2_by; }
            set { SetPropertyValue<string>(nameof(carton_inspected_2_by), ref fcarton_inspected_2_by, value); }
        }
        string ffraction_inspected_2_at;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_2_at
        {
            get { return ffraction_inspected_2_at; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_2_at), ref ffraction_inspected_2_at, value); }
        }
        string ffraction_inspected_2_by;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_2_by
        {
            get { return ffraction_inspected_2_by; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_2_by), ref ffraction_inspected_2_by, value); }
        }
        string fpackage_inspected_3_at;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_3_at
        {
            get { return fpackage_inspected_3_at; }
            set { SetPropertyValue<string>(nameof(package_inspected_3_at), ref fpackage_inspected_3_at, value); }
        }
        string fpackage_inspected_3_by;
        [Size(SizeAttribute.Unlimited)]
        public string package_inspected_3_by
        {
            get { return fpackage_inspected_3_by; }
            set { SetPropertyValue<string>(nameof(package_inspected_3_by), ref fpackage_inspected_3_by, value); }
        }
        string fcarton_inspected_3_at;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_3_at
        {
            get { return fcarton_inspected_3_at; }
            set { SetPropertyValue<string>(nameof(carton_inspected_3_at), ref fcarton_inspected_3_at, value); }
        }
        string fcarton_inspected_3_by;
        [Size(SizeAttribute.Unlimited)]
        public string carton_inspected_3_by
        {
            get { return fcarton_inspected_3_by; }
            set { SetPropertyValue<string>(nameof(carton_inspected_3_by), ref fcarton_inspected_3_by, value); }
        }
        string ffraction_inspected_3_at;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_3_at
        {
            get { return ffraction_inspected_3_at; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_3_at), ref ffraction_inspected_3_at, value); }
        }
        string ffraction_inspected_3_by;
        [Size(SizeAttribute.Unlimited)]
        public string fraction_inspected_3_by
        {
            get { return ffraction_inspected_3_by; }
            set { SetPropertyValue<string>(nameof(fraction_inspected_3_by), ref ffraction_inspected_3_by, value); }
        }
        string fis_acquired;
        [Size(SizeAttribute.Unlimited)]
        public string is_acquired
        {
            get { return fis_acquired; }
            set { SetPropertyValue<string>(nameof(is_acquired), ref fis_acquired, value); }
        }
        string fis_canceled;
        [Size(SizeAttribute.Unlimited)]
        public string is_canceled
        {
            get { return fis_canceled; }
            set { SetPropertyValue<string>(nameof(is_canceled), ref fis_canceled, value); }
        }
        string fcreated_at;
        [Size(SizeAttribute.Unlimited)]
        public string created_at
        {
            get { return fcreated_at; }
            set { SetPropertyValue<string>(nameof(created_at), ref fcreated_at, value); }
        }
        string fcreated_by;
        [Size(SizeAttribute.Unlimited)]
        public string created_by
        {
            get { return fcreated_by; }
            set { SetPropertyValue<string>(nameof(created_by), ref fcreated_by, value); }
        }
        string fupdated_at;
        [Size(SizeAttribute.Unlimited)]
        public string updated_at
        {
            get { return fupdated_at; }
            set { SetPropertyValue<string>(nameof(updated_at), ref fupdated_at, value); }
        }
        string fupdated_by;
        [Size(SizeAttribute.Unlimited)]
        public string updated_by
        {
            get { return fupdated_by; }
            set { SetPropertyValue<string>(nameof(updated_by), ref fupdated_by, value); }
        }
        string fentity;
        [Size(SizeAttribute.Unlimited)]
        public string entity
        {
            get { return fentity; }
            set { SetPropertyValue<string>(nameof(entity), ref fentity, value); }
        }
        DateTime ftimestamp;
        [Indexed(Name = @"nci_wi_COnePicksV1_FF34DABD8411F30C60215043CDE83C7B")]
        public DateTime timestamp
        {
            get { return ftimestamp; }
            set { SetPropertyValue<DateTime>(nameof(timestamp), ref ftimestamp, value); }
        }
        string freceiver_names;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_names
        {
            get { return freceiver_names; }
            set { SetPropertyValue<string>(nameof(receiver_names), ref freceiver_names, value); }
        }
    }

}
