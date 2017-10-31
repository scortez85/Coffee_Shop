using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CustomerModel
{
    public string InsertCustomer(Customer customer)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            customer.CUSTOMER_ID = getPrimaryKey();
            db.Customers.Add(customer);
            db.SaveChanges();

            return customer.CUSTOMER_FNAME +" " + customer.CUSTOMER_LNAME + " was added";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public String UpdateProduct(int id, Customer customer)
    {
        try
        {
            Coffee_ShopEntities db = new Coffee_ShopEntities();
            Customer c = db.Customers.Find(id);
            c.CUSTOMER_ADDRESS = customer.CUSTOMER_ADDRESS;
            c.CUSTOMER_EMAIL = customer.CUSTOMER_EMAIL;
            c.CUSTOMER_FNAME = customer.CUSTOMER_FNAME;
            c.CUSTOMER_ID = customer.CUSTOMER_ID;
            c.CUSTOMER_LNAME = customer.CUSTOMER_LNAME;
            c.CUSTOMER_PHONE = customer.CUSTOMER_PHONE;

            db.SaveChanges();

            return customer.CUSTOMER_FNAME + " " + customer.CUSTOMER_LNAME + " was updated";


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
            Customer customer = db.Customers.Find(id);

            db.Customers.Add(customer);
            db.Customers.Remove(customer);
            db.SaveChanges();

            return customer.CUSTOMER_FNAME + " " + customer.CUSTOMER_LNAME + " was deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    public List<Customer> getCustomers()
    {
        List<Customer> customers = new List<Customer>();
        Coffee_ShopEntities db = new Coffee_ShopEntities();

        foreach (Customer c in db.Customers)
        {
            customers.Add(c);
        }

        return customers;
    }
    public int getPrimaryKey()
    {
        return getCustomers().Count;
    }
}
