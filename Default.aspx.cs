using System;
using System.Web.UI;

namespace UAI_SAP_ParcialPractice
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "")
            {
                if (addUser.newUser(TextBox1.Text, TextBox2.Text, Int32.Parse(TextBox3.Text))) ;
                {
                    lbl_info.Text = "El usuario fue registrado exitosamente.";
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
            }
            else
                lbl_info.Text = "Error. Revise por favor los datos ingresados.";

        }
    }
}