using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cmart.BUS;
using System.Data;
using System.Windows.Forms;
namespace Cmart.BUS
{
    class C03_BillBUS
    {
        CMART1Entities1 db;
        string nameProduct;
        float priceProduct;
        public List<Bill> loadBillList()
        {
            db = new CMART1Entities1();
            return db.Bills.ToList();
        }
        public List<Bill> searchBill(string mp)
        {
            db = new CMART1Entities1();
            return db.Bills.Where(st => st.IDAcc.Contains(mp) || st.IDBill.Contains(mp) || st.POS.Equals(mp)).ToList();
        }
        //public bool deleteBill(string id)
        //{
        //    db = new CMART1Entities1();
        //    try
        //    {
        //        Bill bill = db.Bills.Single(st => st.IDBill.Equals(id));
        //        Bill_List bill_list;
        //        db.Bills.Remove(bill);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        public float countMoney(int id, int number)
        {
                db = new CMART1Entities1();
                List<PriceHistory> price1 = db.PriceHistories.Where(st => st.IDProduct == id).ToList();
                foreach (PriceHistory addPrice in price1)
                {
                    priceProduct = (float)addPrice.Price * number;
                }
                try
                {
                    Promotion addPromo = new Promotion();
                    List<Promotion> proList = db.Promotions.Where(st => st.IDProduct == id).ToList();
                    foreach (Promotion promo in proList)
                    {
                        addPromo = promo;
                    }
                    if (DateTime.Now <= addPromo.EndDate && DateTime.Now >= addPromo.StartDate)
                    {
                        priceProduct = (float)addPromo.Price * number;
                        return priceProduct;
                    }
                    else return priceProduct;
                }
                catch (Exception)
                {
                    return 0;
                }
            

        }
        public bool addBillList( string idBill,int[] idpro,string[] quantity,string[] unitprice)
        {

            db = new CMART1Entities1();
            try
            {
                //for (int i = 0; i < list.Rows.Count; i++)
                //{
                //    Bill_List billlist;
                //    billlist = new Bill_List();
                //    billlist.IDBill = idBill;
                //    billlist.IDProduct = i++;
                //    billlist.Quantity = list.Rows[i].Cells[2].Value.ToString();
                //    billlist.unitPrice = (float.Parse(list.Rows[i].Cells[3].Value.ToString()) / int.Parse(list.Rows[i].Cells[2].Value.ToString())).ToString();
                //    db.Bill_List.Add(billlist);
                //    db.SaveChanges();
                //}
                //for (int i = 0; i < idpro.Length; i++)
                //{
                //    billlist = new Bill_List();
                //    billlist.IDBill = idBill;
                //    billlist.IDProduct = idpro[i];
                //    billlist.Quantity = quantity[i];
                //    billlist.unitPrice = unitprice[i];
                //    db.Bill_List.Add(billlist);
                //    db.SaveChanges();
                //}
                for (int i = 0; i <= quantity.Length; i++)
                {
                    Bill_List billlist;
                    billlist = new Bill_List();
                    billlist.IDBill = idBill;
                    billlist.IDProduct =idpro[i];
                    billlist.Quantity = quantity[i];
                    billlist.unitPrice = unitprice[i];
                    db.Bill_List.Add(billlist);
                    db.SaveChanges();
                }
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
        public float getPriceProduct()
        {
            return priceProduct;
        }
        public string getnameProduct()
        {
            return nameProduct;
        }
        public bool editBill(string id ,DateTime date, string totalAmount, string Recieved, string returned, int totalQuantity, string POS, string IDAcc, int[] idpro, string[] quantity, string[] unitprice)
        {

            db = new CMART1Entities1();
            Bill bill = db.Bills.Single(st=>st.IDBill.Equals(id));
            List<Bill_List> bill_list = bill.Bill_List.ToList();
            foreach (Bill_List bi in bill_list)
            {
                db.Bill_List.Remove(bi);
                db.SaveChanges();
            } 
            try
            {
                bill.BillDate = date;
                bill.TotalAmount = totalAmount;
                bill.TotalQuantity = totalQuantity;
                bill.Recieved = Recieved;
                bill.Returned = returned;
                bill.POS = POS;
                bill.IDAcc = IDAcc;
                db.SaveChanges();
                addBillList(id, idpro, quantity, unitprice);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool addBill(string id, DateTime date,string totalAmount,string Recieved,string returned,int totalQuantity,string POS,string IDAcc,int[] idpro,string[] quantity,string[] unitprice)
        {
            db = new CMART1Entities1();
            Bill billl = null;
            List<Bill> lst = db.Bills.ToList();
            foreach (Bill bi in lst)
            {
                billl = bi;
            }
            if (billl != null)
            {
                int t = int.Parse(id.Substring(6, 6)) + 1;
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
                idnew = idnew.Substring(2, 6);
                if (idnew == id.Substring(0, 6))
                {
                    for (int i = t.ToString().Length; i < 6; i++)
                    {
                        idnew = idnew + "0";
                    }
                    idnew = idnew + t;
                }
                else idnew = idnew + "000001";
                Bill bill = new Bill();
                try
                {
                    bill.IDBill = idnew;
                    bill.BillDate = date;
                    bill.TotalAmount = totalAmount;
                    bill.TotalQuantity = totalQuantity;
                    bill.Recieved = Recieved;
                    bill.Returned = returned;
                    bill.POS = POS;
                    bill.IDAcc = IDAcc;
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    addBillList(idnew, idpro, quantity, unitprice);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                Bill bill = new Bill();
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
                idnew = idnew.Substring(2, 6);
                idnew = idnew + "000001";
                try
                {
                    bill.IDBill = idnew;
                    bill.BillDate = date;
                    bill.TotalAmount = totalAmount;
                    bill.TotalQuantity = totalQuantity;
                    bill.Recieved = Recieved;
                    bill.Returned = returned;
                    bill.POS = POS;
                    bill.IDAcc = IDAcc;
                    db.Bills.Add(bill);
                    db.SaveChanges();
                    addBillList(idnew, idpro, quantity, unitprice);
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
