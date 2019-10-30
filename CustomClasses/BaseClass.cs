using AutoMapper;
using DevExpress.Xpo;
using QL_DatTiecNhaHang.CustomClasses.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DatTiecNhaHang.CustomClasses
{
    public class BaseClass//<T, U> where T: class where U: class
    {
        public Session session { get; set; }
        public BaseClass()
        {
            getSession();
        }
        
        public void getSession()
        {
            session = new Session();
            session.ConnectionString = System.Configuration.ConfigurationManager.
    ConnectionStrings["DESKTOP-TC830C5_QLDatTiecNhaHang"].ConnectionString;
        }

        //public T Map(U value)
        //{
        //    var config = new MapperConfiguration(cfg => {
        //        cfg.CreateMap<U, T>();
        //    });
        //    IMapper iMapper = config.CreateMapper();
        //    return iMapper.Map<U, T>(value);
        //}

        
    }
}
