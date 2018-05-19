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
            this.PenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RhombusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MysticalDraw.Size = new System.Drawing.Size(850, 516);
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
            this.PenToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.CircleToolStripMenuItem1,
            this.EllipseToolStripMenuItem,
            this.SquareToolStripMenuItem,
            this.RectangleToolStripMenuItem,
            this.RhombusToolStripMenuItem,
            this.TriangleToolStripMenuItem,
            this.ColorToolStripMenuItem,
            this.WidthToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(850, 28);
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
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // PenToolStripMenuItem
            // 
            this.PenToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PenToolStripMenuItem.Image")));
            this.PenToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PenToolStripMenuItem.Name = "PenToolStripMenuItem";
            this.PenToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.PenToolStripMenuItem.Click += new System.EventHandler(this.PenToolStripMenuItem_Click);
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
            // CircleToolStripMenuItem1
            // 
            this.CircleToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CircleToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("CircleToolStripMenuItem1.Image")));
            this.CircleToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CircleToolStripMenuItem1.Name = "CircleToolStripMenuItem1";
            this.CircleToolStripMenuItem1.Size = new System.Drawing.Size(32, 24);
            this.CircleToolStripMenuItem1.Click += new System.EventHandler(this.CircleToolStripMenuItem1_Click);
            // 
            // EllipseToolStripMenuItem
            // 
            this.EllipseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EllipseToolStripMenuItem.Image")));
            this.EllipseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.EllipseToolStripMenuItem.Name = "EllipseToolStripMenuItem";
            this.EllipseToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.EllipseToolStripMenuItem.Text = "d";
            this.EllipseToolStripMenuItem.Click += new System.EventHandler(this.EllipseToolStripMenuItem_Click);
            // 
            // SquareToolStripMenuItem
            // 
            this.SquareToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SquareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SquareToolStripMenuItem.Image")));
            this.SquareToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SquareToolStripMenuItem.Name = "SquareToolStripMenuItem";
            this.SquareToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.SquareToolStripMenuItem.Text = "fdh";
            this.SquareToolStripMenuItem.Click += new System.EventHandler(this.SquareToolStripMenuItem_Click);
            // 
            // RectangleToolStripMenuItem
            // 
            this.RectangleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RectangleToolStripMenuItem.Image")));
            this.RectangleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem";
            this.RectangleToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.RectangleToolStripMenuItem.Text = "dfh";
            this.RectangleToolStripMenuItem.Click += new System.EventHandler(this.RectangleToolStripMenuItem_Click);
            // 
            // RhombusToolStripMenuItem
            // 
            this.RhombusToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RhombusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RhombusToolStripMenuItem.Image")));
            this.RhombusToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RhombusToolStripMenuItem.Name = "RhombusToolStripMenuItem";
            this.RhombusToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.RhombusToolStripMenuItem.Click += new System.EventHandler(this.RhombusToolStripMenuItem_Click);
            // 
            // TriangleToolStripMenuItem
            // 
            this.TriangleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TriangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TriangleToolStripMenuItem.Image")));
            this.TriangleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TriangleToolStripMenuItem.Name = "TriangleToolStripMenuItem";
            this.TriangleToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            this.TriangleToolStripMenuItem.Click += new System.EventHandler(this.TriangleToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ColorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ColorToolStripMenuItem.Image")));
            this.ColorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            // 
            // WidthToolStripMenuItem
            // 
            this.WidthToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WidthToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WidthToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("WidthToolStripMenuItem.Image")));
            this.WidthToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.WidthToolStripMenuItem.Name = "WidthToolStripMenuItem";
            this.WidthToolStripMenuItem.Size = new System.Drawing.Size(32, 24);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 544);
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
        private System.Windows.Forms.ToolStripMenuItem PenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CircleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EllipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RhombusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TriangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    }
}

