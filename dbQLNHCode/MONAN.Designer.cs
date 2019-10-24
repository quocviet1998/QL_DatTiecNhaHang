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

    public partial class MONAN : XPLiteObject
    {
        int fIdMA;
        [Key(true)]
        public int IdMA
        {
            get { return fIdMA; }
            set { SetPropertyValue<int>(nameof(IdMA), ref fIdMA, value); }
        }
        string fTenMA;
        [Size(200)]
        public string TenMA
        {
            get { return fTenMA; }
            set { SetPropertyValue<string>(nameof(TenMA), ref fTenMA, value); }
        }
        string fDVT;
        [Size(10)]
        public string DVT
        {
            get { return fDVT; }
            set { SetPropertyValue<string>(nameof(DVT), ref fDVT, value); }
        }
        decimal fDonGia;
        public decimal DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<decimal>(nameof(DonGia), ref fDonGia, value); }
        }
        string fGhiChu;
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        LOAIMONAN fIdLMA;
        [Association(@"MONANReferencesLOAIMONAN")]
        public LOAIMONAN IdLMA
        {
            get { return fIdLMA; }
            set { SetPropertyValue<LOAIMONAN>(nameof(IdLMA), ref fIdLMA, value); }
        }
        [Association(@"CT_PHATSINHReferencesMONAN")]
        public XPCollection<CT_PHATSINH> CT_PHATSINHs { get { return GetCollection<CT_PHATSINH>(nameof(CT_PHATSINHs)); } }
    }

}
