namespace Органайзер
{
    partial class AddEditEvent
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxSayTime = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRepeatYear = new System.Windows.Forms.RadioButton();
            this.rbtOne = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите дату события:";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(194, 30);
            this.tbxTime.Mask = "00:00";
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(74, 20);
            this.tbxTime.TabIndex = 2;
            this.tbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите время события:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(194, 76);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(238, 20);
            this.tbxMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите текст сообщения:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(119, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxSayTime
            // 
            this.cbxSayTime.AutoSize = true;
            this.cbxSayTime.Location = new System.Drawing.Point(200, 175);
            this.cbxSayTime.Name = "cbxSayTime";
            this.cbxSayTime.Size = new System.Drawing.Size(139, 17);
            this.cbxSayTime.TabIndex = 8;
            this.cbxSayTime.Text = "Проговаривать время";
            this.cbxSayTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRepeatYear);
            this.groupBox1.Controls.Add(this.rbtOne);
            this.groupBox1.Location = new System.Drawing.Point(194, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Период вывода сообщения о событии";
            // 
            // rbtRepeatYear
            // 
            this.rbtRepeatYear.AutoSize = true;
            this.rbtRepeatYear.Location = new System.Drawing.Point(6, 39);
            this.rbtRepeatYear.Name = "rbtRepeatYear";
            this.rbtRepeatYear.Size = new System.Drawing.Size(209, 17);
            this.rbtRepeatYear.TabIndex = 1;
            this.rbtRepeatYear.Text = "ежегодно в указанную дату и время";
            this.rbtRepeatYear.UseVisualStyleBackColor = true;
            // 
            // rbtOne
            // 
            this.rbtOne.AutoSize = true;
            this.rbtOne.Checked = true;
            this.rbtOne.Location = new System.Drawing.Point(6, 16);
            this.rbtOne.Name = "rbtOne";
            this.rbtOne.Size = new System.Drawing.Size(205, 17);
            this.rbtOne.TabIndex = 0;
            this.rbtOne.TabStop = true;
            this.rbtOne.Text = "один раз в указанную дату и время";
            this.rbtOne.UseVisualStyleBackColor = true;
            // 
            // AddEditEvent
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(461, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxSayTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditEvent_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox tbxTime;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxMessage;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.CheckBox cbxSayTime;
        public System.Windows.Forms.RadioButton rbtRepeatYear;
        public System.Windows.Forms.RadioButton rbtOne;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}