using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
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