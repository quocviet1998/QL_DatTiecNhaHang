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

    public partial class CT_PHATSINH : XPLiteObject
    {
        int fIdDT;
        [Key]
        public int IdDT
        {
            get { return fIdDT; }
            set { SetPropertyValue<int>(nameof(IdDT), ref fIdDT, value); }
        }
        DOUONG fIdDU;
        [Association(@"CT_PHATSINHReferencesDOUONG")]
        public DOUONG IdDU
        {
            get { return fIdDU; }
            set { SetPropertyValue<DOUONG>(nameof(IdDU), ref fIdDU, value); }
        }
        MONAN fIdMA;
        [Association(@"CT_PHATSINHReferencesMONAN")]
        public MONAN IdMA
        {
            get { return fIdMA; }
            set { SetPropertyValue<MONAN>(nameof(IdMA), ref fIdMA, value); }
        }
        DODUNG fIdDD;
        [Association(@"CT_PHATSINHReferencesDODUNG")]
        public DODUNG IdDD
        {
            get { return fIdDD; }
            set { SetPropertyValue<DODUNG>(nameof(IdDD), ref fIdDD, value); }
        }
        DICHVU fIdDV;
        [Association(@"CT_PHATSINHReferencesDICHVU")]
        public DICHVU IdDV
        {
            get { return fIdDV; }
            set { SetPropertyValue<DICHVU>(nameof(IdDV), ref fIdDV, value); }
        }
        int fSL_DU_PS;
        public int SL_DU_PS
        {
            get { return fSL_DU_PS; }
            set { SetPropertyValue<int>(nameof(SL_DU_PS), ref fSL_DU_PS, value); }
        }
        int fSL_MA_PS;
        public int SL_MA_PS
        {
            get { return fSL_MA_PS; }
            set { SetPropertyValue<int>(nameof(SL_MA_PS), ref fSL_MA_PS, value); }
        }
        int fSL_DD_PS;
        public int SL_DD_PS
        {
            get { return fSL_DD_PS; }
            set { SetPropertyValue<int>(nameof(SL_DD_PS), ref fSL_DD_PS, value); }
        }
        int fSL_DV_PS;
        public int SL_DV_PS
        {
            get { return fSL_DV_PS; }
            set { SetPropertyValue<int>(nameof(SL_DV_PS), ref fSL_DV_PS, value); }
        }
    }

}