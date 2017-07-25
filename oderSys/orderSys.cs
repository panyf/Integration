using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversationAPI;

namespace oderSys
{

    public partial class orderPannel : Form
    {
        ConversationHelper helper = new ConversationHelper("a2bba1ef-9fa5-4002-a0c6-ffba34fd4983", "2c17fe46-d34b-4608-9f9b-03108554a9e8", "2W00upyXOUBb");
        int totalPrice = 0;
        int orderPrice = 0;
        bool loopBoolean = true;
        string input = "";
        string secondInput = "";

        public orderPannel()
        {
            InitializeComponent();
            lbl.Text = "Hi,how can I help you?";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            input = txtbox.Text;
            var res = helper.GetResponse(input).GetAwaiter().GetResult();
            string strtempa = "output\":{\"text\":[\"";
            string strtempb = "\"],\"nodes_visited";
            int IndexofA = res.IndexOf(strtempa);
            int IndexofB = res.IndexOf(strtempb);
            string Ru = res.Substring(IndexofA + 18, IndexofB - IndexofA - 18);
            lbl.Text = Ru;
        }
    }
}

