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
namespace QL_DatTiecNhaHang.QLDatTiecNhaHang
{

    public partial class DODUNG : XPLiteObject
    {
        int fIdDD;
        [Key(true)]
        public int IdDD
        {
            get { return fIdDD; }
            set { SetPropertyValue<int>(nameof(IdDD), ref fIdDD, value); }
        }
        string fTenDD;
        [Size(20)]
        public string TenDD
        {
            get { return fTenDD; }
            set { SetPropertyValue<string>(nameof(TenDD), ref fTenDD, value); }
        }
        decimal fChiPhiDD;
        public decimal ChiPhiDD
        {
            get { return fChiPhiDD; }
            set { SetPropertyValue<decimal>(nameof(ChiPhiDD), ref fChiPhiDD, value); }
        }
        [Association(@"CT_PHATSINHReferencesDODUNG")]
        public XPCollection<CT_PHATSINH> CT_PHATSINHs { get { return GetCollection<CT_PHATSINH>(nameof(CT_PHATSINHs)); } }
    }

}