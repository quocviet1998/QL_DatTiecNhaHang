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

    public partial class DATTIEC : XPLiteObject
    {
        int fIdDT;
        [Key(true)]
        public int IdDT
        {
            get { return fIdDT; }
            set { SetPropertyValue<int>(nameof(IdDT), ref fIdDT, value); }
        }
        KHACHHANG fIdKH;
        [Association(@"DATTIECReferencesKHACHHANG")]
        public KHACHHANG IdKH
        {
            get { return fIdKH; }
            set { SetPropertyValue<KHACHHANG>(nameof(IdKH), ref fIdKH, value); }
        }
        LOAITIEC fIdLT;
        [Association(@"DATTIECReferencesLOAITIEC")]
        public LOAITIEC IdLT
        {
            get { return fIdLT; }
            set { SetPropertyValue<LOAITIEC>(nameof(IdLT), ref fIdLT, value); }
        }
        COMBO_MONAN fIdCBMA;
        [Association(@"DATTIECReferencesCOMBO_MONAN")]
        public COMBO_MONAN IdCBMA
        {
            get { return fIdCBMA; }
            set { SetPropertyValue<COMBO_MONAN>(nameof(IdCBMA), ref fIdCBMA, value); }
        }
        DateTime fNgayDT;
        public DateTime NgayDT
        {
            get { return fNgayDT; }
            set { SetPropertyValue<DateTime>(nameof(NgayDT), ref fNgayDT, value); }
        }
        string fTenChuRe;
        public string TenChuRe
        {
            get { return fTenChuRe; }
            set { SetPropertyValue<string>(nameof(TenChuRe), ref fTenChuRe, value); }
        }
        string fTenCoDau;
        public string TenCoDau
        {
            get { return fTenCoDau; }
            set { SetPropertyValue<string>(nameof(TenCoDau), ref fTenCoDau, value); }
        }
        int fSLKhach;
        public int SLKhach
        {
            get { return fSLKhach; }
            set { SetPropertyValue<int>(nameof(SLKhach), ref fSLKhach, value); }
        }
        int fSLNhanVien;
        public int SLNhanVien
        {
            get { return fSLNhanVien; }
            set { SetPropertyValue<int>(nameof(SLNhanVien), ref fSLNhanVien, value); }
        }
        DateTime fThoiGianBD;
        public DateTime ThoiGianBD
        {
            get { return fThoiGianBD; }
            set { SetPropertyValue<DateTime>(nameof(ThoiGianBD), ref fThoiGianBD, value); }
        }
        string fGhiChu;
        [Size(SizeAttribute.Unlimited)]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>(nameof(GhiChu), ref fGhiChu, value); }
        }
        [Association(@"HOADONReferencesDATTIEC")]
        public XPCollection<HOADON> HOADONs { get { return GetCollection<HOADON>(nameof(HOADONs)); } }
    }

}
