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

    public partial class LOAITIEC : XPLiteObject
    {
        int fIdLT;
        [Key(true)]
        public int IdLT
        {
            get { return fIdLT; }
            set { SetPropertyValue<int>(nameof(IdLT), ref fIdLT, value); }
        }
        string fTenLT;
        [Size(200)]
        public string TenLT
        {
            get { return fTenLT; }
            set { SetPropertyValue<string>(nameof(TenLT), ref fTenLT, value); }
        }
        [Association(@"DATTIECReferencesLOAITIEC")]
        public XPCollection<DATTIEC> DATTIECs { get { return GetCollection<DATTIEC>(nameof(DATTIECs)); } }
    }

}