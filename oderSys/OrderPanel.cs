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
        //new a COnversationHelper class to post value to the Watson and get the return value,
        //pass on the workID, userID, password
        ConversationHelper helper = new ConversationHelper("a2bba1ef-9fa5-4002-a0c6-ffba34fd4983", "2c17fe46-d34b-4608-9f9b-03108554a9e8", "2W00upyXOUBb");
        string input = "";

        /// <summary>
        /// OrderPanel class constructor
        /// initialize the components on the form
        /// initialize the text of the label named lbl on the top
        /// initialize the text of the textbox named textarea in the middle
        /// </summary>
        public OrderPanel()
        {
            InitializeComponent();
            lbl.Text = "Auto Order System";
            txtarea.Text = "Robot: Hi,how can I help you?";
        }

        /// <summary>
        /// send button click event
        /// this event will get the value of the GetResponse method of ConversationHelper class
        /// get the substring of the return value and give the value to the string "Ru"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            input = txtbox.Text;
            var res = Task.Run(() => helper.GetResponse(input).GetAwaiter().GetResult()).Result;  //run the statement after the task finish
            string strtempa = "output\":{\"text\":[\"";
            string strtempb = "\"],\"nodes_visited";
            int IndexofA = res.IndexOf(strtempa);
            int IndexofB = res.IndexOf(strtempb);
            string Ru = res.Substring(IndexofA + 18, IndexofB - IndexofA - 18); // get the value of part of the json format result
            //use the textbox named txtarea to record the message
            if (txtarea.Text.Equals(""))
                txtarea.Text = "You: " + input + Environment.NewLine + "Robot: " + Ru;
            else
                txtarea.Text = txtarea.Text + Environment.NewLine + Environment.NewLine + "You: " + input + Environment.NewLine + "Robot: " + Ru;
            txtbox.Text = "";

        }

        /// <summary>
        /// clear button click event
        /// clear the txtarea compoment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtarea.Text = "";
        }
    }
}

