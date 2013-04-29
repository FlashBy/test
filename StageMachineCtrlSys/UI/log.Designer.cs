namespace StageMachineCtrlSys
{
    partial class log
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.clearLogs = new System.Windows.Forms.Button();
            this.allLogs = new System.Windows.Forms.Button();
            this.queryAsTimespan = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.CountOfShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.classification = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NO,
            this.Date,
            this.User,
            this.Event});
            this.listView.Location = new System.Drawing.Point(1, 1);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(410, 323);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // NO
            // 
            this.NO.Text = "编号";
            this.NO.Width = 90;
            // 
            // Date
            // 
            this.Date.Text = "日期";
            this.Date.Width = 240;
            // 
            // User
            // 
            this.User.Text = "用户名";
            this.User.Width = 120;
            // 
            // Event
            // 
            this.Event.Text = "事件";
            this.Event.Width = 150;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.clearLogs);
            this.groupBox.Controls.Add(this.allLogs);
            this.groupBox.Controls.Add(this.queryAsTimespan);
            this.groupBox.Controls.Add(this.dateTimePickerTo);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.dateTimePickerFrom);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.OK);
            this.groupBox.Controls.Add(this.CountOfShow);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.classification);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.dateTimePicker);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(417, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(253, 320);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "日志操作";
            this.groupBox.Enter += new System.EventHandler(this.groupBox_Enter);
            // 
            // clearLogs
            // 
            this.clearLogs.Location = new System.Drawing.Point(134, 208);
            this.clearLogs.Name = "clearLogs";
            this.clearLogs.Size = new System.Drawing.Size(113, 21);
            this.clearLogs.TabIndex = 13;
            this.clearLogs.Text = "清空日志";
            this.clearLogs.UseVisualStyleBackColor = true;
            // 
            // allLogs
            // 
            this.allLogs.Location = new System.Drawing.Point(7, 208);
            this.allLogs.Name = "allLogs";
            this.allLogs.Size = new System.Drawing.Size(113, 21);
            this.allLogs.TabIndex = 12;
            this.allLogs.Text = "所有日志";
            this.allLogs.UseVisualStyleBackColor = true;
            // 
            // queryAsTimespan
            // 
            this.queryAsTimespan.Location = new System.Drawing.Point(134, 179);
            this.queryAsTimespan.Name = "queryAsTimespan";
            this.queryAsTimespan.Size = new System.Drawing.Size(113, 21);
            this.queryAsTimespan.TabIndex = 11;
            this.queryAsTimespan.Text = "按时间段查询";
            this.queryAsTimespan.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(76, 147);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(171, 21);
            this.dateTimePickerTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "截止时间";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(76, 116);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(171, 21);
            this.dateTimePickerFrom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "起始时间";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(169, 84);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(78, 21);
            this.OK.TabIndex = 6;
            this.OK.Text = "确  定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // CountOfShow
            // 
            this.CountOfShow.Location = new System.Drawing.Point(76, 84);
            this.CountOfShow.Name = "CountOfShow";
            this.CountOfShow.Size = new System.Drawing.Size(70, 21);
            this.CountOfShow.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "显示条数";
            // 
            // classification
            // 
            this.classification.FormattingEnabled = true;
            this.classification.Items.AddRange(new object[] {
            "系统日志",
            "操作日志",
            "报警日志"});
            this.classification.Location = new System.Drawing.Point(76, 51);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(171, 20);
            this.classification.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "分类查询";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(76, 16);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(171, 21);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间选择";
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.listView);
            this.Name = "log";
            this.Size = new System.Drawing.Size(672, 330);
            this.Load += new System.EventHandler(this.log_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NO;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearLogs;
        private System.Windows.Forms.Button allLogs;
        private System.Windows.Forms.Button queryAsTimespan;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox CountOfShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Event;
    }
}
