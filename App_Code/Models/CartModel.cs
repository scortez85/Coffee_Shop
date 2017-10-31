using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            db.Carts.Add(cart);
            db.SaveChanges();

            return cart.PRODUCT_NAME + " was added";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateProduct(int id, Cart cart)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            Cart c = db.Carts.Find(id);
            c.ORDER_DATE = cart.ORDER_DATE;
            c.ORDER_NUMBER = cart.ORDER_NUMBER;
            c.ORDER_TIME = cart.ORDER_TIME;
            c.PRODUCT_NAME = cart.PRODUCT_NAME;
            c.PRODUCT_PRICE = cart.PRODUCT_PRICE;

            db.SaveChanges();

            return cart.PRODUCT_NAME + " was updated";


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
            Cart cart = db.Carts.Find(id);

            db.Carts.Add(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.PRODUCT_NAME + " was deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public List<Cart> getCart()
    {
        List<Cart> cart = new List<Cart>();
        Coffee_ShopEntities db = new Coffee_ShopEntities();

        foreach (Cart c in db.Carts)
        {
            cart.Add(c);
        }

        return cart;
    }
    public int getPrimaryKey()
    {
        return getCart().Count;
    }
}
