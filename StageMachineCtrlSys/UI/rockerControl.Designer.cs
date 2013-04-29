namespace StageMachineCtrlSys
{
    partial class rockerControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addmachineLeft = new System.Windows.Forms.Button();
            this.machineListLeft = new System.Windows.Forms.ComboBox();
            this.machineLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addMachineList = new System.Windows.Forms.Button();
            this.machineListRight = new System.Windows.Forms.ComboBox();
            this.machineRight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "摇杆属性设置区";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(6, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "右侧摇杆";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "场次控制";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "设备控制";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "左侧摇杆";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "场次控制";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "设备控制";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addmachineLeft);
            this.groupBox4.Controls.Add(this.machineListLeft);
            this.groupBox4.Controls.Add(this.machineLeft);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(199, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 367);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "左侧摇杆";
            // 
            // addmachineLeft
            // 
            this.addmachineLeft.Location = new System.Drawing.Point(141, 334);
            this.addmachineLeft.Name = "addmachineLeft";
            this.addmachineLeft.Size = new System.Drawing.Size(77, 24);
            this.addmachineLeft.TabIndex = 3;
            this.addmachineLeft.Text = "添加设备";
            this.addmachineLeft.UseVisualStyleBackColor = true;
            this.addmachineLeft.Click += new System.EventHandler(this.addmachineLeft_Click);
            // 
            // machineListLeft
            // 
            this.machineListLeft.FormattingEnabled = true;
            this.machineListLeft.Location = new System.Drawing.Point(8, 335);
            this.machineListLeft.Name = "machineListLeft";
            this.machineListLeft.Size = new System.Drawing.Size(127, 20);
            this.machineListLeft.TabIndex = 2;
            // 
            // machineLeft
            // 
            this.machineLeft.Location = new System.Drawing.Point(63, 310);
            this.machineLeft.Name = "machineLeft";
            this.machineLeft.Size = new System.Drawing.Size(52, 21);
            this.machineLeft.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设  备：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addMachineList);
            this.groupBox5.Controls.Add(this.machineListRight);
            this.groupBox5.Controls.Add(this.machineRight);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(434, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 367);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "右侧摇杆";
            // 
            // addMachineList
            // 
            this.addMachineList.Location = new System.Drawing.Point(139, 336);
            this.addMachineList.Name = "addMachineList";
            this.addMachineList.Size = new System.Drawing.Size(77, 24);
            this.addMachineList.TabIndex = 7;
            this.addMachineList.Text = "添加设备";
            this.addMachineList.UseVisualStyleBackColor = true;
            // 
            // machineListRight
            // 
            this.machineListRight.FormattingEnabled = true;
            this.machineListRight.Location = new System.Drawing.Point(6, 337);
            this.machineListRight.Name = "machineListRight";
            this.machineListRight.Size = new System.Drawing.Size(127, 20);
            this.machineListRight.TabIndex = 6;
            // 
            // machineRight
            // 
            this.machineRight.Location = new System.Drawing.Point(61, 312);
            this.machineRight.Name = "machineRight";
            this.machineRight.Size = new System.Drawing.Size(52, 21);
            this.machineRight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "设  备：";
            // 
            // rockerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 374);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "rockerControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "摇杆控制";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.rockerControl_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addmachineLeft;
        private System.Windows.Forms.ComboBox machineListLeft;
        private System.Windows.Forms.TextBox machineLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button addMachineList;
        private System.Windows.Forms.ComboBox machineListRight;
        private System.Windows.Forms.TextBox machineRight;
        private System.Windows.Forms.Label label2;
    }
}