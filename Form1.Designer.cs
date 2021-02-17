namespace Blackjack
{
    partial class Form1
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
            this.BtDeal = new System.Windows.Forms.Button();
            this.TbS1 = new System.Windows.Forms.TextBox();
            this.TbV1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtDeal
            // 
            this.BtDeal.Location = new System.Drawing.Point(267, 241);
            this.BtDeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtDeal.Name = "BtDeal";
            this.BtDeal.Size = new System.Drawing.Size(110, 32);
            this.BtDeal.TabIndex = 0;
            this.BtDeal.Text = "Deal Now";
            this.BtDeal.UseVisualStyleBackColor = true;
            this.BtDeal.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbS1
            // 
            this.TbS1.Location = new System.Drawing.Point(283, 42);
            this.TbS1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbS1.Name = "TbS1";
            this.TbS1.Size = new System.Drawing.Size(76, 20);
            this.TbS1.TabIndex = 1;
            this.TbS1.TextChanged += new System.EventHandler(this.TbS1_TextChanged);
            // 
            // TbV1
            // 
            this.TbV1.Location = new System.Drawing.Point(410, 41);
            this.TbV1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbV1.Name = "TbV1";
            this.TbV1.Size = new System.Drawing.Size(76, 20);
            this.TbV1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 394);
            this.Controls.Add(this.TbV1);
            this.Controls.Add(this.TbS1);
            this.Controls.Add(this.BtDeal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtDeal;
        private System.Windows.Forms.TextBox TbS1;
        private System.Windows.Forms.TextBox TbV1;
    }
}

