namespace StageMachineCtrlSys
{
    partial class repetoreInRM
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.repetoreName = new System.Windows.Forms.TextBox();
            this.repetoreDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newRepetore = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exportRepetore = new System.Windows.Forms.Button();
            this.importRepetore = new System.Windows.Forms.Button();
            this.addScenes = new System.Windows.Forms.Button();
            this.sortScenes = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.repetoreName);
            this.groupBox.Location = new System.Drawing.Point(8, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(751, 56);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "剧目名称";
            // 
            // repetoreName
            // 
            this.repetoreName.Location = new System.Drawing.Point(6, 21);
            this.repetoreName.Name = "repetoreName";
            this.repetoreName.Size = new System.Drawing.Size(739, 21);
            this.repetoreName.TabIndex = 0;
            // 
            // repetoreDescription
            // 
            this.repetoreDescription.Location = new System.Drawing.Point(6, 19);
            this.repetoreDescription.Multiline = true;
            this.repetoreDescription.Name = "repetoreDescription";
            this.repetoreDescription.Size = new System.Drawing.Size(739, 164);
            this.repetoreDescription.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repetoreDescription);
            this.groupBox1.Location = new System.Drawing.Point(8, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "剧目描述";
            // 
            // newRepetore
            // 
            this.newRepetore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newRepetore.Location = new System.Drawing.Point(2, 14);
            this.newRepetore.Name = "newRepetore";
            this.newRepetore.Size = new System.Drawing.Size(102, 34);
            this.newRepetore.TabIndex = 2;
            this.newRepetore.Text = "新建剧目";
            this.newRepetore.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exportRepetore);
            this.groupBox2.Controls.Add(this.newRepetore);
            this.groupBox2.Controls.Add(this.importRepetore);
            this.groupBox2.Controls.Add(this.addScenes);
            this.groupBox2.Controls.Add(this.sortScenes);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Location = new System.Drawing.Point(8, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 54);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // exportRepetore
            // 
            this.exportRepetore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportRepetore.Location = new System.Drawing.Point(644, 14);
            this.exportRepetore.Name = "exportRepetore";
            this.exportRepetore.Size = new System.Drawing.Size(102, 34);
            this.exportRepetore.TabIndex = 15;
            this.exportRepetore.Text = "导出剧目";
            this.exportRepetore.UseVisualStyleBackColor = true;
            // 
            // importRepetore
            // 
            this.importRepetore.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.importRepetore.Location = new System.Drawing.Point(537, 14);
            this.importRepetore.Name = "importRepetore";
            this.importRepetore.Size = new System.Drawing.Size(102, 34);
            this.importRepetore.TabIndex = 14;
            this.importRepetore.Text = "导入剧目";
            this.importRepetore.UseVisualStyleBackColor = true;
            // 
            // addScenes
            // 
            this.addScenes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addScenes.Location = new System.Drawing.Point(323, 14);
            this.addScenes.Name = "addScenes";
            this.addScenes.Size = new System.Drawing.Size(102, 34);
            this.addScenes.TabIndex = 12;
            this.addScenes.Text = "添加场景";
            this.addScenes.UseVisualStyleBackColor = true;
            // 
            // sortScenes
            // 
            this.sortScenes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortScenes.Location = new System.Drawing.Point(430, 14);
            this.sortScenes.Name = "sortScenes";
            this.sortScenes.Size = new System.Drawing.Size(102, 34);
            this.sortScenes.TabIndex = 13;
            this.sortScenes.Text = "场景排序";
            this.sortScenes.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(109, 14);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 34);
            this.save.TabIndex = 10;
            this.save.Text = "保存更改";
            this.save.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete.Location = new System.Drawing.Point(216, 14);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 34);
            this.delete.TabIndex = 11;
            this.delete.Text = "删除剧目";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // repetoreInRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Name = "repetoreInRM";
            this.Size = new System.Drawing.Size(767, 518);
            this.Resize += new System.EventHandler(this.repetoreInRM_Resize);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox repetoreName;
        private System.Windows.Forms.TextBox repetoreDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newRepetore;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button exportRepetore;
        private System.Windows.Forms.Button importRepetore;
        private System.Windows.Forms.Button addScenes;
        private System.Windows.Forms.Button sortScenes;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
    }
}
