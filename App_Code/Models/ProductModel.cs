using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ProductModel
{
    public string InsertProduct(Product product)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            product.PRODUCT_ID = getPrimaryKey();
            db.Products.Add(product);
            db.SaveChanges();

            return product.PRODUCT_NAME + " was added";

        }catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateProduct(int id, Product product)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            Product p = db.Products.Find(id);
            p.PRODUCT_NAME = product.PRODUCT_NAME;
            p.PRODUCT_PRICE = product.PRODUCT_PRICE;
            p.PRODUCT_DESCRIPTION = product.PRODUCT_DESCRIPTION;
            p.PRODUCT_ID = product.PRODUCT_ID;
            p.PRODUCT_IMAGE = product.PRODUCT_IMAGE;

            db.SaveChanges();

            return product.PRODUCT_NAME + " was updated";


        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String DeleteProduct(int id)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            Product product = db.Products.Find(id);

            db.Products.Add(product);
            db.Products.Remove(product);
            db.SaveChanges();

            return product.PRODUCT_NAME + " was deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public List<Product> getProducts()
    {
        List<Product> products = new List<Product>();
        Coffee_ShopEntities db = new Coffee_ShopEntities();

        foreach (Product p in db.Products)
        {
            products.Add(p);
        }

        return products;
    }
    public int getPrimaryKey ()
    {
        return getProducts().Count;
    }
}
