using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoDeBarras.DAL;
namespace CodigoDeBarras.BLL
{
    public class CommonBLL
    {
        public string[] ObterTodasTabelas()
        {
            CommonDAL commonDAL = new CommonDAL();
            return commonDAL.ObterTodasTabelas();
        }
    }
}
