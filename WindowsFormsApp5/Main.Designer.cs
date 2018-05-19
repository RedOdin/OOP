namespace WindowsFormsApp5
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MysticalDraw = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ewewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MysticalDraw)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MysticalDraw
            // 
            this.MysticalDraw.BackColor = System.Drawing.SystemColors.Window;
            this.MysticalDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MysticalDraw.Location = new System.Drawing.Point(0, 28);
            this.MysticalDraw.Name = "MysticalDraw";
            this.MysticalDraw.Size = new System.Drawing.Size(800, 422);
            this.MysticalDraw.TabIndex = 0;
            this.MysticalDraw.TabStop = false;
            this.MysticalDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.MysticalDraw_Paint);
            this.MysticalDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MysticalDraw_MouseDown);
            this.MysticalDraw.MouseLeave += new System.EventHandler(this.MysticalDraw_MouseLeave);
            this.MysticalDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MysticalDraw_MouseMove);
            this.MysticalDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MysticalDraw_MouseUp);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ewewToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.sdgToolStripMenuItem1,
            this.dToolStripMenuItem,
            this.fdhToolStripMenuItem,
            this.dfhToolStripMenuItem,
            this.hdfToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ewewToolStripMenuItem
            // 
            this.ewewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ewewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ewewToolStripMenuItem.Image")));
            this.ewewToolStripMenuItem.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.ewewToolStripMenuItem.Name = "ewewToolStripMenuItem";
            this.ewewToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineToolStripMenuItem.Image")));
            this.LineToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.LineToolStripMenuItem.Click += new System.EventHandler(this.LineToolStripMenuItem_Click);
            // 
            // sdgToolStripMenuItem1
            // 
            this.sdgToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sdgToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sdgToolStripMenuItem1.Image")));
            this.sdgToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sdgToolStripMenuItem1.Name = "sdgToolStripMenuItem1";
            this.sdgToolStripMenuItem1.Size = new System.Drawing.Size(32, 24);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dToolStripMenuItem.Image")));
            this.dToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.dToolStripMenuItem.Text = "d";
            // 
            // fdhToolStripMenuItem
            // 
            this.fdhToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fdhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fdhToolStripMenuItem.Image")));
            this.fdhToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fdhToolStripMenuItem.Name = "fdhToolStripMenuItem";
            this.fdhToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.fdhToolStripMenuItem.Text = "fdh";
            // 
            // dfhToolStripMenuItem
            // 
            this.dfhToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dfhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dfhToolStripMenuItem.Image")));
            this.dfhToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dfhToolStripMenuItem.Name = "dfhToolStripMenuItem";
            this.dfhToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.dfhToolStripMenuItem.Text = "dfh";
            // 
            // hdfToolStripMenuItem
            // 
            this.hdfToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hdfToolStripMenuItem.Name = "hdfToolStripMenuItem";
            this.hdfToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            this.hdfToolStripMenuItem.Text = "hdf";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MysticalDraw);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "MiracleLine";
            ((System.ComponentModel.ISupportInitialize)(this.MysticalDraw)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MysticalDraw;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ewewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hdfToolStripMenuItem;
    }
}

