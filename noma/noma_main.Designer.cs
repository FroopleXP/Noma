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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(noma_main_form));
            this.label1 = new System.Windows.Forms.Label();
            this.noma_com_port = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.noma_serial_port = new System.IO.Ports.SerialPort(this.components);
            this.noma_mouse_x = new System.Windows.Forms.TextBox();
            this.noma_mouse_y = new System.Windows.Forms.TextBox();
            this.noma_com_connect = new System.Windows.Forms.Button();
            this.noma_com_baud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select COM Port";
            // 
            // noma_com_port
            // 
            this.noma_com_port.FormattingEnabled = true;
            this.noma_com_port.Location = new System.Drawing.Point(13, 41);
            this.noma_com_port.Name = "noma_com_port";
            this.noma_com_port.Size = new System.Drawing.Size(204, 21);
            this.noma_com_port.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Move mouse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // noma_mouse_x
            // 
            this.noma_mouse_x.Location = new System.Drawing.Point(13, 39);
            this.noma_mouse_x.Name = "noma_mouse_x";
            this.noma_mouse_x.Size = new System.Drawing.Size(204, 20);
            this.noma_mouse_x.TabIndex = 4;
            this.noma_mouse_x.Text = "X";
            // 
            // noma_mouse_y
            // 
            this.noma_mouse_y.Location = new System.Drawing.Point(13, 84);
            this.noma_mouse_y.Name = "noma_mouse_y";
            this.noma_mouse_y.Size = new System.Drawing.Size(204, 20);
            this.noma_mouse_y.TabIndex = 5;
            this.noma_mouse_y.Text = "Y";
            // 
            // noma_com_connect
            // 
            this.noma_com_connect.Location = new System.Drawing.Point(13, 127);
            this.noma_com_connect.Name = "noma_com_connect";
            this.noma_com_connect.Size = new System.Drawing.Size(204, 23);
            this.noma_com_connect.TabIndex = 6;
            this.noma_com_connect.Text = "Connect";
            this.noma_com_connect.UseVisualStyleBackColor = true;
            this.noma_com_connect.Click += new System.EventHandler(this.noma_com_connect_Click);
            // 
            // noma_com_baud
            // 
            this.noma_com_baud.FormattingEnabled = true;
            this.noma_com_baud.Location = new System.Drawing.Point(13, 85);
            this.noma_com_baud.Name = "noma_com_baud";
            this.noma_com_baud.Size = new System.Drawing.Size(204, 21);
            this.noma_com_baud.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noma_com_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.noma_com_baud);
            this.groupBox1.Controls.Add(this.noma_com_port);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(230, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.noma_mouse_x);
            this.groupBox2.Controls.Add(this.noma_mouse_y);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(230, 164);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse Control";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y Position";
            // 
            // noma_main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(258, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(274, 397);
            this.MinimumSize = new System.Drawing.Size(274, 397);
            this.Name = "noma_main_form";
            this.Text = "Noma - Natural Gesture Computer Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

