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

    public partial class HOADON : XPLiteObject
    {
        int fIdHD;
        [Key]
        public int IdHD
        {
            get { return fIdHD; }
            set { SetPropertyValue<int>(nameof(IdHD), ref fIdHD, value); }
        }
        decimal fTongTien;
        public decimal TongTien
        {
            get { return fTongTien; }
            set { SetPropertyValue<decimal>(nameof(TongTien), ref fTongTien, value); }
        }
        decimal fDatCoc;
        public decimal DatCoc
        {
            get { return fDatCoc; }
            set { SetPropertyValue<decimal>(nameof(DatCoc), ref fDatCoc, value); }
        }
        DateTime fNgayDatCoc;
        public DateTime NgayDatCoc
        {
            get { return fNgayDatCoc; }
            set { SetPropertyValue<DateTime>(nameof(NgayDatCoc), ref fNgayDatCoc, value); }
        }
        DateTime fNgayThanhToan;
        public DateTime NgayThanhToan
        {
            get { return fNgayThanhToan; }
            set { SetPropertyValue<DateTime>(nameof(NgayThanhToan), ref fNgayThanhToan, value); }
        }
        DATTIEC fIdDT;
        [Indexed(Name = @"IDDT", Unique = true)]
        [Association(@"HOADONReferencesDATTIEC")]
        public DATTIEC IdDT
        {
            get { return fIdDT; }
            set { SetPropertyValue<DATTIEC>(nameof(IdDT), ref fIdDT, value); }
        }
    }

}
