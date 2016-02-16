namespace Drawing_Application
{
    partial class FormMainCanvas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scribbleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourGradientBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insideColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outsideColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.drawingToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // drawingToolStripMenuItem
            // 
            this.drawingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.scribbleToolStripMenuItem});
            this.drawingToolStripMenuItem.Name = "drawingToolStripMenuItem";
            this.drawingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.drawingToolStripMenuItem.Text = "Drawing";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.selectBrushType);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.selectBrushType);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.selectBrushType);
            // 
            // scribbleToolStripMenuItem
            // 
            this.scribbleToolStripMenuItem.Name = "scribbleToolStripMenuItem";
            this.scribbleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.scribbleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.scribbleToolStripMenuItem.Text = "Scribble";
            this.scribbleToolStripMenuItem.Click += new System.EventHandler(this.selectBrushType);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColourToolStripMenuItem,
            this.colorPenToolStripMenuItem,
            this.colourBrushToolStripMenuItem,
            this.colourGradientBrushToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            this.backgroundColourToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.backgroundColourToolStripMenuItem.Text = "Background Colour";
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.openColourDialog);
            // 
            // colorPenToolStripMenuItem
            // 
            this.colorPenToolStripMenuItem.Name = "colorPenToolStripMenuItem";
            this.colorPenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.colorPenToolStripMenuItem.Text = "Colour Pen";
            this.colorPenToolStripMenuItem.Click += new System.EventHandler(this.openColourDialog);
            // 
            // colourBrushToolStripMenuItem
            // 
            this.colourBrushToolStripMenuItem.Name = "colourBrushToolStripMenuItem";
            this.colourBrushToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.colourBrushToolStripMenuItem.Text = "Colour Brush";
            this.colourBrushToolStripMenuItem.Click += new System.EventHandler(this.openColourDialog);
            // 
            // colourGradientBrushToolStripMenuItem
            // 
            this.colourGradientBrushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insideColourToolStripMenuItem,
            this.outsideColourToolStripMenuItem});
            this.colourGradientBrushToolStripMenuItem.Name = "colourGradientBrushToolStripMenuItem";
            this.colourGradientBrushToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.colourGradientBrushToolStripMenuItem.Text = "Colour Gradient Brush";
            // 
            // insideColourToolStripMenuItem
            // 
            this.insideColourToolStripMenuItem.Name = "insideColourToolStripMenuItem";
            this.insideColourToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.insideColourToolStripMenuItem.Text = "Inside Colour";
            this.insideColourToolStripMenuItem.Click += new System.EventHandler(this.openColourDialog);
            // 
            // outsideColourToolStripMenuItem
            // 
            this.outsideColourToolStripMenuItem.Name = "outsideColourToolStripMenuItem";
            this.outsideColourToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.outsideColourToolStripMenuItem.Text = "Outside Colour";
            this.outsideColourToolStripMenuItem.Click += new System.EventHandler(this.openColourDialog);
            // 
            // FormMainCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(394, 354);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainCanvas";
            this.Text = "Connor and Xavier\'s Magical Colour Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainCanvas_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMainCanvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMainCanvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMainCanvas_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scribbleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourGradientBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insideColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outsideColourToolStripMenuItem;
    }
}

