namespace WindowsFormsApp1
{
    partial class PortTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortTest));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortSetting = new System.Windows.Forms.GroupBox();
            this.Scanbtn = new System.Windows.Forms.Button();
            this.OpenProdbtn = new System.Windows.Forms.Button();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.ProtNO = new System.Windows.Forms.ComboBox();
            this.Baudlabel = new System.Windows.Forms.Label();
            this.ProtNOlabel = new System.Windows.Forms.Label();
            this.ReceptionBox = new System.Windows.Forms.GroupBox();
            this.empty = new System.Windows.Forms.Button();
            this.Reception = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SandBox = new System.Windows.Forms.GroupBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.TextBox();
            this.PortSetting.SuspendLayout();
            this.ReceptionBox.SuspendLayout();
            this.SandBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortSetting
            // 
            this.PortSetting.Controls.Add(this.Scanbtn);
            this.PortSetting.Controls.Add(this.OpenProdbtn);
            this.PortSetting.Controls.Add(this.Baud);
            this.PortSetting.Controls.Add(this.ProtNO);
            this.PortSetting.Controls.Add(this.Baudlabel);
            this.PortSetting.Controls.Add(this.ProtNOlabel);
            this.PortSetting.Location = new System.Drawing.Point(12, 12);
            this.PortSetting.Name = "PortSetting";
            this.PortSetting.Size = new System.Drawing.Size(479, 155);
            this.PortSetting.TabIndex = 0;
            this.PortSetting.TabStop = false;
            this.PortSetting.Text = "串口设置";
            // 
            // Scanbtn
            // 
            this.Scanbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scanbtn.Location = new System.Drawing.Point(383, 34);
            this.Scanbtn.Name = "Scanbtn";
            this.Scanbtn.Size = new System.Drawing.Size(75, 23);
            this.Scanbtn.TabIndex = 5;
            this.Scanbtn.Text = "扫描串口";
            this.Scanbtn.UseVisualStyleBackColor = true;
            this.Scanbtn.Click += new System.EventHandler(this.Scanbtn_Click);
            // 
            // OpenProdbtn
            // 
            this.OpenProdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenProdbtn.ForeColor = System.Drawing.Color.Black;
            this.OpenProdbtn.Location = new System.Drawing.Point(383, 104);
            this.OpenProdbtn.Name = "OpenProdbtn";
            this.OpenProdbtn.Size = new System.Drawing.Size(75, 23);
            this.OpenProdbtn.TabIndex = 4;
            this.OpenProdbtn.Text = "打开串口";
            this.OpenProdbtn.UseVisualStyleBackColor = true;
            this.OpenProdbtn.Click += new System.EventHandler(this.OpenProdbtn_Click);
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.Baud.Location = new System.Drawing.Point(105, 101);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(121, 20);
            this.Baud.TabIndex = 3;
            // 
            // ProtNO
            // 
            this.ProtNO.FormattingEnabled = true;
            this.ProtNO.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3"});
            this.ProtNO.Location = new System.Drawing.Point(105, 31);
            this.ProtNO.Name = "ProtNO";
            this.ProtNO.Size = new System.Drawing.Size(121, 20);
            this.ProtNO.TabIndex = 2;
            // 
            // Baudlabel
            // 
            this.Baudlabel.AutoSize = true;
            this.Baudlabel.Location = new System.Drawing.Point(42, 104);
            this.Baudlabel.Name = "Baudlabel";
            this.Baudlabel.Size = new System.Drawing.Size(41, 12);
            this.Baudlabel.TabIndex = 1;
            this.Baudlabel.Text = "波特率";
            // 
            // ProtNOlabel
            // 
            this.ProtNOlabel.AutoSize = true;
            this.ProtNOlabel.Location = new System.Drawing.Point(42, 34);
            this.ProtNOlabel.Name = "ProtNOlabel";
            this.ProtNOlabel.Size = new System.Drawing.Size(41, 12);
            this.ProtNOlabel.TabIndex = 0;
            this.ProtNOlabel.Text = "串口号";
            // 
            // ReceptionBox
            // 
            this.ReceptionBox.Controls.Add(this.empty);
            this.ReceptionBox.Controls.Add(this.Reception);
            this.ReceptionBox.Controls.Add(this.groupBox3);
            this.ReceptionBox.Location = new System.Drawing.Point(12, 173);
            this.ReceptionBox.Name = "ReceptionBox";
            this.ReceptionBox.Size = new System.Drawing.Size(479, 120);
            this.ReceptionBox.TabIndex = 1;
            this.ReceptionBox.TabStop = false;
            this.ReceptionBox.Text = "接受数据";
            // 
            // empty
            // 
            this.empty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empty.Location = new System.Drawing.Point(383, 78);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(75, 23);
            this.empty.TabIndex = 3;
            this.empty.Text = "清空";
            this.empty.UseVisualStyleBackColor = true;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // Reception
            // 
            this.Reception.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Reception.Location = new System.Drawing.Point(22, 20);
            this.Reception.Multiline = true;
            this.Reception.Name = "Reception";
            this.Reception.ReadOnly = true;
            this.Reception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Reception.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Reception.Size = new System.Drawing.Size(362, 81);
            this.Reception.TabIndex = 2;
            this.Reception.TextChanged += new System.EventHandler(this.Reception_TextChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // SandBox
            // 
            this.SandBox.Controls.Add(this.Sendbtn);
            this.SandBox.Controls.Add(this.Send);
            this.SandBox.Location = new System.Drawing.Point(12, 299);
            this.SandBox.Name = "SandBox";
            this.SandBox.Size = new System.Drawing.Size(479, 131);
            this.SandBox.TabIndex = 2;
            this.SandBox.TabStop = false;
            this.SandBox.Text = "发送数据";
            // 
            // Sendbtn
            // 
            this.Sendbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sendbtn.ForeColor = System.Drawing.Color.Black;
            this.Sendbtn.Location = new System.Drawing.Point(383, 95);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 5;
            this.Sendbtn.Text = "发送";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // Send
            // 
            this.Send.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(22, 20);
            this.Send.Multiline = true;
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(345, 98);
            this.Send.TabIndex = 0;
            // 
            // PortTest
            // 
            this.AcceptButton = this.OpenProdbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 454);
            this.Controls.Add(this.SandBox);
            this.Controls.Add(this.ReceptionBox);
            this.Controls.Add(this.PortSetting);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PortSetting.ResumeLayout(false);
            this.PortSetting.PerformLayout();
            this.ReceptionBox.ResumeLayout(false);
            this.ReceptionBox.PerformLayout();
            this.SandBox.ResumeLayout(false);
            this.SandBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox PortSetting;
        private System.Windows.Forms.Button OpenProdbtn;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.ComboBox ProtNO;
        private System.Windows.Forms.Label Baudlabel;
        private System.Windows.Forms.Label ProtNOlabel;
        private System.Windows.Forms.GroupBox ReceptionBox;
        private System.Windows.Forms.TextBox Reception;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox SandBox;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox Send;
        private System.Windows.Forms.Button Scanbtn;
        private System.Windows.Forms.Button empty;
    }
}

