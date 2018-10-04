using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toxy;

namespace sampleApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string path = Server.MapPath("~") + "\\AreaSearch.xlsx";
            //string path = Server.MapPath("~") + "App_Data\\";
            //string filename =  Session["FileName"].ToString();

            

            //string copyPath = path + r.Next().ToString() + ext;
            string path = Session["FileName"].ToString();
            //File.Copy(path + filename, path);

            ParserContext context = new ParserContext(path);
            ISpreadsheetParser parser = ParserFactory.CreateSpreadsheet(context);
            ToxySpreadsheet ss = parser.Parse();
            DataSet ds = ss.ToDataSet();

            if (ds.Tables.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }

            if (ds.Tables.Count > 1)
            {
                GridView2.DataSource = ds.Tables[1];
                GridView2.DataBind();
            }

            if (ds.Tables.Count > 2)
            {
                GridView3.DataSource = ds.Tables[2];
                GridView3.DataBind();
            }

            //using (var stream = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
            //{

            //}

            //if ((System.IO.File.Exists(path)))
            //{
            //    System.IO.File.Delete(path);
            //}
        }
    }
}