using DevExpress.ExpressApp;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.ExpressApp.Xpo;
using Tracking.web.sql_trackingdb_stag;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Threading;

namespace Tracking.web.Data
{
    public abstract class BaseService
    {
        readonly IDataLayer dataLayer;
        protected readonly UnitOfWork readUnitOfWork;
      //  protected readonly IObjectSpace _IObjectSpace;
        public BaseService(IDataLayer dataLayer, UnitOfWork readUnitOfWork)
        {
            this.dataLayer = dataLayer;
            this.readUnitOfWork = readUnitOfWork;
            //this._IObjectSpace = objectSpace;
        }
        protected UnitOfWork CreateModificationUnitOfWork()
        {
            return new UnitOfWork(dataLayer);
        }
    }
    public class COneMastersV1Service : BaseService
    {
       // private XPClassInfo classInfo;
      //  public COneMastersV1 CreateObject<COneMastersV1>();


        public COneMastersV1Service(IDataLayer dataLayer, UnitOfWork modificationUnitOfWork)
            : base(dataLayer, modificationUnitOfWork ) { }
        public IQueryable<COneMasterV1Model> Get()
        {
            IQueryable<COneMasterV1Model> yes = null;
            try {
                DateTime cd = DateTime.Now.Date;
                XPQuery<COneMastersV1> COneMastersV1 = new XPQuery<COneMastersV1>(readUnitOfWork);
                XPQuery<Shippers> Shippers = new XPQuery<Shippers>(readUnitOfWork);
                return  COneMastersV1
                    .Where(a => (a.delivery_date == cd)). 
                   // ||a.user_delivery_date == cd)).
                    Join(Shippers,
                               CM => CM.shipper_code,
                               S => S.ShipperCode,
                               (CM, S) => new { CM, S })
                        .Select(S => new COneMasterV1Model()
                        {
                            capacity = S.CM.capacity,
                            carton_dispatched_at = S.CM.carton_dispatched_at,
                            client_order_date = S.CM.client_order_date,
                            delivery_code = S.CM.delivery_code,
                            delivery_date = S.CM.delivery_date,
                            detail_order_number = S.CM.detail_order_number,
                            fraction_dispatched_at = S.CM.fraction_dispatched_at,
                            id = S.CM.id,
                            item_line = S.CM.item_line,
                            item_line_column = S.CM.item_line_column,
                            LastUpdatedOn = S.CM.LastUpdatedOn,
                            order_fraction = S.CM.order_fraction,
                            order_package_count = S.CM.order_package_count,
                            order_total_fraction = S.CM.order_total_fraction,
                            package_dispatched_at = S.CM.package_dispatched_at,
                            product_code = S.CM.product_code,
                            product_name = S.CM.product_name,
                            quantity_per_package = S.CM.quantity_per_package,
                            receiver_address1 = S.CM.receiver_address1,
                            receiver_address2 = S.CM.receiver_address2,
                            receiver_address3 = S.CM.receiver_address3,
                            receiver_name1 = S.CM.receiver_name1,
                            receiver_name2 = S.CM.receiver_name2,
                            receiver_name3 = S.CM.receiver_name3,
                            receiver_names = S.CM.receiver_names,
                            receiver_tel = S.CM.receiver_tel,
                            retrieval_date = S.CM.retrieval_date,
                            sales_office_address1 = S.CM.sales_office_address1,
                            sales_office_code = S.CM.sales_office_code,
                            sales_office_name = S.CM.sales_office_name,
                            shipper_accounting_date = S.CM.shipper_accounting_date,
                            shipper_branch_name = S.CM.shipper_branch_name,
                            shipper_code = S.CM.shipper_code,
                            // shipper_name = S.S.ShipperShortName,
                            shipper_trading_name = S.CM.shipper_trading_name,
                            shipper_trading_short_name = S.CM.shipper_trading_short_name,
                            slip_number = S.CM.slip_number,
                            Status = (S.CM.user_delivery_status_changed_at > S.CM.LastUpdatedOn ? S.CM.user_delivery_status : S.CM.Status), // Showing updated status.
                            transporter_code = S.CM.transporter_code,
                            transporter_name = S.CM.transporter_name,
                            user_delivery_date = S.CM.user_delivery_date,
                            user_delivery_date_changed_at = S.CM.user_delivery_date_changed_at,
                            user_delivery_date_changed_by = S.CM.user_delivery_date_changed_by,
                            user_delivery_status = S.CM.user_delivery_status,
                            user_delivery_status_changed_at = S.CM.user_delivery_status_changed_at,
                            user_delivery_status_changed_by = S.CM.user_delivery_status_changed_by,
                            warehouse_code = S.CM.warehouse_code,
                            warehouse_company_name = S.CM.warehouse_company_name,
                            warehouse_name = S.CM.warehouse_name,
                            wms_processing_date = S.CM.wms_processing_date
                            //  shipper_full_name = S.S.ShipperFullName
                            //COnePicksV1_carton_dispatched_at = S.CM.COnePicksV1_carton_dispatched_at,
                            //COnePicksV1_fraction_dispatched_at = S.CM.COnePicksV1_fraction_dispatched_at,
                            //COnePicksV1_package_dispatched_at = S.CM.COnePicksV1_package_dispatched_at,
                            //Idsoko_PicksV1_CHECKEND_DT = S.CM.Idsoko_PicksV1_CHECKEND_DT
                        }).AsQueryable();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                return yes;

            }
       
            //return (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>().
            //    Where(a => a.delivery_date == cd || (a.user_delivery_date == cd)).Join(readUnitOfWork.Query<Shippers>() ,);
            //var a = (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>().
            //    Where(a => a.delivery_date == cd || (a.user_delivery_date == cd));



            ////var a = (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>().
            ////   Where(a => a.delivery_date == cd || (a.user_delivery_date == cd));

            //var b = (IQueryable<Shippers>)readUnitOfWork.Query<Shippers>();
            //// var s = a.Join(a , a.)
            //var q = from ConeMaster in a
            //        join shipper in b on ConeMaster.shipper_code equals shipper.ShipperCode
            //        // where post.ID == id
            //        select new {  ConeMaster };
            //return (IQueryable<COneMastersV1>)q;
            // Session session = new Session() ;
            //    IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Department))
            //XPObjectType xPObjectType = new XPObjectType()

            //XPQuery<COneMastersV1> cOneMasters = new XPQuery<COneMastersV1>(readUnitOfWork);
            //XPQuery<Shippers> shippers = new XPQuery<Shippers>(readUnitOfWork);
            //return (IQueryable<COneMastersV1>)((from e in cOneMasters
            //                                    join o in shippers on e.shipper_code equals o.ShipperCode
            //                                    where e.delivery_date == cd || (e.user_delivery_date == cd)
            //                                    select new COneMastersV1(readUnitOfWork)
            //                                    {
            //                                        id = e.id,
            //                                        slip_number = e.slip_number,
            //                                        item_line = e.item_line,
            //                                        item_line_column = e.item_line_column,
            //                                        shipper_code = e.shipper_code,
            //                                        sales_office_code = e.sales_office_code,
            //                                        delivery_date = e.delivery_date,
            //                                        client_order_date = e.client_order_date,
            //                                        shipper_accounting_date = e.shipper_accounting_date,
            //                                        detail_order_number = e.detail_order_number,
            //                                        warehouse_code = e.warehouse_code,
            //                                        warehouse_name = e.warehouse_name,
            //                                        transporter_code = e.transporter_code,
            //                                        transporter_name = e.transporter_name,
            //                                        delivery_code = e.delivery_code,
            //                                        receiver_name1 = e.receiver_name1,
            //                                        receiver_name2 = e.receiver_name2,
            //                                        receiver_name3 = e.receiver_name3,
            //                                        receiver_address1 = e.receiver_address1,
            //                                        receiver_address2 = e.receiver_address2,
            //                                        receiver_address3 = e.receiver_address3,
            //                                        receiver_tel = e.receiver_tel,
            //                                        shipper_name = e.shipper_name,
            //                                        shipper_branch_name = e.shipper_branch_name,
            //                                        product_code = e.product_code,
            //                                        product_name = e.product_name,
            //                                        capacity = e.capacity,
            //                                        order_fraction = e.order_fraction,
            //                                        quantity_per_package = e.quantity_per_package,
            //                                        order_package_count = e.order_package_count,
            //                                        order_total_fraction = e.order_total_fraction,
            //                                        warehouse_company_name = e.warehouse_company_name,
            //                                        sales_office_name = e.sales_office_name,
            //                                        sales_office_address1 = e.sales_office_address1,
            //                                        wms_processing_date = e.wms_processing_date,
            //                                        package_dispatched_at = e.package_dispatched_at,
            //                                        carton_dispatched_at = e.carton_dispatched_at,
            //                                        fraction_dispatched_at = e.fraction_dispatched_at,
            //                                        retrieval_date = e.retrieval_date,
            //                                        Status = e.Status,
            //                                        LastUpdatedOn = e.LastUpdatedOn,
            //                                        shipper_trading_name = e.shipper_trading_name,
            //                                        shipper_trading_short_name = e.shipper_trading_short_name,
            //                                        receiver_names = e.receiver_names,
            //                                        user_delivery_date = e.user_delivery_date,
            //                                        user_delivery_date_changed_at = e.user_delivery_date_changed_at,
            //                                        user_delivery_date_changed_by = e.user_delivery_date_changed_by,
            //                                        user_delivery_status = e.user_delivery_status,
            //                                        user_delivery_status_changed_at = e.user_delivery_status_changed_at,
            //                                        user_delivery_status_changed_by = e.user_delivery_status_changed_by,
            //                                        shipper_Full_Name = o.ShipperFullName,
            //                                        shipper_Short_Name = o.ShipperShortName,
            //                                    }));

       
            //return (IQueryable<COneMasterV1Model>)s.Where(A => A.delivery_date == cd || (A.user_delivery_date == cd));


                        //return (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>().
                        //     Where(a => a.delivery_date == cd || (a.user_delivery_date == cd));


            // select e;
            //   select new { e.shipper_Full_Name = e.shi, CatalogId = p.CatalogId, ManufacturerId = p.ManufacturerId, CatalogName = c.Name, ManufacturerName = m.Name };

            //XPView view = new XPView(readUnitOfWork, classInfo);
            //view.AddProperty("COneMastersV1", "[COneMastersV1]");
            //view.AddProperty("Shippers", "[Shippers]");
            //view.Criteria = CriteriaOperator.Parse("[user_delivery_date] ==" + cd, null);
            //return view;

        }
        //static string queryString = "SELECT EmployeeID, (FirstName + ' ' " +
        // "+ LastName) as Name, City, Country FROM " +
        // "[Northwind].[dbo].[Employees]";

