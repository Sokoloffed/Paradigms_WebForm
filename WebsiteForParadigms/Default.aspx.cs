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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Lab22_button_Click(object sender, EventArgs e)
        {
            localhost.LabService labService = new localhost.LabService();
            string array = Lab22_Textbox.Text;
            string[] splittedStr = array.Split(',');
            List<int> val = new List<int>();
            for(int i = 0; i < splittedStr.Length; i++)
            {
                val.Add(Convert.ToInt32(splittedStr[i]));
            }
            int[] val_arr = val.ToArray();
            int[] respond = labService.Lab1_22(val_arr);
            StringBuilder sb = new StringBuilder();
            foreach(int v in respond)
            {
                sb.Append(Convert.ToString(v));
            }
            Lab22_Label.Text = sb.ToString();


        }
    }
}