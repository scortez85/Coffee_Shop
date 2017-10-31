using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_NewData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void subButton_Click(object sender, EventArgs e)
    {
        ProductModel model = new ProductModel();
        Product pt = createProduct();

        //lblResults.Text = model.InsertProduct(pt);

    }

    private Product createProduct()
    {
        Product p = new Product();
        p.PRODUCT_NAME = SearchBox.Text;

        return p;

    }
}