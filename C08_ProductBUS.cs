using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmart.BUS
{
    class C08_ProductBUS
    {
        CMART1Entities1 db;
        public List<Product> loadListProduct()
        {
            db = new CMART1Entities1();
            return db.Products.ToList();
        }
        public List<Product> searchProductList(string mp)
        {
            db = new CMART1Entities1();
            return db.Products.Where(st=>st.Name.Contains(mp)|| st.Image.Contains(mp) || st.IDSupplier.Contains(mp) || st.IDType.Contains(mp) ).ToList();
        }
        public List<ProductType> loadProducTypetList()
        {
            db = new CMART1Entities1();
            return db.ProductTypes.ToList();
        }
        public List<Supplier> loadSuppliertList()
        {
            db = new CMART1Entities1();
            return db.Suppliers.ToList();
        }
        public bool checkExistedProduct(string stm)
        {
            db = new CMART1Entities1();
            Product product = db.Products.FirstOrDefault(st=>st.Name.Equals(stm));
            if (product==null)
            {
                return true;
            }
            return false;
        }
        public bool addProduct(int id,string Name, string image,string IDSupplier,string IDType)
        {
            db = new CMART1Entities1();
            Product pro = db.Products.Single(st=>st.IDProduct.Equals(id));
            int a = pro.IDProduct;
            Product product = new Product();
            ProductType type = db.ProductTypes.Single(st=>st.IDType.Equals(IDType));
            try
            {
                        product.IDProduct = a + 1;
                        product.Name = Name;
                        product.Image = image;
                        product.IDSupplier = IDSupplier;
                        product.IDType = IDType;
                        type.Quantity = type.Quantity+ 1;
                        db.Products.Add(product);
                        db.SaveChanges();
                return true;               
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editProduct(int id,string Name, string image, string IDSupplier, string IDType)
        {
            db = new CMART1Entities1();
            try
            {
                Product product = db.Products.Single(st => st.IDProduct.Equals(id));
                if (IDType!=product.IDType)
                {
                        ProductType type1 = db.ProductTypes.Single(st => st.IDType.Equals(IDType));
                        ProductType type2 = db.ProductTypes.Single(st => st.IDType.Equals(product.IDType));
                        product.Image = image;
                        product.Name = Name;
                        product.IDSupplier = IDSupplier;
                        product.IDType = IDType;
                        type2.Quantity = type2.Quantity - 1;
                        type1.Quantity = type1.Quantity + 1;
                        db.SaveChanges();
                }

                else {
                    product.Name = Name;
                    product.Image = image;
                    product.IDSupplier = IDSupplier;
                    db.SaveChanges();
                     }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteProduct(int id)
        {
            try
            {
                db = new CMART1Entities1();
                Product product = db.Products.Single(st => st.IDProduct.Equals(id));
                ProductType type = db.ProductTypes.Single(st => st.IDType.Equals(product.IDType));
                db.Products.Remove(product);
                type.Quantity = type.Quantity - 1;
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
