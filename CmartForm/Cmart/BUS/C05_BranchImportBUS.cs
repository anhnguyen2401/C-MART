using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmart.BUS
{
    class C05_BranchImportBUS
    {
        CMART1Entities1 db;
        string nameProduct;
        public List<BranchImport> loadListBranchImport()
        {
            db = new CMART1Entities1();
            return db.BranchImports.ToList();
        }
        public List<BranchImport> searchBranchImport(string mp)
        {
            db = new CMART1Entities1();
            return db.BranchImports.Where(st => st.IDHeadImport.Contains(mp)||st.IDBranchImport.Contains(mp) || st.IDAcc.Contains(mp)).ToList();
        }
        public bool deleteBranchImport(string id)
        {
            db = new CMART1Entities1();
            try
            {
                BranchImport branchImport = db.BranchImports.Single(st => st.IDBranchImport.Equals(id));
                List<BranchImport_List> branchlist = branchImport.BranchImport_List.ToList();
                foreach (BranchImport_List a in branchlist)
                {
                    db.BranchImport_List.Remove(a);
                }
                db.BranchImports.Remove(branchImport);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool checkexistIDreandIDPro(string idHi, string idPro)
        {
            db = new CMART1Entities1();
            bool flag = false;
            try
            {
                int idPr = int.Parse(idPro);
                HeadImport re = db.HeadImports.Single(st => st.IDHeadImport.Equals(idHi));
                List<HeadImport_List> relist = re.HeadImport_List.ToList();
                foreach (HeadImport_List pro in relist)
                {
                    if (idPr == pro.IDProduct)
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
        public string getNamePro()
        {
            return nameProduct;
        }
        public bool addBranchList(string idBI, int[] idpro, int[] quantity, string[] status)
        {
            db = new CMART1Entities1();
            try
            {
                for (int i = 0; i < quantity.Length; i++)
                {
                    BranchImport_List branchList = new BranchImport_List();
                    branchList.IDBranchImport = idBI;
                    branchList.IDProduct = idpro[i];
                    branchList.Quantity = quantity[i];
                    branchList.Status = status[i];
                    db.BranchImport_List.Add(branchList);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool editBranchImport(string idBranch, DateTime date, int branch, string IDAcc, int[] idpro, int[] quantity, string[] status)
        {
            db = new CMART1Entities1();
            BranchImport branchImport = db.BranchImports.Single(st=>st.IDBranchImport.Equals(idBranch));
            List<BranchImport_List> branchList = branchImport.BranchImport_List.ToList();
            try
            {
                branchImport.BranchDate = date;
                branchImport.Branch = branch;
                branchImport.IDAcc = IDAcc;
                db.SaveChanges();
                foreach (BranchImport_List br in branchList)
                {
                    db.BranchImport_List.Remove(br);
                    db.SaveChanges();
                }
                addBranchList(idBranch, idpro, quantity, status);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool addBranchImport(string idHI, DateTime date, int branch, string IDAcc, int[] idpro, int[] quantity, string[] status)
        {
            db = new CMART1Entities1();
            BranchImport bran = null;
            List<BranchImport> lst = db.BranchImports.ToList();
            foreach (BranchImport b in lst)
            {
                bran = b;
            }
            if (bran != null)
            {
                int t = int.Parse(bran.IDBranchImport.Substring(8, 3)) + 1;
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
                idnew = "BI" + idnew.Substring(2, 6);
                if (idnew == bran.IDBranchImport.Substring(0, 8))
                {
                    for (int i = t.ToString().Length; i < 3; i++)
                    {
                        idnew = idnew + "0";
                    }
                    idnew = idnew + t;
                }
                else idnew = idnew + "001";
                BranchImport branchImport = new BranchImport();
                try
                {
                    branchImport.IDBranchImport = idnew;
                    branchImport.IDHeadImport = idHI;
                    branchImport.BranchDate = date;
                    branchImport.Branch = branch;
                    branchImport.IDAcc = IDAcc;
                    db.BranchImports.Add(branchImport);
                    db.SaveChanges();
                    addBranchList(idnew, idpro, quantity, status);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                BranchImport branchImport = new BranchImport();
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
                idnew = "BI" + idnew.Substring(2, 6)+"001";
                try
                {
                    branchImport.IDBranchImport = idnew;
                    branchImport.IDHeadImport = idHI;
                    branchImport.BranchDate = date;
                    branchImport.Branch = branch;
                    branchImport.IDAcc = IDAcc;
                    db.BranchImports.Add(branchImport);
                    db.SaveChanges();
                    addBranchList(idnew, idpro, quantity, status);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
