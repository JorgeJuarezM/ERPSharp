namespace ERPSharp
{
    partial class Menu
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
            menuTree = new TreeView();
            SuspendLayout();
            // 
            // menuTree
            // 
            menuTree.Dock = DockStyle.Left;
            menuTree.Location = new Point(0, 0);
            menuTree.Name = "menuTree";
            menuTree.Size = new Size(250, 450);
            menuTree.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuTree);
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private TreeView menuTree;
    }
}
