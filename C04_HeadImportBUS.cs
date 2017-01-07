using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmart.BUS
{
    class C04_HeadImportBUS
    {
        CMART1Entities1 db;
        string nameProduct;
        public List<HeadImport> loadListHeadImport()
        {
            db = new CMART1Entities1();
            return db.HeadImports.ToList();
        }
        public List<HeadImport> searchHeadImport(string mp)
        {
            db = new CMART1Entities1();
            return db.HeadImports.Where(st => st.IDHeadImport.Contains(mp) || st.IDAcc.Contains(mp) || st.IDrequestImport.Contains(mp)).ToList();
        }
        public bool deleteHeadImport(string id)
        {
            db = new CMART1Entities1();
            try
            {
                HeadImport headimport = db.HeadImports.Single(st => st.IDHeadImport.Equals(id));
                List<HeadImport_List> headlist = headimport.HeadImport_List.ToList();
                foreach (HeadImport_List a in headlist)
                {
                    db.HeadImport_List.Remove(a);
                }
                db.HeadImports.Remove(headimport);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool addProductList(int idPro)
        {
            db = new CMART1Entities1();
            try
            {
                Product pro = db.Products.Single(st => st.IDProduct.Equals(idPro));
                nameProduct = pro.Name;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool checkexistIDreandIDPro(string idRe , string idPro)
        {
            db = new CMART1Entities1();
            bool flag = false;
            try
            {
                int idPr = int.Parse(idPro);
                requestImport re = db.requestImports.Single(st=>st.IDRequestImport.Equals(idRe));
                List<requestImport_List> relist = re.requestImport_List.ToList();
                foreach (requestImport_List pro in relist)
                {
                    if (idPr==pro.IDProduct)
                    {
                        flag = true;
                        break;
                    }
                }
                return flag;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string getNamePro()
        {
            return nameProduct;
        }
        public bool addHeadList(string idHI, int[] idpro, int[] quantity, double[] price,DateTime[] date,string[] status)
        {
            db = new CMART1Entities1();
            try
            {
                for (int i = 0; i < idpro.Length; i++)
                {
                    HeadImport_List head = new HeadImport_List();
                    head.IDHeadImport = idHI;
                    head.IDProduct = idpro[i];
                    head.Quantity = quantity[i];
                    head.Status = status[i];
                    head.Price = price[i];
                    head.Expiration = date[i];
                    db.HeadImport_List.Add(head);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool addHeadImport(string idHI,string idRe,DateTime date,float Total,string IDAcc, int[] idpro, int[] quantity, double[] price, DateTime[] dateti, string[] status)
        {
            int t = int.Parse(idHI.Substring(8, 3)) + 1;
            string Month = date.Month.ToString();
            string Date = date.Day.ToString();
            if (Month.Length < 2)
            {
                Month = "0" + Month;
            }
            if (Date.Length < 2)
            {
                Date = "0" + Date;
            }
            string idnew = date.Year.ToString() + Month + Date;
            idnew = "HI"+idnew.Substring(2, 6);
            if (idnew == idHI.Substring(0, 8))
            {
                for (int i = t.ToString().Length; i < 3; i++)
                {
                    idnew = idnew + "0";
                }
                idnew = idnew + t;
            }
            else idnew = idnew + "001";
            HeadImport head = new HeadImport();
            try
            {
                head.IDrequestImport = idRe;
                head.IDHeadImport = idnew;
                head.IDAcc = IDAcc;
                head.HeadDate = date;
                head.TotalAmount = Total;
                db.HeadImports.Add(head);
                db.SaveChanges();
                addHeadList(idnew,idpro,quantity,price,dateti,status);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
     
        }
        public bool editHeadImport(string idHI, DateTime date, float Total, string IDAcc, int[] idpro, int[] quantity, double[] price, DateTime[] dateti, string[] status)
        {
            db = new CMART1Entities1();
            HeadImport head = db.HeadImports.Single(st=>st.IDHeadImport.Equals(idHI));
            List<HeadImport_List> headlist = head.HeadImport_List.ToList();
            try
            {
                head.IDAcc = IDAcc;
                head.TotalAmount = Total;
                db.SaveChanges();
                foreach (HeadImport_List he in headlist)
                {
                    db.HeadImport_List.Remove(he);
                    db.SaveChanges();
                }
                for (int i = 0; i < idpro.Length; i++)
                {
                    HeadImport_List headli = new HeadImport_List();
                    headli.IDHeadImport = idHI;
                    headli.IDProduct = idpro[i];
                    headli.Quantity = quantity[i];
                    headli.Status = status[i];
                    headli.Price = price[i];
                    headli.Expiration = dateti[i];
                    db.HeadImport_List.Add(headli);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
    
}
