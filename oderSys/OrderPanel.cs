using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace  ConversationAPI

{

    public partial class OrderPanel : Form
    {
        ConversationHelper helper = new ConversationHelper("a2bba1ef-9fa5-4002-a0c6-ffba34fd4983", "2c17fe46-d34b-4608-9f9b-03108554a9e8", "2W00upyXOUBb");
        int totalPrice = 0;
        int orderPrice = 0;
        
        string input = "";
        string secondInput = "";

        public OrderPanel()
        {
            InitializeComponent();
            lbl.Text = "Hi,how can I help you?";
            txtarea.Text = "Hi,how can I help you?";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            input = txtbox.Text;
            var res = Task.Run(() => helper.GetResponse(input).GetAwaiter().GetResult()).Result;  
            string strtempa = "output\":{\"text\":[\"";
            string strtempb = "\"],\"nodes_visited";
            int IndexofA = res.IndexOf(strtempa);
            int IndexofB = res.IndexOf(strtempb);
            string Ru = res.Substring(IndexofA + 18, IndexofB - IndexofA - 18);
            lbl.Text = Ru;
            txtarea.Text = txtarea.Text + Environment.NewLine + Environment.NewLine + input + Environment.NewLine + Ru;
            txtbox.Text = "";
        }
    }
}

