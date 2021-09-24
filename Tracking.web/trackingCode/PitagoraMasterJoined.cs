using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Tracking.web.sql_trackingdb_stag
{

    public partial class PitagoraMasterJoined
    {
        public PitagoraMasterJoined(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
