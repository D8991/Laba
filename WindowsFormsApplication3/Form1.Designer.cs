namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArray = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBasic = new System.Windows.Forms.GroupBox();
            this.grvBasic = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.grbTask = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnTask = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBasic)).BeginInit();
            this.grbTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTask,
            this.mnuArray,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTask
            // 
            this.mnuTask.Enabled = false;
            this.mnuTask.Name = "mnuTask";
            this.mnuTask.Size = new System.Drawing.Size(57, 20);
            this.mnuTask.Text = "Задача";
            this.mnuTask.Click += new System.EventHandler(this.mnuTask_Click);
            // 
            // mnuArray
            // 
            this.mnuArray.Name = "mnuArray";
            this.mnuArray.Size = new System.Drawing.Size(61, 20);
            this.mnuArray.Text = "Массив";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuOpen});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // grbBasic
            // 
            this.grbBasic.Controls.Add(this.grvBasic);
            this.grbBasic.Controls.Add(this.groupBox1);
            this.grbBasic.Location = new System.Drawing.Point(0, 63);
            this.grbBasic.Name = "grbBasic";
            this.grbBasic.Size = new System.Drawing.Size(506, 78);
            this.grbBasic.TabIndex = 1;
            this.grbBasic.TabStop = false;
            this.grbBasic.Text = "Исходные данные";
            // 
            // grvBasic
            // 
            this.grvBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBasic.Location = new System.Drawing.Point(3, 16);
            this.grvBasic.Name = "grvBasic";
            this.grvBasic.Size = new System.Drawing.Size(497, 56);
            this.grvBasic.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(197, 37);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 2;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество элементов";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(363, 37);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Ок";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.btnCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCount_KeyPress);
            // 
            // grbTask
            // 
            this.grbTask.Controls.Add(this.lblC);
            this.grbTask.Controls.Add(this.lblTask);
            this.grbTask.Controls.Add(this.btnTask);
            this.grbTask.Controls.Add(this.txtC);
            this.grbTask.Location = new System.Drawing.Point(0, 147);
            this.grbTask.Name = "grbTask";
            this.grbTask.Size = new System.Drawing.Size(506, 110);
            this.grbTask.TabIndex = 4;
            this.grbTask.TabStop = false;
            this.grbTask.Text = "Задача";
            this.grbTask.Visible = false;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(74, 60);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 0;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(241, 60);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(75, 23);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Ok";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(12, 26);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(271, 13);
            this.lblTask.TabIndex = 2;
            this.lblTask.Text = "Количество элементов, больших заданного числа С";
            this.lblTask.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(23, 60);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(23, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "С =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 335);
            this.Controls.Add(this.grbTask);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.grbBasic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbBasic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvBasic)).EndInit();
            this.grbTask.ResumeLayout(false);
            this.grbTask.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTask;
        private System.Windows.Forms.ToolStripMenuItem mnuArray;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.GroupBox grbBasic;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbTask;
        private System.Windows.Forms.DataGridView grvBasic;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblTask;
    }
}

