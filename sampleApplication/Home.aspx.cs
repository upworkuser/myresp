using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sampleApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUploadClick(object sender, EventArgs e)
        {
            try
            {
                HttpPostedFile file = Request.Files["myFile"];
                if (!file.FileName.Contains("xls"))
                {
                    Response.Write("Invalid excel file");
                }
                else
                {
                    //check file was submitted
                    if (file != null && file.ContentLength > 0)
                    {
                        string fname = Path.GetFileName(file.FileName);
                        file.SaveAs(Server.MapPath(Path.Combine("~/App_Data/", fname)));
                        string path = Server.MapPath(Path.Combine("~/App_Data/", fname));
                        
                        

                        string ext = Path.GetExtension(path);
                        Random r = new Random();


                        string pathTemp = Server.MapPath(Path.Combine("~/App_Data/", r.Next().ToString() + ext));

                        File.Copy(path, pathTemp);
                        Session["FileName"] = pathTemp;
                        System.IO.File.Delete(path);

                        Response.Redirect("Default.aspx");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("Some Error happened or file size too large.");
            }
            
        }
    }
}