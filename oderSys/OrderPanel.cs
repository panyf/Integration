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
        public orderAI orderAIForm;

        /// <summary>
        /// OrderPanel class constructor
        /// initialize the components on the form
        /// initialize the text of the label named lbl on the top
        /// initialize the text of the textbox named textarea in the middle
        /// </summary>
        public OrderPanel()
        {
            InitializeComponent();
            orderAIForm = new orderAI();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            orderAIForm.Show();
            groupBox.Controls.Clear();
            groupBox.Controls.Add(orderAIForm);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}

