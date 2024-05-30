namespace PR_4
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arraySelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.arrayBuble = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sort = new System.Windows.Forms.Button();
            this.checkSelect = new System.Windows.Forms.CheckBox();
            this.checkBuble = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.array = new System.Windows.Forms.TextBox();
            this.checkMerge = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.arrayMerge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Программа сортирует введенный массив тремя способами по выбору";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.arrayMerge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.arraySelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.arrayBuble);
            this.groupBox2.Location = new System.Drawing.Point(5, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 189);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Массив, сортированный методом выбора";
            // 
            // arraySelect
            // 
            this.arraySelect.Location = new System.Drawing.Point(14, 96);
            this.arraySelect.Name = "arraySelect";
            this.arraySelect.ReadOnly = true;
            this.arraySelect.Size = new System.Drawing.Size(397, 20);
            this.arraySelect.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Массив, сортированный методом пузырька";
            // 
            // arrayBuble
            // 
            this.arrayBuble.Location = new System.Drawing.Point(14, 47);
            this.arrayBuble.Name = "arrayBuble";
            this.arrayBuble.ReadOnly = true;
            this.arrayBuble.Size = new System.Drawing.Size(397, 20);
            this.arrayBuble.TabIndex = 2;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.referenceToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(484, 24);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cleanToolStripMenuItem.Text = "Очистить";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.checkMerge);
            this.groupBox1.Controls.Add(this.Sort);
            this.groupBox1.Controls.Add(this.checkSelect);
            this.groupBox1.Controls.Add(this.checkBuble);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.array);
            this.groupBox1.Location = new System.Drawing.Point(5, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 164);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения:";
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(154, 126);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(75, 23);
            this.Sort.TabIndex = 11;
            this.Sort.Text = "Сортировка";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // checkSelect
            // 
            this.checkSelect.AutoSize = true;
            this.checkSelect.Location = new System.Drawing.Point(130, 92);
            this.checkSelect.Name = "checkSelect";
            this.checkSelect.Size = new System.Drawing.Size(99, 17);
            this.checkSelect.TabIndex = 9;
            this.checkSelect.Text = "Метод выбора";
            this.checkSelect.UseVisualStyleBackColor = true;
            // 
            // checkBuble
            // 
            this.checkBuble.AutoSize = true;
            this.checkBuble.Location = new System.Drawing.Point(14, 92);
            this.checkBuble.Name = "checkBuble";
            this.checkBuble.Size = new System.Drawing.Size(110, 17);
            this.checkBuble.TabIndex = 8;
            this.checkBuble.Text = "Метод пузырька";
            this.checkBuble.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите одномерный массив со значениями через запятую\r\n";
            // 
            // array
            // 
            this.array.Location = new System.Drawing.Point(14, 66);
            this.array.Name = "array";
            this.array.Size = new System.Drawing.Size(397, 20);
            this.array.TabIndex = 0;
            // 
            // checkMerge
            // 
            this.checkMerge.AutoSize = true;
            this.checkMerge.Location = new System.Drawing.Point(235, 92);
            this.checkMerge.Name = "checkMerge";
            this.checkMerge.Size = new System.Drawing.Size(103, 17);
            this.checkMerge.TabIndex = 12;
            this.checkMerge.Text = "Метод слияния";
            this.checkMerge.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Массив, сортированный методом слияния";
            // 
            // arrayMerge
            // 
            this.arrayMerge.Location = new System.Drawing.Point(14, 145);
            this.arrayMerge.Name = "arrayMerge";
            this.arrayMerge.ReadOnly = true;
            this.arrayMerge.Size = new System.Drawing.Size(397, 20);
            this.arrayMerge.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(500, 460);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "Form1";
            this.Text = "Массив";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox array;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arraySelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrayBuble;
        private System.Windows.Forms.CheckBox checkSelect;
        private System.Windows.Forms.CheckBox checkBuble;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arrayMerge;
        private System.Windows.Forms.CheckBox checkMerge;
    }
}

