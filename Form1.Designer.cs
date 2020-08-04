namespace asistent_virtual
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            this.meniu1 = new asistent_virtual.Meniu();
            this.userControl11 = new asistent_virtual.UserControl1();
            this.vremeUC1 = new asistent_virtual.VremeUC();
            timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            // 
            // meniu1
            // 
            this.meniu1.alegere = null;
            this.meniu1.alegere2 = null;
            this.meniu1.BackColor = System.Drawing.Color.Teal;
            this.meniu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meniu1.Location = new System.Drawing.Point(0, 0);
            this.meniu1.Margin = new System.Windows.Forms.Padding(0);
            this.meniu1.Name = "meniu1";
            this.meniu1.Size = new System.Drawing.Size(886, 661);
            this.meniu1.TabIndex = 3;
            // 
            // userControl11
            // 
            this.userControl11.alegere = null;
            this.userControl11.alegere2 = null;
            this.userControl11.AutoSize = true;
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.BackColor = System.Drawing.Color.Teal;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(886, 661);
            this.userControl11.TabIndex = 2;
            // 
            // vremeUC1
            // 
            this.vremeUC1.alegere = null;
            this.vremeUC1.alegere2 = null;
            this.vremeUC1.AutoSize = true;
            this.vremeUC1.BackColor = System.Drawing.Color.Teal;
            this.vremeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vremeUC1.Location = new System.Drawing.Point(0, 0);
            this.vremeUC1.Margin = new System.Windows.Forms.Padding(0);
            this.vremeUC1.Name = "vremeUC1";
            this.vremeUC1.Size = new System.Drawing.Size(886, 661);
            this.vremeUC1.TabIndex = 1;
            this.vremeUC1.Load += new System.EventHandler(this.vremeUC1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(886, 661);
            this.Controls.Add(this.meniu1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.vremeUC1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistent Virtual";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private VremeUC vremeUC1;
        private UserControl1 userControl11;
        private Meniu meniu1;
        #endregion

        //private Meniu meniu1;


        // private VremeUC vremeUC1;



    }
}

