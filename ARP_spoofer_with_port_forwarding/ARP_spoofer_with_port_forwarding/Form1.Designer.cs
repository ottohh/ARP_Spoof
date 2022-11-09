namespace ARP_spoofer_with_port_forwarding
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
            this.Received_and_forwarded = new System.Windows.Forms.ListBox();
            this.autoscroll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kuuntelu_laitteet = new System.Windows.Forms.ComboBox();
            this.ohjattava_ip_text = new System.Windows.Forms.TextBox();
            this.ohjattava_mac_text = new System.Windows.Forms.TextBox();
            this.kuunneltava_mac_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Received_and_forwarded
            // 
            this.Received_and_forwarded.FormattingEnabled = true;
            this.Received_and_forwarded.Location = new System.Drawing.Point(2, 9);
            this.Received_and_forwarded.Name = "Received_and_forwarded";
            this.Received_and_forwarded.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Received_and_forwarded.Size = new System.Drawing.Size(389, 537);
            this.Received_and_forwarded.TabIndex = 0;
            // 
            // autoscroll
            // 
            this.autoscroll.AutoSize = true;
            this.autoscroll.Location = new System.Drawing.Point(397, 541);
            this.autoscroll.Name = "autoscroll";
            this.autoscroll.Size = new System.Drawing.Size(72, 17);
            this.autoscroll.TabIndex = 1;
            this.autoscroll.Text = "Autoscroll";
            this.autoscroll.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kuuntelu_laitteet
            // 
            this.kuuntelu_laitteet.FormattingEnabled = true;
            this.kuuntelu_laitteet.Location = new System.Drawing.Point(413, 28);
            this.kuuntelu_laitteet.Name = "kuuntelu_laitteet";
            this.kuuntelu_laitteet.Size = new System.Drawing.Size(408, 21);
            this.kuuntelu_laitteet.TabIndex = 4;
            // 
            // ohjattava_ip_text
            // 
            this.ohjattava_ip_text.Location = new System.Drawing.Point(591, 275);
            this.ohjattava_ip_text.Name = "ohjattava_ip_text";
            this.ohjattava_ip_text.Size = new System.Drawing.Size(230, 20);
            this.ohjattava_ip_text.TabIndex = 5;
            // 
            // ohjattava_mac_text
            // 
            this.ohjattava_mac_text.Location = new System.Drawing.Point(591, 223);
            this.ohjattava_mac_text.Name = "ohjattava_mac_text";
            this.ohjattava_mac_text.Size = new System.Drawing.Size(230, 20);
            this.ohjattava_mac_text.TabIndex = 6;
            // 
            // kuunneltava_mac_text
            // 
            this.kuunneltava_mac_text.Location = new System.Drawing.Point(591, 328);
            this.kuunneltava_mac_text.Name = "kuunneltava_mac_text";
            this.kuunneltava_mac_text.Size = new System.Drawing.Size(230, 20);
            this.kuunneltava_mac_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ohjattava mac osoite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ohjattava ip osoite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "kuunneltata mac osoite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kuunneltava_mac_text);
            this.Controls.Add(this.ohjattava_mac_text);
            this.Controls.Add(this.ohjattava_ip_text);
            this.Controls.Add(this.kuuntelu_laitteet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoscroll);
            this.Controls.Add(this.Received_and_forwarded);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.ListBox Received_and_forwarded;
        private System.Windows.Forms.CheckBox autoscroll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox kuuntelu_laitteet;
        private System.Windows.Forms.TextBox ohjattava_ip_text;
        private System.Windows.Forms.TextBox ohjattava_mac_text;
        private System.Windows.Forms.TextBox kuunneltava_mac_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

