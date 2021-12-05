using System;

namespace Tracking.web.Data
{
    public class COneMasterV1Model
    {
        public COneMasterV1Model()
        {
        }

        public string capacity { get; set; }
        public DateTime carton_dispatched_at { get; set; }
        public DateTime client_order_date { get; set; }
        public string delivery_code { get; set; }
        public DateTime delivery_date { get; set; }
        public string detail_order_number { get; set; }
        public DateTime fraction_dispatched_at { get; set; }
        public long id { get; set; }
        public int item_line { get; set; }
        public int item_line_column { get; set; }
        public DateTime LastUpdatedOn { get; set; }
        public int order_fraction { get; set; }
        public int order_package_count { get; set; }
        public int order_total_fraction { get; set; }
        public DateTime package_dispatched_at { get; set; }
        public string product_code { get; set; }
        public string product_name { get; set; }
        public int quantity_per_package { get; set; }
        public string receiver_address1 { get; set; }
        public string receiver_address2 { get; set; }
        public string receiver_address3 { get; set; }
        public string receiver_name1 { get; set; }
        public string receiver_name2 { get; set; }
        public string receiver_name3 { get; set; }
        public string receiver_names { get; set; }
        public string receiver_tel { get; set; }
        public DateTime retrieval_date { get; set; }
        public string sales_office_address1 { get; set; }
        public string sales_office_code { get; set; }
        public string sales_office_name { get; set; }
        public DateTime shipper_accounting_date { get; set; }
        public string shipper_branch_name { get; set; }
        public string shipper_code { get; set; }
        public string shipper_name { get; set; }
        public string shipper_trading_name { get; set; }
        public string shipper_trading_short_name { get; set; }
        public string slip_number { get; set; }
        public string Status { get; set; }
        public string transporter_code { get; set; }
        public string transporter_name { get; set; }
        public DateTime user_delivery_date { get; set; }
        public DateTime user_delivery_date_changed_at { get; set; }
        public string user_delivery_date_changed_by { get; set; }
        public string user_delivery_status { get; set; }
        public DateTime user_delivery_status_changed_at { get; set; }
        public string user_delivery_status_changed_by { get; set; }
        public string warehouse_code { get; set; }
        public string warehouse_company_name { get; set; }
        public string warehouse_name { get; set; }
        public DateTime wms_processing_date { get; set; }
       public string shipper_full_name { get; set; }
        public DateTime COnePicksV1_carton_dispatched_at { get; set; }
        public DateTime COnePicksV1_fraction_dispatched_at { get; set; }
        public DateTime COnePicksV1_package_dispatched_at { get; set; }
        public DateTime Idsoko_PicksV1_CHECKEND_DT { get; set; }
    }
}