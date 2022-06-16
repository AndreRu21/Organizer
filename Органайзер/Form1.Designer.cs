namespace Органайзер
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.fSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.evAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.evEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.evDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.evClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearAll = new System.Windows.Forms.ToolStripButton();
            this.ListBoxEvent = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslAllEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDoneEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEvent});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(545, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fOpen,
            this.fSave,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(48, 20);
            this.mFile.Text = "Файл";
            // 
            // fOpen
            // 
            this.fOpen.Image = ((System.Drawing.Image)(resources.GetObject("fOpen.Image")));
            this.fOpen.ImageTransparentColor = System.Drawing.Color.Silver;
            this.fOpen.Name = "fOpen";
            this.fOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fOpen.Size = new System.Drawing.Size(173, 22);
            this.fOpen.Text = "Открыть";
            this.fOpen.Click += new System.EventHandler(this.fOpen_Click);
            // 
            // fSave
            // 
            this.fSave.Image = ((System.Drawing.Image)(resources.GetObject("fSave.Image")));
            this.fSave.ImageTransparentColor = System.Drawing.Color.Silver;
            this.fSave.Name = "fSave";
            this.fSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fSave.Size = new System.Drawing.Size(173, 22);
            this.fSave.Text = "Сохранить";
            this.fSave.Click += new System.EventHandler(this.fSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // mEvent
            // 
            this.mEvent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evAdd,
            this.evEdit,
            this.evDelete,
            this.toolStripMenuItem2,
            this.evClearAll});
            this.mEvent.Name = "mEvent";
            this.mEvent.Size = new System.Drawing.Size(68, 20);
            this.mEvent.Text = "Событие";
            // 
            // evAdd
            // 
            this.evAdd.Image = ((System.Drawing.Image)(resources.GetObject("evAdd.Image")));
            this.evAdd.Name = "evAdd";
            this.evAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.evAdd.Size = new System.Drawing.Size(194, 22);
            this.evAdd.Text = "Добавить";
            this.evAdd.Click += new System.EventHandler(this.evAdd_Click);
            // 
            // evEdit
            // 
            this.evEdit.Image = ((System.Drawing.Image)(resources.GetObject("evEdit.Image")));
            this.evEdit.Name = "evEdit";
            this.evEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.evEdit.Size = new System.Drawing.Size(194, 22);
            this.evEdit.Text = "Редактировать";
            this.evEdit.Click += new System.EventHandler(this.evEdit_Click);
            // 
            // evDelete
            // 
            this.evDelete.Image = ((System.Drawing.Image)(resources.GetObject("evDelete.Image")));
            this.evDelete.Name = "evDelete";
            this.evDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.evDelete.Size = new System.Drawing.Size(194, 22);
            this.evDelete.Text = "Удалить";
            this.evDelete.Click += new System.EventHandler(this.evDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 6);
            // 
            // evClearAll
            // 
            this.evClearAll.Image = ((System.Drawing.Image)(resources.GetObject("evClearAll.Image")));
            this.evClearAll.Name = "evClearAll";
            this.evClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.evClearAll.Size = new System.Drawing.Size(194, 22);
            this.evClearAll.Text = "Очистить все";
            this.evClearAll.Click += new System.EventHandler(this.evClearAll_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel,
            this.toolStripSeparator2,
            this.tsbClearAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(228, 37);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(34, 34);
            this.tsbOpen.Text = "toolStripButton1";
            this.tsbOpen.ToolTipText = "Открыть список событий из файла";
            this.tsbOpen.Click += new System.EventHandler(this.fOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(34, 34);
            this.tsbSave.Text = "toolStripButton2";
            this.tsbSave.ToolTipText = "Сохранить список событий в файл";
            this.tsbSave.Click += new System.EventHandler(this.fSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(34, 34);
            this.tsbAdd.Text = "toolStripButton3";
            this.tsbAdd.ToolTipText = "Добавить новое событие";
            this.tsbAdd.Click += new System.EventHandler(this.evAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(34, 34);
            this.tsbEdit.ToolTipText = "Редактировать событие";
            this.tsbEdit.Click += new System.EventHandler(this.evEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(34, 34);
            this.tsbDel.Text = "toolStripButton5";
            this.tsbDel.ToolTipText = "Удалить событие";
            this.tsbDel.Click += new System.EventHandler(this.evDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbClearAll
            // 
            this.tsbClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbClearAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearAll.Image")));
            this.tsbClearAll.ImageTransparentColor = System.Drawing.Color.Silver;
            this.tsbClearAll.Name = "tsbClearAll";
            this.tsbClearAll.Size = new System.Drawing.Size(34, 34);
            this.tsbClearAll.Text = "toolStripButton6";
            this.tsbClearAll.ToolTipText = "Очистить весь список с событиями";
            this.tsbClearAll.Click += new System.EventHandler(this.evClearAll_Click);
            // 
            // ListBoxEvent
            // 
            this.ListBoxEvent.ContextMenuStrip = this.contextMenuStrip2;
            this.ListBoxEvent.FormattingEnabled = true;
            this.ListBoxEvent.Location = new System.Drawing.Point(12, 64);
            this.ListBoxEvent.Name = "ListBoxEvent";
            this.ListBoxEvent.Size = new System.Drawing.Size(521, 290);
            this.ListBoxEvent.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmAdd,
            this.cmEdit,
            this.cmDel,
            this.toolStripMenuItem3,
            this.cmClearAll});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(195, 98);
            // 
            // cmAdd
            // 
            this.cmAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmAdd.Image")));
            this.cmAdd.Name = "cmAdd";
            this.cmAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cmAdd.Size = new System.Drawing.Size(194, 22);
            this.cmAdd.Text = "Добавить";
            this.cmAdd.Click += new System.EventHandler(this.evAdd_Click);
            // 
            // cmEdit
            // 
            this.cmEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmEdit.Image")));
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cmEdit.Size = new System.Drawing.Size(194, 22);
            this.cmEdit.Text = "Редактировать";
            this.cmEdit.Click += new System.EventHandler(this.evEdit_Click);
            // 
            // cmDel
            // 
            this.cmDel.Image = ((System.Drawing.Image)(resources.GetObject("cmDel.Image")));
            this.cmDel.Name = "cmDel";
            this.cmDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.cmDel.Size = new System.Drawing.Size(194, 22);
            this.cmDel.Text = "Удалить";
            this.cmDel.Click += new System.EventHandler(this.evDelete_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 6);
            // 
            // cmClearAll
            // 
            this.cmClearAll.Image = ((System.Drawing.Image)(resources.GetObject("cmClearAll.Image")));
            this.cmClearAll.Name = "cmClearAll";
            this.cmClearAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.cmClearAll.Size = new System.Drawing.Size(194, 22);
            this.cmClearAll.Text = "Очистить все";
            this.cmClearAll.Click += new System.EventHandler(this.evClearAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAllEvent,
            this.tslDoneEvent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 370);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslAllEvent
            // 
            this.tslAllEvent.Name = "tslAllEvent";
            this.tslAllEvent.Size = new System.Drawing.Size(92, 17);
            this.tslAllEvent.Text = "Всего событий:";
            // 
            // tslDoneEvent
            // 
            this.tslDoneEvent.Name = "tslDoneEvent";
            this.tslDoneEvent.Size = new System.Drawing.Size(276, 17);
            this.tslDoneEvent.Text = "За последний сеанс работы наступило событий:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "evnt";
            this.saveFileDialog1.Filter = "Файлы органайзера|*.evnt|Все файлы|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файлы органайзера|*.evnt|Все файлы|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 392);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ListBoxEvent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Органайзер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem fOpen;
        private System.Windows.Forms.ToolStripMenuItem fSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEvent;
        private System.Windows.Forms.ToolStripMenuItem evAdd;
        private System.Windows.Forms.ToolStripMenuItem evEdit;
        private System.Windows.Forms.ToolStripMenuItem evDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem evClearAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbClearAll;
        private System.Windows.Forms.ListBox ListBoxEvent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmAdd;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cmClearAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslAllEvent;
        private System.Windows.Forms.ToolStripStatusLabel tslDoneEvent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

