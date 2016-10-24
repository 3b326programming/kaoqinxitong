using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

public partial class Core : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random rd = new Random();
        string strCode = "";
        for (int i = 0; i < 4; i++)
        {
            strCode += rd.Next(10).ToString();
        }
        Session["Code"] = strCode;
        Bitmap bmp = new Bitmap(80, 20);
        for (int i = 0; i <= 30; i++)
        {
            int x = rd.Next(80);
            int y = rd.Next(20);
            bmp.SetPixel(x, y, Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255)));
        }
        Graphics g = Graphics.FromImage(bmp);
        Font fnt = new Font("Times new Roman", 10, FontStyle.Bold);
        g.DrawString(strCode, fnt, Brushes.AliceBlue, 0, 0);
        for (int i = 0; i <= 4; i++)
        {
            int x1 = rd.Next(80);
            int y1 = rd.Next(20);
            int x2 = rd.Next(80);
            int y2 = rd.Next(20);
            g.DrawLine(new Pen(Color.FromArgb(rd.Next(255), rd.Next(255), rd.Next(255))), x1, y1, x2, y2);
        }
        bmp.Save(Response.OutputStream, ImageFormat.Gif);
    }
}