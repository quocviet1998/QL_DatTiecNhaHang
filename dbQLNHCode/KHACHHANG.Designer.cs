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

    public partial class KHACHHANG : XPLiteObject
    {
        int fIdKH;
        [Key(true)]
        public int IdKH
        {
            get { return fIdKH; }
            set { SetPropertyValue<int>(nameof(IdKH), ref fIdKH, value); }
        }
        string fHoTenKH;
        public string HoTenKH
        {
            get { return fHoTenKH; }
            set { SetPropertyValue<string>(nameof(HoTenKH), ref fHoTenKH, value); }
        }
        DateTime fNgaySinhKH;
        public DateTime NgaySinhKH
        {
            get { return fNgaySinhKH; }
            set { SetPropertyValue<DateTime>(nameof(NgaySinhKH), ref fNgaySinhKH, value); }
        }
        bool fGioiTinhKH;
        public bool GioiTinhKH
        {
            get { return fGioiTinhKH; }
            set { SetPropertyValue<bool>(nameof(GioiTinhKH), ref fGioiTinhKH, value); }
        }
        string fDiaChiKH;
        [Size(200)]
        public string DiaChiKH
        {
            get { return fDiaChiKH; }
            set { SetPropertyValue<string>(nameof(DiaChiKH), ref fDiaChiKH, value); }
        }
        string fDienThoaiKH;
        [Size(10)]
        public string DienThoaiKH
        {
            get { return fDienThoaiKH; }
            set { SetPropertyValue<string>(nameof(DienThoaiKH), ref fDienThoaiKH, value); }
        }
        string fEmailKH;
        [Size(50)]
        public string EmailKH
        {
            get { return fEmailKH; }
            set { SetPropertyValue<string>(nameof(EmailKH), ref fEmailKH, value); }
        }
        string fGhiChu;
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"DATTIECReferencesKHACHHANG")]
        public XPCollection<DATTIEC> DATTIECs { get { return GetCollection<DATTIEC>(nameof(DATTIECs)); } }
    }

}