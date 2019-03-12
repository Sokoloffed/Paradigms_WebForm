using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteForParadigms
{
    public partial class _Default : Page
    {
        localhost.LabService labService = new localhost.LabService();
        string array;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected int[] doPrepare()
        {
            //localhost.LabService labService = new localhost.LabService();
            array = Lab22_Textbox.Text;
            string[] splittedStr = array.Split(',');
            List<int> val = new List<int>();
            for (int i = 0; i < splittedStr.Length; i++)
            {
                val.Add(Convert.ToInt32(splittedStr[i]));
            }
            int[] val_arr = val.ToArray();
            return val_arr;

        }

        protected void doOutputArray(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int v in arr)
            {
                sb.Append(Convert.ToString(v) + ", ");
            }
            Lab22_Label.Text = sb.ToString();
        }

        protected void Lab22_button_Click(object sender, EventArgs e)
        {
            doOutputArray(labService.Lab1_22(doPrepare()));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            doOutputArray(labService.Lab1_51(doPrepare()));
        }

        protected void Lab24_button_Click(object sender, EventArgs e)
        {
            doOutputArray(labService.Lab2_4(doPrepare()));
        }
    }
}