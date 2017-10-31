using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Products : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            FillPage();

        }
        catch { FillPageAll(); }
    }

    private void FillPage()
    {
        Label1.Height = 30;
        Product p = getProduct(int.Parse(Request.QueryString["id"]));

        ImageButton iButton = new ImageButton() { ImageUrl = "~/Images/" + p.PRODUCT_IMAGE };
        iButton.PostBackUrl = "~/Pages/Products.aspx?id=" + p.PRODUCT_ID;
        Label lbName = new Label() { Text = "<br />" + p.PRODUCT_NAME };
        Label lbDescription = new Label() { Text = p.PRODUCT_DESCRIPTION };
        Label lbPrice = new Label() { Text = "$ " + p.PRODUCT_PRICE };
        Button cart = new Button() { Text = "Add to Cart" };
        lbPrice.Style.Add("padding-right", "30px");
        PnlData.Style.Add("float", "left");
        PnlData.Style.Add("padding-right", "200px");

        iButton.Style.Add("float", "left");
        lbName.Style.Add("float", "left");
        lbPrice.Style.Add("float", "left");

        lbPrice.Style.Add("padding-left", "0px");
        lbPrice.Style.Add("font-size", "25px");
        lbPrice.Style.Add("color", "#ff6a00");
        iButton.Height = 200;

        PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(iButton);
        //PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(lbName);
        PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(lbDescription);
        PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(new Literal { Text = "<br />" });
        PnlData.Controls.Add(lbPrice);
        PnlData.Controls.Add(cart);


    }

    private Product getProduct (int id)
    {
        Coffee_ShopEntities db = new Coffee_ShopEntities();

        Product p = db.Products.Find(id);
        return p;
    }
    private void FillPageAll()
    {
        List<Product> products = getProducts();

        foreach (Product p in products)
        {
            Panel pnLProduct = new Panel();
            ImageButton iButton = new ImageButton() { ImageUrl = "~/Images/" + p.PRODUCT_IMAGE };
            iButton.PostBackUrl = "~/Pages/Products.aspx?id=" + p.PRODUCT_ID;
            Label lbName = new Label() { Text = p.PRODUCT_NAME };
            Label lbPrice = new Label() { Text = "$ " + p.PRODUCT_PRICE };
            pnLProduct.Style.Add("float", "left");
            pnLProduct.Style.Add("padding-right", "200px");

            lbPrice.Style.Add("padding-left", "70px");
            lbPrice.Style.Add("font-size", "25px");
            lbPrice.Style.Add("color", "#ff6a00");
            iButton.Height = 200;

            pnLProduct.Controls.Add(iButton);
            pnLProduct.Controls.Add(new Literal { Text = "<br />" });
            pnLProduct.Controls.Add(lbName);
            pnLProduct.Controls.Add(new Literal { Text = "<br />" });
            pnLProduct.Controls.Add(new Literal { Text = "<br />" });
            pnLProduct.Controls.Add(lbPrice);

            PnlData.Controls.Add(pnLProduct);


        }
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
}