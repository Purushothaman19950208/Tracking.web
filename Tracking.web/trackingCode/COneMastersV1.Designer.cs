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

    [Indices(@"shipper_code;wms_processing_date", "sales_office_code;wms_processing_date", "shipper_code;sales_office_code")]
    public partial class COneMastersV1 : XPLiteObject
    {
        long fid;
        [Key]
        public long id
        {
            get { return fid; }
            set { SetPropertyValue<long>(nameof(id), ref fid, value); }
        }
        string fslip_number;
        [Indexed(Name = @"IX_COneMastersV1_slip_number")]
        [Size(20)]
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
        [Indexed(Name = @"IX_COneMastersV1_shipper_code")]
        [Size(10)]
        public string shipper_code
        {
            get { return fshipper_code; }
            set { SetPropertyValue<string>(nameof(shipper_code), ref fshipper_code, value); }
        }
        string fsales_office_code;
        [Indexed(Name = @"IX_COneMastersV1_sales_office_code")]
        [Size(10)]
        public string sales_office_code
        {
            get { return fsales_office_code; }
            set { SetPropertyValue<string>(nameof(sales_office_code), ref fsales_office_code, value); }
        }
        DateTime fdelivery_date;
        [Indexed(Name = @"IX_COneMastersV1_delivery_date")]
        public DateTime delivery_date
        {
            get { return fdelivery_date; }
            set { SetPropertyValue<DateTime>(nameof(delivery_date), ref fdelivery_date, value); }
        }
        DateTime fclient_order_date;
        [Indexed(Name = @"IX_COneMastersV1_client_order_date")]
        public DateTime client_order_date
        {
            get { return fclient_order_date; }
            set { SetPropertyValue<DateTime>(nameof(client_order_date), ref fclient_order_date, value); }
        }
        DateTime fshipper_accounting_date;
        [Indexed(Name = @"IX_COneMastersV1_shipper_accounting_date")]
        public DateTime shipper_accounting_date
        {
            get { return fshipper_accounting_date; }
            set { SetPropertyValue<DateTime>(nameof(shipper_accounting_date), ref fshipper_accounting_date, value); }
        }
        string fdetail_order_number;
        [Indexed(Name = @"IX_COneMastersV1_detail_order_number")]
        [Size(450)]
        public string detail_order_number
        {
            get { return fdetail_order_number; }
            set { SetPropertyValue<string>(nameof(detail_order_number), ref fdetail_order_number, value); }
        }
        string fwarehouse_code;
        [Indexed(Name = @"IX_COneMastersV1_warehouse_code")]
        [Size(450)]
        public string warehouse_code
        {
            get { return fwarehouse_code; }
            set { SetPropertyValue<string>(nameof(warehouse_code), ref fwarehouse_code, value); }
        }
        string fwarehouse_name;
        [Indexed(Name = @"IX_COneMastersV1_warehouse_name")]
        [Size(450)]
        public string warehouse_name
        {
            get { return fwarehouse_name; }
            set { SetPropertyValue<string>(nameof(warehouse_name), ref fwarehouse_name, value); }
        }
        string ftransporter_code;
        [Indexed(Name = @"IX_COneMastersV1_transporter_code")]
        [Size(450)]
        public string transporter_code
        {
            get { return ftransporter_code; }
            set { SetPropertyValue<string>(nameof(transporter_code), ref ftransporter_code, value); }
        }
        string ftransporter_name;
        [Indexed(Name = @"IX_COneMastersV1_transporter_name")]
        [Size(450)]
        public string transporter_name
        {
            get { return ftransporter_name; }
            set { SetPropertyValue<string>(nameof(transporter_name), ref ftransporter_name, value); }
        }
        string fdelivery_code;
        [Indexed(Name = @"IX_COneMastersV1_delivery_code")]
        [Size(450)]
        public string delivery_code
        {
            get { return fdelivery_code; }
            set { SetPropertyValue<string>(nameof(delivery_code), ref fdelivery_code, value); }
        }
        string freceiver_name1;
        [Indexed(Name = @"IX_COneMastersV1_receiver_name1")]
        [Size(450)]
        public string receiver_name1
        {
            get { return freceiver_name1; }
            set { SetPropertyValue<string>(nameof(receiver_name1), ref freceiver_name1, value); }
        }
        string freceiver_name2;
        [Indexed(Name = @"IX_COneMastersV1_receiver_name2")]
        [Size(450)]
        public string receiver_name2
        {
            get { return freceiver_name2; }
            set { SetPropertyValue<string>(nameof(receiver_name2), ref freceiver_name2, value); }
        }
        string freceiver_name3;
        [Indexed(Name = @"IX_COneMastersV1_receiver_name3")]
        [Size(450)]
        public string receiver_name3
        {
            get { return freceiver_name3; }
            set { SetPropertyValue<string>(nameof(receiver_name3), ref freceiver_name3, value); }
        }
        string freceiver_address1;
        [Indexed(Name = @"IX_COneMastersV1_receiver_address1")]
        [Size(450)]
        public string receiver_address1
        {
            get { return freceiver_address1; }
            set { SetPropertyValue<string>(nameof(receiver_address1), ref freceiver_address1, value); }
        }
        string freceiver_address2;
        [Indexed(Name = @"IX_COneMastersV1_receiver_address2")]
        [Size(450)]
        public string receiver_address2
        {
            get { return freceiver_address2; }
            set { SetPropertyValue<string>(nameof(receiver_address2), ref freceiver_address2, value); }
        }
        string freceiver_address3;
        [Indexed(Name = @"IX_COneMastersV1_receiver_address3")]
        [Size(450)]
        public string receiver_address3
        {
            get { return freceiver_address3; }
            set { SetPropertyValue<string>(nameof(receiver_address3), ref freceiver_address3, value); }
        }
        string freceiver_tel;
        [Indexed(Name = @"IX_COneMastersV1_receiver_tel")]
        [Size(450)]
        public string receiver_tel
        {
            get { return freceiver_tel; }
            set { SetPropertyValue<string>(nameof(receiver_tel), ref freceiver_tel, value); }
        }
        string fshipper_name;
        [Indexed(Name = @"IX_COneMastersV1_shipper_name")]
        [Size(450)]
        public string shipper_name
        {
            get { return fshipper_name; }
            set { SetPropertyValue<string>(nameof(shipper_name), ref fshipper_name, value); }
        }
        string fshipper_branch_name;
        [Indexed(Name = @"IX_COneMastersV1_shipper_branch_name")]
        [Size(450)]
        public string shipper_branch_name
        {
            get { return fshipper_branch_name; }
            set { SetPropertyValue<string>(nameof(shipper_branch_name), ref fshipper_branch_name, value); }
        }
        string fproduct_code;
        [Indexed(Name = @"IX_COneMastersV1_product_code")]
        [Size(450)]
        public string product_code
        {
            get { return fproduct_code; }
            set { SetPropertyValue<string>(nameof(product_code), ref fproduct_code, value); }
        }
        string fproduct_name;
        [Indexed(Name = @"IX_COneMastersV1_product_name")]
        [Size(450)]
        public string product_name
        {
            get { return fproduct_name; }
            set { SetPropertyValue<string>(nameof(product_name), ref fproduct_name, value); }
        }
        string fcapacity;
        [Indexed(Name = @"IX_COneMastersV1_capacity")]
        [Size(450)]
        public string capacity
        {
            get { return fcapacity; }
            set { SetPropertyValue<string>(nameof(capacity), ref fcapacity, value); }
        }
        int forder_fraction;
        [Indexed(Name = @"IX_COneMastersV1_order_fraction")]
        public int order_fraction
        {
            get { return forder_fraction; }
            set { SetPropertyValue<int>(nameof(order_fraction), ref forder_fraction, value); }
        }
        int fquantity_per_package;
        [Indexed(Name = @"IX_COneMastersV1_quantity_per_package")]
        public int quantity_per_package
        {
            get { return fquantity_per_package; }
            set { SetPropertyValue<int>(nameof(quantity_per_package), ref fquantity_per_package, value); }
        }
        int forder_package_count;
        [Indexed(Name = @"IX_COneMastersV1_order_package_count")]
        public int order_package_count
        {
            get { return forder_package_count; }
            set { SetPropertyValue<int>(nameof(order_package_count), ref forder_package_count, value); }
        }
        int forder_total_fraction;
        [Indexed(Name = @"IX_COneMastersV1_order_total_fraction")]
        public int order_total_fraction
        {
            get { return forder_total_fraction; }
            set { SetPropertyValue<int>(nameof(order_total_fraction), ref forder_total_fraction, value); }
        }
        string fwarehouse_company_name;
        [Indexed(Name = @"IX_COneMastersV1_warehouse_company_name")]
        [Size(450)]
        public string warehouse_company_name
        {
            get { return fwarehouse_company_name; }
            set { SetPropertyValue<string>(nameof(warehouse_company_name), ref fwarehouse_company_name, value); }
        }
        string fsales_office_name;
        [Indexed(Name = @"IX_COneMastersV1_sales_office_name")]
        [Size(450)]
        public string sales_office_name
        {
            get { return fsales_office_name; }
            set { SetPropertyValue<string>(nameof(sales_office_name), ref fsales_office_name, value); }
        }
        string fsales_office_address1;
        [Indexed(Name = @"IX_COneMastersV1_sales_office_address1")]
        [Size(450)]
        public string sales_office_address1
        {
            get { return fsales_office_address1; }
            set { SetPropertyValue<string>(nameof(sales_office_address1), ref fsales_office_address1, value); }
        }
        DateTime fwms_processing_date;
        [Indexed(Name = @"IX_COneMastersV1_wms_processing_date")]
        public DateTime wms_processing_date
        {
            get { return fwms_processing_date; }
            set { SetPropertyValue<DateTime>(nameof(wms_processing_date), ref fwms_processing_date, value); }
        }
        DateTime fpackage_dispatched_at;
        [Indexed(Name = @"IX_COneMastersV1_package_dispatched_at")]
        public DateTime package_dispatched_at
        {
            get { return fpackage_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(package_dispatched_at), ref fpackage_dispatched_at, value); }
        }
        DateTime fcarton_dispatched_at;
        [Indexed(Name = @"IX_COneMastersV1_carton_dispatched_at")]
        public DateTime carton_dispatched_at
        {
            get { return fcarton_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(carton_dispatched_at), ref fcarton_dispatched_at, value); }
        }
        DateTime ffraction_dispatched_at;
        [Indexed(Name = @"IX_COneMastersV1_fraction_dispatched_at")]
        public DateTime fraction_dispatched_at
        {
            get { return ffraction_dispatched_at; }
            set { SetPropertyValue<DateTime>(nameof(fraction_dispatched_at), ref ffraction_dispatched_at, value); }
        }
        DateTime fretrieval_date;
        [Indexed(Name = @"IX_COneMastersV1_retrieval_date")]
        public DateTime retrieval_date
        {
            get { return fretrieval_date; }
            set { SetPropertyValue<DateTime>(nameof(retrieval_date), ref fretrieval_date, value); }
        }
        string fStatus;
        [Size(SizeAttribute.Unlimited)]
        public string Status
        {
            get { return fStatus; }
            set { SetPropertyValue<string>(nameof(Status), ref fStatus, value); }
        }
        DateTime fLastUpdatedOn;
        [ColumnDbDefaultValue("('0001-01-01T00:00:00.0000000')")]
        public DateTime LastUpdatedOn
        {
            get { return fLastUpdatedOn; }
            set { SetPropertyValue<DateTime>(nameof(LastUpdatedOn), ref fLastUpdatedOn, value); }
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
        string freceiver_names;
        [Size(SizeAttribute.Unlimited)]
        public string receiver_names
        {
            get { return freceiver_names; }
            set { SetPropertyValue<string>(nameof(receiver_names), ref freceiver_names, value); }
        }
        DateTime fuser_delivery_date;
        [Indexed(Name = @"IX_COneMastersV1_user_delivery_date")]
        public DateTime user_delivery_date
        {
            get { return fuser_delivery_date; }
            set { SetPropertyValue<DateTime>(nameof(user_delivery_date), ref fuser_delivery_date, value); }
        }
        DateTime fuser_delivery_date_changed_at;
        public DateTime user_delivery_date_changed_at
        {
            get { return fuser_delivery_date_changed_at; }
            set { SetPropertyValue<DateTime>(nameof(user_delivery_date_changed_at), ref fuser_delivery_date_changed_at, value); }
        }
        string fuser_delivery_date_changed_by;
        [Size(SizeAttribute.Unlimited)]
        public string user_delivery_date_changed_by
        {
            get { return fuser_delivery_date_changed_by; }
            set { SetPropertyValue<string>(nameof(user_delivery_date_changed_by), ref fuser_delivery_date_changed_by, value); }
        }
        string fuser_delivery_status;
        [Indexed(Name = @"IX_COneMastersV1_user_delivery_status")]
        [Size(450)]
        public string user_delivery_status
        {
            get { return fuser_delivery_status; }
            set { SetPropertyValue<string>(nameof(user_delivery_status), ref fuser_delivery_status, value); }
        }
        DateTime fuser_delivery_status_changed_at;
        public DateTime user_delivery_status_changed_at
        {
            get { return fuser_delivery_status_changed_at; }
            set { SetPropertyValue<DateTime>(nameof(user_delivery_status_changed_at), ref fuser_delivery_status_changed_at, value); }
        }
        string fuser_delivery_status_changed_by;
        [Size(SizeAttribute.Unlimited)]
        public string user_delivery_status_changed_by
        {
            get { return fuser_delivery_status_changed_by; }
            set { SetPropertyValue<string>(nameof(user_delivery_status_changed_by), ref fuser_delivery_status_changed_by, value); }
        }
    }

}