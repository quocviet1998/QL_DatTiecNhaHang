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

    public partial class SANHTIEC : XPLiteObject
    {
        int fIdST;
        [Key(true)]
        public int IdST
        {
            get { return fIdST; }
            set { SetPropertyValue<int>(nameof(IdST), ref fIdST, value); }
        }
        string fTenST;
        public string TenST
        {
            get { return fTenST; }
            set { SetPropertyValue<string>(nameof(TenST), ref fTenST, value); }
        }
        short fTang;
        public short Tang
        {
            get { return fTang; }
            set { SetPropertyValue<short>(nameof(Tang), ref fTang, value); }
        }
        short fSoBan;
        public short SoBan
        {
            get { return fSoBan; }
            set { SetPropertyValue<short>(nameof(SoBan), ref fSoBan, value); }
        }
        decimal fDonGiaBan;
        public decimal DonGiaBan
        {
            get { return fDonGiaBan; }
            set { SetPropertyValue<decimal>(nameof(DonGiaBan), ref fDonGiaBan, value); }
        }
        decimal fGiaBanTiec_PS;
        public decimal GiaBanTiec_PS
        {
            get { return fGiaBanTiec_PS; }
            set { SetPropertyValue<decimal>(nameof(GiaBanTiec_PS), ref fGiaBanTiec_PS, value); }
        }
        string fGhiChu;
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
    }

}