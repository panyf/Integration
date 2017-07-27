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
        System.Timers.Timer t = new System.Timers.Timer(2000);
        string input = "";

        public OrderPanel()
        {
            InitializeComponent();
            lbl.Text = "Auto Order System";
            txtarea.Text = "Robot: Hi,how can I help you?";
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

            

            if (txtarea.Text.Equals(""))
                txtarea.Text = "You: " + input + Environment.NewLine + "Robot: " + Ru;
            else
                txtarea.Text = txtarea.Text + Environment.NewLine + Environment.NewLine + "You: " + input + Environment.NewLine + "Robot: " + Ru;
            txtbox.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtarea.Text = "";
        }

        void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            txtarea.Text = txtarea.Text + "\n" + "aaa";
        }
    }
}

