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

    public partial class LOAIDOUONG : XPLiteObject
    {
        int fIdLDU;
        [Key(true)]
        public int IdLDU
        {
            get { return fIdLDU; }
            set { SetPropertyValue<int>(nameof(IdLDU), ref fIdLDU, value); }
        }
        string fTenLDU;
        [Size(50)]
        public string TenLDU
        {
            get { return fTenLDU; }
            set { SetPropertyValue<string>(nameof(TenLDU), ref fTenLDU, value); }
        }
        string fGhiChu;
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"DOUONGReferencesLOAIDOUONG")]
        public XPCollection<DOUONG> DOUONGs { get { return GetCollection<DOUONG>(nameof(DOUONGs)); } }
    }

}
