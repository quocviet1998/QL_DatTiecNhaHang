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

    public partial class CT_DT_MA : XPLiteObject
    {
        int fSoLuongMA;
        public int SoLuongMA
        {
            get { return fSoLuongMA; }
            set { SetPropertyValue<int>(nameof(SoLuongMA), ref fSoLuongMA, value); }
        }
        int fSoLuongMA_PS;
        public int SoLuongMA_PS
        {
            get { return fSoLuongMA_PS; }
            set { SetPropertyValue<int>(nameof(SoLuongMA_PS), ref fSoLuongMA_PS, value); }
        }
        public struct CompoundKey1Struct
        {
            [Persistent("IdMA")]
            public int IdMA { get; set; }
            [Persistent("IdDT")]
            public int IdDT { get; set; }
        }
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}