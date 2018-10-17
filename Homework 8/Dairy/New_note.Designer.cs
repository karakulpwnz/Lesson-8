namespace Dairy
{
    partial class New_note
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(21, 155);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(473, 181);
            this.txtNote.TabIndex = 4;
            this.txtNote.Click += new System.EventHandler(this.txtNote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата в формате мм/дд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Место";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(21, 31);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(259, 31);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 20);
            this.txtPlace.TabIndex = 2;
            this.txtPlace.Click += new System.EventHandler(this.txtPlace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Заголовок";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(21, 93);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Текст записи";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить запись";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(353, 367);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(127, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "label";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(176, 362);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(133, 23);
            this.btnReadAll.TabIndex = 6;
            this.btnReadAll.Text = "Вывести все записи";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // Dairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 411);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReadAll);
            this.Name = "Dairy";
            this.Text = "New note";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReadAll;
    }
}

