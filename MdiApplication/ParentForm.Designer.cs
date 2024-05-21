namespace MdiApplication
{
    partial class ParentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            MdiMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            windowMenuItem = new ToolStripMenuItem();
            windowCasacadeMenuItem = new ToolStripMenuItem();
            windowTileMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            spWin = new ToolStripStatusLabel();
            spData = new ToolStripStatusLabel();
            MdiMenu.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MdiMenu
            // 
            MdiMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, windowMenuItem });
            MdiMenu.Location = new Point(0, 0);
            MdiMenu.MdiWindowListItem = windowMenuItem;
            MdiMenu.Name = "MdiMenu";
            MdiMenu.Size = new Size(434, 24);
            MdiMenu.TabIndex = 1;
            MdiMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, exitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.Size = new Size(98, 22);
            newMenuItem.Text = "&New";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(98, 22);
            exitMenuItem.Text = "&Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // windowMenuItem
            // 
            windowMenuItem.DropDownItems.AddRange(new ToolStripItem[] { windowCasacadeMenuItem, windowTileMenuItem });
            windowMenuItem.Name = "windowMenuItem";
            windowMenuItem.Size = new Size(63, 20);
            windowMenuItem.Text = "&Window";
            // 
            // windowCasacadeMenuItem
            // 
            windowCasacadeMenuItem.Name = "windowCasacadeMenuItem";
            windowCasacadeMenuItem.Size = new Size(118, 22);
            windowCasacadeMenuItem.Text = "&Cascade";
            windowCasacadeMenuItem.Click += windowCasacadeMenuItem_Click;
            // 
            // windowTileMenuItem
            // 
            windowTileMenuItem.Name = "windowTileMenuItem";
            windowTileMenuItem.Size = new Size(118, 22);
            windowTileMenuItem.Text = "&Tile";
            windowTileMenuItem.Click += windowTileMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(434, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Tag = "NewDoc";
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Create new document";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Tag = "Cascade";
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Windows cascade";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Tag = "Title";
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.ToolTipText = "Windows title";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { spWin, spData });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(434, 22);
            statusStrip1.TabIndex = 5;
            // 
            // spWin
            // 
            spWin.Name = "spWin";
            spWin.Size = new Size(39, 17);
            spWin.Text = "Status";
            // 
            // spData
            // 
            spData.Name = "spData";
            spData.Size = new Size(31, 17);
            spData.Text = "Data";
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 311);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(MdiMenu);
            IsMdiContainer = true;
            MainMenuStrip = MdiMenu;
            Name = "ParentForm";
            Text = "ParentForm";
            MdiMenu.ResumeLayout(false);
            MdiMenu.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MdiMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem windowMenuItem;
        private ToolStripMenuItem windowCasacadeMenuItem;
        private ToolStripMenuItem windowTileMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spWin;
        private ToolStripStatusLabel spData;
    }
}
