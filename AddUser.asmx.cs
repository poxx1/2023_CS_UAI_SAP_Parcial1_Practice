using System.Web.Services;

namespace UAI_SAP_ParcialPractice
{
    /// <summary>
    /// Summary description for AddUser
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddUser : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public bool newUser(string Name, string Surename, int Age)
        {
            User usuario = new User();
            usuario.Name = Name;
            usuario.Surename = Surename;
            usuario.Age = Age;

            return true;
        }
    }
}