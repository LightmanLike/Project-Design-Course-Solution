namespace jieyouzahuodian
{
    partial class Form4e
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1：Click on the purchase key in the main menu.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2：Swipe card according to the instruction, wait for the computer to read your all" +
                    "ergen information");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3：Choose the type and quantity of goods according to the guidelines of the interf" +
                    "ace.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4：Wait your goods , and complete the purchase.");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("How to Purchase？", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Maintenance mode is a special mode for machine developers to maintain and debug t" +
                    "he machine.");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Maintenance Mode", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1I do not want to buy it: click on the \"main menu\" button in any interface, then " +
                    "you can give up the purchase.");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2I want the goods out of stock: when the inventory is insufficient, the relevant " +
                    "personnel will replenish the stock as soon as possible, please understand.");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("3I want to buy my allergy food: please contact customer service phone to get arti" +
                    "ficial purchase service.");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Have Problem？", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Please contact：158-7755-3015");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("I want feedback", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("幼圆", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ForeColor = System.Drawing.Color.Gray;
            this.treeView1.ItemHeight = 50;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "1：Click on the purchase key in the main menu.";
            treeNode2.Name = "节点2";
            treeNode2.Text = "2：Swipe card according to the instruction, wait for the computer to read your all" +
                "ergen information";
            treeNode3.Name = "节点3";
            treeNode3.Text = "3：Choose the type and quantity of goods according to the guidelines of the interf" +
                "ace.";
            treeNode4.Name = "节点4";
            treeNode4.Text = "4：Wait your goods , and complete the purchase.";
            treeNode5.Name = "节点0";
            treeNode5.Text = "How to Purchase？";
            treeNode6.Name = "节点6";
            treeNode6.Text = "Maintenance mode is a special mode for machine developers to maintain and debug t" +
                "he machine.";
            treeNode7.Name = "节点5";
            treeNode7.Text = "Maintenance Mode";
            treeNode8.Name = "节点7";
            treeNode8.Text = "1I do not want to buy it: click on the \"main menu\" button in any interface, then " +
                "you can give up the purchase.";
            treeNode9.Name = "节点8";
            treeNode9.Text = "2I want the goods out of stock: when the inventory is insufficient, the relevant " +
                "personnel will replenish the stock as soon as possible, please understand.";
            treeNode10.Name = "节点10";
            treeNode10.Text = "3I want to buy my allergy food: please contact customer service phone to get arti" +
                "ficial purchase service.";
            treeNode11.Name = "节点8";
            treeNode11.Text = "Have Problem？";
            treeNode12.Name = "节点12";
            treeNode12.Text = "Please contact：158-7755-3015";
            treeNode13.Name = "节点11";
            treeNode13.Text = "I want feedback";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode11,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(751, 342);
            this.treeView1.TabIndex = 0;
            // 
            // Form4e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 342);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Form4e";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Form4e_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;

    }
}