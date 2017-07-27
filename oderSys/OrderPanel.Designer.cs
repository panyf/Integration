namespace ConversationAPI
{
    partial class OrderPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(372, 85);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "send";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "label1";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(12, 87);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(329, 20);
            this.txtbox.TabIndex = 2;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(12, 141);
            this.txtarea.Multiline = true;
            this.txtarea.Name = "txtarea";
            this.txtarea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtarea.Size = new System.Drawing.Size(435, 277);
            this.txtarea.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(372, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OrderPanel
            // 
            this.AcceptButton = this.btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 489);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.Name = "OrderPanel";
            this.Text = "orderPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Button btnClear;
    }
}

