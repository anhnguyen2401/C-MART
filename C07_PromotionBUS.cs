using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cmart.BUS
{
    class C07_PromotionBUS
    {
        CMART1Entities1 db;

        Product product;

        public List<Promotion> loadPromotion()
        {
            db = new CMART1Entities1();
            return db.Promotions.ToList();
        }
        public List<Promotion> searchPromotion(string mp)
        {
            db = new CMART1Entities1();
            return db.Promotions.Where(st => st.IDPromotion.Contains(mp) || st.Contents.Contains(mp)).ToList();
        }
        public bool addPromotion(string a,int idProduct, float price, string image, DateTime start, DateTime end, string content)
        {
            db = new CMART1Entities1();
            Promotion promotion = new Promotion();
            promotion = new Promotion();
            Promotion promotion1 = db.Promotions.Single(st => st.IDPromotion.Equals(a));
            string idold = promotion1.IDPromotion;
            int changeID = int.Parse(idold.Substring(1, 6)) + 1;
            string idnew = "P";
            for (int i = changeID.ToString().Length; i < 6; i++)
            {
                idnew = idnew + "0";
            }
            idnew = idnew + changeID.ToString();

            try
            {
                promotion.IDPromotion = idnew;
                promotion.IDProduct = idProduct;
                promotion.Price = price;
                promotion.Image = image;
                promotion.Contents = content;
                promotion.StartDate = start;
                promotion.EndDate = end;
                db.Promotions.Add(promotion);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editPromotion(string idPromotion, int idProduct, string price, string image, DateTime start, DateTime end, string content)
        {

            db = new CMART1Entities1();
            try
            {
                Promotion promotion = db.Promotions.Single(st => st.IDPromotion.Equals(idPromotion));
                promotion.IDProduct = idProduct;
                promotion.Price = float.Parse(price);
                promotion.Image = image;
                promotion.Contents = content;
                promotion.StartDate = start;
                promotion.EndDate = end;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deletePromotion(string id, DataGridView list)
        {
            db = new CMART1Entities1();
            Promotion promotion;
            try
            {
                if (list.SelectedRows.Count == 1)
                {
                    var row = list.SelectedRows[0];
                    var cell = row.Cells["IDPromotion"];
                    string idd = (string)cell.Value;
                    promotion = db.Promotions.Single(st => st.IDPromotion == idd);
                    db.Promotions.Remove(promotion);
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
