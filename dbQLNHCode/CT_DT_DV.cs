﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QL_DatTiecNhaHang.QLDatTiecNhaHang
{

    public partial class CT_DT_DV
    {
        public CT_DT_DV(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}