using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Cmart.BUS
{
    class C06_PriceHistoryBUS
    {
        CMART1Entities1 db;
        public List<PriceHistory> loadListPriceHistory()
        {
            db = new CMART1Entities1();
            return db.PriceHistories.ToList();
        }
        public List<PriceHistory> searchListHistory(string mp)
        {
            db = new CMART1Entities1();
            int i;
            try
            {
                i = int.Parse(mp);
                return db.PriceHistories.Where(st => st.IDProduct.Equals(i)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        public bool addPriceHistory(string id,string price,DateTime date)
        {
            db = new CMART1Entities1();
            PriceHistory priceht = new PriceHistory();
            try
            {
                
                priceht.IDProduct = int.Parse(id);
                priceht.Price = float.Parse(price);
                priceht.Date = date;
                db.PriceHistories.Add(priceht);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editPriceHT(int id ,DateTime date,string price1,DateTime date1)
        {
            db = new CMART1Entities1();
            try
            {
                PriceHistory pricer = db.PriceHistories.Single(st => st.IDProduct.Equals(id) && st.Date.Equals(date));
                db.PriceHistories.Remove(pricer);
                PriceHistory priceht = new PriceHistory();
                float b = float.Parse(price1);
                priceht.IDProduct = id;
                priceht.Price =  b;
                priceht.Date = date1;
                db.PriceHistories.Add(priceht);
                db.SaveChanges();
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deletePriceHT(int id,DateTime date)
        {
            db = new CMART1Entities1();
            try
            {
                PriceHistory priceht = db.PriceHistories.Single(st => st.IDProduct.Equals(id)&&st.Date.Equals(date));
                db.PriceHistories.Remove(priceht);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
