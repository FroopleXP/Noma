namespace noma
{
    partial class noma_main_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.noma_com_port = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.noma_serial_port = new System.IO.Ports.SerialPort(this.components);
            this.noma_mouse_x = new System.Windows.Forms.TextBox();
            this.noma_mouse_y = new System.Windows.Forms.TextBox();
            this.noma_com_connect = new System.Windows.Forms.Button();
            this.noma_com_baud = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select COM Port";
            // 
            // noma_com_port
            // 
            this.noma_com_port.FormattingEnabled = true;
            this.noma_com_port.Location = new System.Drawing.Point(16, 29);
            this.noma_com_port.Name = "noma_com_port";
            this.noma_com_port.Size = new System.Drawing.Size(121, 21);
            this.noma_com_port.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Move mouse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noma_mouse_x
            // 
            this.noma_mouse_x.Location = new System.Drawing.Point(16, 130);
            this.noma_mouse_x.Name = "noma_mouse_x";
            this.noma_mouse_x.Size = new System.Drawing.Size(38, 20);
            this.noma_mouse_x.TabIndex = 4;
            this.noma_mouse_x.Text = "X";
            // 
            // noma_mouse_y
            // 
            this.noma_mouse_y.Location = new System.Drawing.Point(99, 130);
            this.noma_mouse_y.Name = "noma_mouse_y";
            this.noma_mouse_y.Size = new System.Drawing.Size(38, 20);
            this.noma_mouse_y.TabIndex = 5;
            this.noma_mouse_y.Text = "Y";
            // 
            // noma_com_connect
            // 
            this.noma_com_connect.Location = new System.Drawing.Point(16, 56);
            this.noma_com_connect.Name = "noma_com_connect";
            this.noma_com_connect.Size = new System.Drawing.Size(121, 23);
            this.noma_com_connect.TabIndex = 6;
            this.noma_com_connect.Text = "Connect";
            this.noma_com_connect.UseVisualStyleBackColor = true;
            this.noma_com_connect.Click += new System.EventHandler(this.noma_com_connect_Click);
            // 
            // noma_com_baud
            // 
            this.noma_com_baud.FormattingEnabled = true;
            this.noma_com_baud.Location = new System.Drawing.Point(143, 29);
            this.noma_com_baud.Name = "noma_com_baud";
            this.noma_com_baud.Size = new System.Drawing.Size(121, 21);
            this.noma_com_baud.TabIndex = 7;
            // 
            // noma_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 367);
            this.Controls.Add(this.noma_com_baud);
            this.Controls.Add(this.noma_com_connect);
            this.Controls.Add(this.noma_mouse_y);
            this.Controls.Add(this.noma_mouse_x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noma_com_port);
            this.Controls.Add(this.label1);
            this.Name = "noma_main_form";
            this.Text = "Noma - Natural Gesture Computer Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox noma_com_port;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort noma_serial_port;
        private System.Windows.Forms.TextBox noma_mouse_x;
        private System.Windows.Forms.TextBox noma_mouse_y;
        private System.Windows.Forms.Button noma_com_connect;
        private System.Windows.Forms.ComboBox noma_com_baud;
    }
}

