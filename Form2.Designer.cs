namespace LabClient
{
    partial class Form2
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加实验室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑实验室信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绑定传感器结点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看实验室状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(122, 449);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看实验室状态ToolStripMenuItem,
            this.添加实验室ToolStripMenuItem,
            this.编辑实验室信息ToolStripMenuItem,
            this.绑定传感器结点ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // 添加实验室ToolStripMenuItem
            // 
            this.添加实验室ToolStripMenuItem.Name = "添加实验室ToolStripMenuItem";
            this.添加实验室ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加实验室ToolStripMenuItem.Text = "添加实验室";
            this.添加实验室ToolStripMenuItem.Click += new System.EventHandler(this.添加实验室ToolStripMenuItem_Click);
            // 
            // 编辑实验室信息ToolStripMenuItem
            // 
            this.编辑实验室信息ToolStripMenuItem.Name = "编辑实验室信息ToolStripMenuItem";
            this.编辑实验室信息ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.编辑实验室信息ToolStripMenuItem.Text = "编辑实验室信息";
            this.编辑实验室信息ToolStripMenuItem.Click += new System.EventHandler(this.编辑实验室信息ToolStripMenuItem_Click);
            // 
            // 绑定传感器结点ToolStripMenuItem
            // 
            this.绑定传感器结点ToolStripMenuItem.Name = "绑定传感器结点ToolStripMenuItem";
            this.绑定传感器结点ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.绑定传感器结点ToolStripMenuItem.Text = "绑定传感器结点";
            // 
            // 查看实验室状态ToolStripMenuItem
            // 
            this.查看实验室状态ToolStripMenuItem.Name = "查看实验室状态ToolStripMenuItem";
            this.查看实验室状态ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看实验室状态ToolStripMenuItem.Text = "查看实验室状态";
            this.查看实验室状态ToolStripMenuItem.Click += new System.EventHandler(this.查看实验室状态ToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 450);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加实验室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑实验室信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看实验室状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绑定传感器结点ToolStripMenuItem;
    }
}