        //public SelectedData GetEmployeesSimpleData()
        //{
        //    return readUnitOfWork.ExecuteQuery(queryString);
        //}
        //XpoTypesInfoHelper.GetXpoTypeInfoSource();
        //XafTypesInfo.Instance.RegisterEntity(typeof(COneMastersV1));
        //XPObjectSpaceProvider osProvider = new XPObjectSpaceProvider(
        //@"Data Source=sql-otsukawh-stag-secondary.database.windows.net,1433;User ID=otsuka-stag-admin;Password=2quQv!2Jasd4N=4x;Initial Catalog=sql-trackingdb-stag;Persist Security Info=true", null);
        //IObjectSpace objectSpace = osProvider.CreateObjectSpace();
        // var query = (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>();
        //return (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>();
        //return objectSpace.GetObjectsQuery<COneMastersV1>().Where(a => a.delivery_date == cd || (a.user_delivery_date == cd));
        //var query = readUnitOfWork.Query<Order>().Where(order => order.Customer.Oid == customerOid);
        //return Task.FromResult(query);

        //    var q2 = unitOfWork.Query<Customer>()
        //.Select(c => new CustomerDetails()
        //{
        //    ContactName = string.Concat(c.FirstName, " ", c.LastName),
        //    City = c.Address.City,
        //    TotalAmount = c.Orders.Sum(o => o.Amount)
        //});

        public async Task Add(Dictionary<string, object> values)
        {
            using (UnitOfWork uow = CreateModificationUnitOfWork())
            {
                COneMastersV1 newCustomer = new COneMastersV1(uow);
                // PopulateObjectHelper.PopulateObject(uow, newCustomer, values);
                await uow.CommitChangesAsync();
            }
        }
        public async Task Update(int oid, Dictionary<string, object> values)
        {
            using (UnitOfWork uow = CreateModificationUnitOfWork())
            {
                COneMastersV1 customer = uow.GetObjectByKey<COneMastersV1>(oid);
                //   PopulateObjectHelper.PopulateObject(uow, customer, values);
                await uow.CommitChangesAsync();
            }
        }
        public async Task Delete(int oid)
        {
            using (UnitOfWork uow = CreateModificationUnitOfWork())
            {
                var customer = await uow.GetObjectByKeyAsync<COneMastersV1>(oid);
                customer.Delete();
                await uow.CommitChangesAsync();
            }
        }
    }
}
