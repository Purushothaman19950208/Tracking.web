using DevExpress.ExpressApp;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tracking.web.sql_trackingdb_stag;

namespace Tracking.web.Data
{
    public abstract class BaseService
    {
        readonly IDataLayer dataLayer;
        protected readonly UnitOfWork readUnitOfWork;
        public BaseService(IDataLayer dataLayer, UnitOfWork readUnitOfWork)
        {
            this.dataLayer = dataLayer;
            this.readUnitOfWork = readUnitOfWork;
        }
        protected UnitOfWork CreateModificationUnitOfWork()
        {
            return new UnitOfWork(dataLayer);
        }
    }
    public class COneMastersV1Service : BaseService
    {
        public COneMastersV1Service(IDataLayer dataLayer, UnitOfWork modificationUnitOfWork)
            : base(dataLayer, modificationUnitOfWork) { }
        public IQueryable<COneMastersV1> Get()
        {
            DateTime cd = DateTime.Now.Date;           
            // var query = (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>();
            return (IQueryable<COneMastersV1>)readUnitOfWork.Query<COneMastersV1>().Where(a => a.delivery_date == cd || (a.user_delivery_date == cd));
        //   IQueryable<COneMastersV1> query = .GetObjectsQuery<COneMastersV1>();
            //var query = readUnitOfWork.Query<Order>().Where(order => order.Customer.Oid == customerOid);
            //return Task.FromResult(query);
        }
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
