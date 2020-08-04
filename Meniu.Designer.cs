namespace asistent_virtual
{
    partial class Meniu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer;
            this.muzicabtn = new System.Windows.Forms.Button();
            this.vremebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // muzicabtn
            // 
            this.muzicabtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.muzicabtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.muzicabtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(94)))));
            this.muzicabtn.FlatAppearance.BorderSize = 0;
            this.muzicabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muzicabtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muzicabtn.ForeColor = System.Drawing.Color.White;
            this.muzicabtn.Location = new System.Drawing.Point(63, 582);
            this.muzicabtn.Margin = new System.Windows.Forms.Padding(0);
            this.muzicabtn.Name = "muzicabtn";
            this.muzicabtn.Size = new System.Drawing.Size(108, 52);
            this.muzicabtn.TabIndex = 15;
            this.muzicabtn.Text = "Muzica";
            this.muzicabtn.UseVisualStyleBackColor = false;
            this.muzicabtn.Click += new System.EventHandler(this.muzicabtn_Click_1);
            // 
            // vremebtn
            // 
            this.vremebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vremebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vremebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(97)))), ((int)(((byte)(94)))));
            this.vremebtn.FlatAppearance.BorderSize = 0;
            this.vremebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vremebtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vremebtn.ForeColor = System.Drawing.Color.White;
            this.vremebtn.Location = new System.Drawing.Point(531, 582);
            this.vremebtn.Margin = new System.Windows.Forms.Padding(0);
            this.vremebtn.Name = "vremebtn";
            this.vremebtn.Size = new System.Drawing.Size(108, 52);
            this.vremebtn.TabIndex = 14;
            this.vremebtn.Text = "Vreme";
            this.vremebtn.UseVisualStyleBackColor = false;
            this.vremebtn.Click += new System.EventHandler(this.vremebtn_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.muzicabtn);
            this.Controls.Add(this.vremebtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Meniu";
            this.Size = new System.Drawing.Size(900, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button muzicabtn;
        private System.Windows.Forms.Button vremebtn;
        public System.Windows.Forms.Label label1;
    }
}
