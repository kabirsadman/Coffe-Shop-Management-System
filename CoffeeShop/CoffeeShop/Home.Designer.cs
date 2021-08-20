namespace CoffeeShop
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.butOwner = new System.Windows.Forms.Button();
            this.butEmp = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Coffee Express";
            // 
            // butOwner
            // 
            this.butOwner.BackColor = System.Drawing.Color.White;
            this.butOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOwner.ForeColor = System.Drawing.Color.Black;
            this.butOwner.Location = new System.Drawing.Point(109, 240);
            this.butOwner.Margin = new System.Windows.Forms.Padding(2);
            this.butOwner.Name = "butOwner";
            this.butOwner.Size = new System.Drawing.Size(87, 37);
            this.butOwner.TabIndex = 1;
            this.butOwner.Text = "Owner";
            this.butOwner.UseMnemonic = false;
            this.butOwner.UseVisualStyleBackColor = false;
            this.butOwner.Click += new System.EventHandler(this.butOwner_Click);
            // 
            // butEmp
            // 
            this.butEmp.BackColor = System.Drawing.Color.White;
            this.butEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmp.ForeColor = System.Drawing.Color.Black;
            this.butEmp.Location = new System.Drawing.Point(256, 240);
            this.butEmp.Margin = new System.Windows.Forms.Padding(2);
            this.butEmp.Name = "butEmp";
            this.butEmp.Size = new System.Drawing.Size(95, 37);
            this.butEmp.TabIndex = 1;
            this.butEmp.Text = "Employee";
            this.butEmp.UseVisualStyleBackColor = false;
            this.butEmp.Click += new System.EventHandler(this.butEmp_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.White;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(536, 360);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(56, 29);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login With:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(151, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Owner Registration";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.homepage_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.butEmp);
            this.Controls.Add(this.butOwner);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOwner;
        private System.Windows.Forms.Button butEmp;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}