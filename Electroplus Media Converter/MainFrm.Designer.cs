namespace Electroplus_Media_Converter
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Port = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_PortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comport Settings";
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(81, 25);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 22);
            this.comboBox_PortName.TabIndex = 2;
            this.comboBox_PortName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_PortName_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "PortName: ";
            // 
            // textBox_IP
            // 
            this.textBox_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IP.Location = new System.Drawing.Point(58, 45);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(142, 22);
            this.textBox_IP.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Type);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown_Port);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_IP);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comport Settings";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.comboBox_Type.Location = new System.Drawing.Point(58, 18);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(142, 22);
            this.comboBox_Type.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port :  ";
            // 
            // numericUpDown_Port
            // 
            this.numericUpDown_Port.Location = new System.Drawing.Point(58, 72);
            this.numericUpDown_Port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Port.Name = "numericUpDown_Port";
            this.numericUpDown_Port.Size = new System.Drawing.Size(142, 22);
            this.numericUpDown_Port.TabIndex = 3;
            this.numericUpDown_Port.Value = new decimal(new int[] {
            4059,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP :  ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox_log);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 331);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(446, 329);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            this.richTextBox_log.TextChanged += new System.EventHandler(this.richTextBox_log_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_stop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_start, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 33);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Red;
            this.button_stop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stop.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.ForeColor = System.Drawing.Color.White;
            this.button_stop.Location = new System.Drawing.Point(219, 3);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(210, 27);
            this.button_stop.TabIndex = 8;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Chartreuse;
            this.button_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(3, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(210, 27);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 300;
            this.serialPort1.DataBits = 7;
            this.serialPort1.Parity = System.IO.Ports.Parity.Even;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electroplus Media converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

