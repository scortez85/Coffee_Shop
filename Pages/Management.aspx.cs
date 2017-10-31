using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
        //Label1.Text = Request.QueryString["id"].ToString();//String.IsNullOrWhiteSpace(Request.QueryString["id"])
    }

    private List<Product> getProducts()
    {
        try
        {
            using (Coffee_ShopEntities db = new Coffee_ShopEntities())
            {
                List<Product> products = (from x in db.Products select x).ToList();
                return products;
            }

        }
        catch (Exception) { return null; }

    }
    private List<Customer> getCustomers()
    {
        try
        {
            using (Coffee_ShopEntities db = new Coffee_ShopEntities())
            {
                List<Customer> customer = (from x in db.Customers select x).ToList();
                return customer;
            }

        }
        catch (Exception) { return null; }

    }
    private List<Cart> getCart()
    {
        try
        {
            using (Coffee_ShopEntities db = new Coffee_ShopEntities())
            {
                List<Cart> cart = (from x in db.Carts select x).ToList();
                return cart;
            }

        }
        catch (Exception) { return null; }

    }

    private void FillPage()
    {
        Coffee_ShopEntities db = new Coffee_ShopEntities();
        if (Request.QueryString["id"] == "1")
        {


            foreach (Product product in db.Products)
            {
                Label header1 = new Label() { Text = "Product Name" };
                Label header2 = new Label() { Text = "Product Description" };
                Label header3 = new Label() { Text = "Product Price" };
                header1.Style.Add("padding-right", "100px");
                header2.Style.Add("padding-right", "68px");
                header3.Style.Add("padding-right", "106px");
                header1.Style.Add("float", "left");
                header2.Style.Add("float", "left");
                header3.Style.Add("float", "left");

                Image iButton = new ImageButton();
                TextBox nameBox = new TextBox();
                TextBox priceBox = new TextBox();
                TextBox descriptionBox = new TextBox();
                Button deleteButton = new Button();
                Button saveButton = new Button();
                saveButton.Text = "Save";
                saveButton.Width = 75;
                deleteButton.Width = 75;

                iButton.Style.Add("float", "left");
                iButton.Style.Add("padding-right", "100px");
                iButton.ImageUrl = "~/Images/" + product.PRODUCT_IMAGE;
                iButton.Height = 100;
                nameBox.Text = product.PRODUCT_NAME;
                nameBox.Width = 300;
                priceBox.Width = 300;
                descriptionBox.Width = 300;
                descriptionBox.Style.Add("padding-right", "100px");
                priceBox.Text = product.PRODUCT_PRICE.ToString();
                priceBox.Style.Add("padding-right", "100px");
                descriptionBox.Text = product.PRODUCT_DESCRIPTION;
                deleteButton.Text = "Delete";

                PnlData.Controls.Add(iButton);
                PnlData.Controls.Add(header1);
                PnlData.Controls.Add(nameBox);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header2);
                PnlData.Controls.Add(descriptionBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(deleteButton);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header3);
                PnlData.Controls.Add(priceBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(saveButton);


                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });

            }

        }
        else if (Request.QueryString["id"] == "2")
        {
            foreach (Customer customer in db.Customers)
            {

                Label header1 = new Label() { Text = "First Name" };
                Label header2 = new Label() { Text = "Last Name" };
                Label header3 = new Label() { Text = "Address" };
                Label header4 = new Label() { Text = "Phone Number" };
                Label header5 = new Label() { Text = "Email" };
                Button deleteButton = new Button();
                Button saveButton = new Button();
                saveButton.Text = "Save";
                deleteButton.Text = "Delete";
                saveButton.Width = 75;
                deleteButton.Width = 75;

                header1.Style.Add("padding-right", "100px");
                header2.Style.Add("padding-right", "100px");
                header3.Style.Add("padding-right", "117px");
                header4.Style.Add("padding-right", "74px");
                header5.Style.Add("padding-right", "133px");

                TextBox fnameBox = new TextBox();
                TextBox lnameBox = new TextBox();
                TextBox addBox = new TextBox();
                TextBox phoneBox = new TextBox();
                TextBox emailBox = new TextBox();

                fnameBox.Width = 150;
                lnameBox.Width = 150;
                addBox.Width = 150;
                phoneBox.Width = 150;
                emailBox.Width = 150;


                fnameBox.Text = customer.CUSTOMER_FNAME;
                lnameBox.Text = customer.CUSTOMER_LNAME;
                addBox.Text = customer.CUSTOMER_ADDRESS;
                phoneBox.Text = customer.CUSTOMER_PHONE;
                emailBox.Text = customer.CUSTOMER_EMAIL;




                PnlData.Controls.Add(header1);
                PnlData.Controls.Add(fnameBox);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header2);
                PnlData.Controls.Add(lnameBox);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header3);
                PnlData.Controls.Add(addBox);

                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header4);
                PnlData.Controls.Add(phoneBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(deleteButton);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header5);
                PnlData.Controls.Add(emailBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(saveButton);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });


            }




        }
        else if (Request.QueryString["id"] == "3")
        {
            List<Customer> customer = new List<Customer>();
            foreach (Customer c in db.Customers)
                customer.Add(c);
            List<Cart> carts = new List<Cart>();
            foreach (Cart cart in db.Carts)
                carts.Add(cart);
            for (int k=0;k<carts.Count;k++)
            {
                
                Label header1 = new Label() { Text = "Customer" };
                Label header2 = new Label() { Text = "Order" };
                Label header3 = new Label() { Text = "Date" };
                Label header4 = new Label() { Text = "Time" };
                Label header5 = new Label() { Text = "Price" };

                header1.Style.Add("padding-right", "100px");
                header1.Height = 24;
                header2.Height = 24;
                header3.Height = 24;
                header4.Height = 24;
                header5.Height = 24;

                header2.Style.Add("padding-right", "125px");
                header3.Style.Add("padding-right", "131px");
                header4.Style.Add("padding-right", "130px");
                header5.Style.Add("padding-right", "128px");


                Label fName = new Label() { Text = customer[k].CUSTOMER_FNAME };
                fName.Style.Add("padding-right", "25px");
                Label lName = new Label() { Text = customer[k].CUSTOMER_LNAME };
                lName.Style.Add("padding-right", "25px");
                Label lAdd = new Label() { Text = customer[k].CUSTOMER_ADDRESS };
                lAdd.Style.Add("padding-right", "25px");
                Label lPhone = new Label() { Text = customer[k].CUSTOMER_PHONE };
                lPhone.Style.Add("padding-right", "25px");
                Label lEmail = new Label() { Text = customer[k].CUSTOMER_EMAIL };
                lEmail.Style.Add("padding-right", "25px");
                Button deleteButton = new Button();
                Button saveButton = new Button();
                saveButton.Text = "Save";
                deleteButton.Text = "Delete";
                saveButton.Width = 75;
                deleteButton.Width = 75;


                TextBox nameBox = new TextBox();
                TextBox priceBox = new TextBox();
                TextBox dateBox = new TextBox();
                TextBox timeBox = new TextBox();

                nameBox.Text = carts[k].PRODUCT_NAME;
                nameBox.Width = 300;
                priceBox.Text = carts[k].PRODUCT_PRICE;
                priceBox.Width = 300;
                dateBox.Text = carts[k].ORDER_DATE;
                dateBox.Width = 300;
                timeBox.Text = carts[k].ORDER_TIME;
                timeBox.Width = 300;

                PnlData.Controls.Add(header1);
                PnlData.Controls.Add(fName);
                PnlData.Controls.Add(lName);
                PnlData.Controls.Add(lAdd);
                PnlData.Controls.Add(lPhone);
                PnlData.Controls.Add(lEmail);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header2);
                PnlData.Controls.Add(nameBox);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header3);
                PnlData.Controls.Add(dateBox);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header4);
                PnlData.Controls.Add(timeBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(deleteButton);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(header5);
                PnlData.Controls.Add(priceBox);
                PnlData.Controls.Add(new Label() { Width = 50 });
                PnlData.Controls.Add(saveButton);
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
                PnlData.Controls.Add(new Literal { Text = "<br />" });
            }
        }


    }
}