namespace UDP_serwer
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
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.wiadomosc = new System.Windows.Forms.ListBox();
            this.przycisk_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(23, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(239, 20);
            this.my_port.TabIndex = 0;
            // 
            // wiadomosc
            // 
            this.wiadomosc.FormattingEnabled = true;
            this.wiadomosc.Location = new System.Drawing.Point(23, 54);
            this.wiadomosc.Name = "wiadomosc";
            this.wiadomosc.Size = new System.Drawing.Size(239, 186);
            this.wiadomosc.TabIndex = 1;
            // 
            // przycisk_start
            // 
            this.przycisk_start.Location = new System.Drawing.Point(23, 257);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(239, 39);
            this.przycisk_start.TabIndex = 2;
            this.przycisk_start.Text = "Uruchom serwer";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.wiadomosc);
            this.Controls.Add(this.my_port);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox wiadomosc;
        private System.Windows.Forms.Button przycisk_start;
    }
}

