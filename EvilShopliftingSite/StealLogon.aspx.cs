using System;
using System.Web.UI;

namespace EvilShopliftingSite
{
  public partial class StealLogon : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      UsernameLabel.Text = Request.Form["Username"];
      PasswordLabel.Text = Request.Form["Password"];

      // Save the credentials somewhere so I can go shopping a little bit later.
    }
  }
}