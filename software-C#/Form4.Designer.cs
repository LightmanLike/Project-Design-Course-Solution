namespace jieyouzahuodian
{
    partial class Form4
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1：在主菜单中点击购买键。");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2：按照提示刷卡，等待电脑读取您的过敏原信息。");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("3：按照界面的指引选择货物种类、数量等完成选择。");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("4：等待机器出货，完成购买。");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("如何购买？", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("维护模式是本机开发人员进行机器维护与调试的专用模式。");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("维护模式", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1我不想购买了：在任意界面中点击“返回主菜单”键，即可放弃购买。");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("2我想要的商品没货了：商品库存不足时，相关人员会尽快补充库存，请您谅解。");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("3我想购买我的过敏食品：请联系客服电话获取人工购买服务。");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("遇到问题？", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("请联系客服电话：158-7755-3015");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("我要反馈", new System.Windows.Forms.TreeNode[] {
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
            treeNode1.Text = "1：在主菜单中点击购买键。";
            treeNode2.Name = "节点2";
            treeNode2.Text = "2：按照提示刷卡，等待电脑读取您的过敏原信息。";
            treeNode3.Name = "节点3";
            treeNode3.Text = "3：按照界面的指引选择货物种类、数量等完成选择。";
            treeNode4.Name = "节点4";
            treeNode4.Text = "4：等待机器出货，完成购买。";
            treeNode5.Name = "节点0";
            treeNode5.Text = "如何购买？";
            treeNode6.Name = "节点6";
            treeNode6.Text = "维护模式是本机开发人员进行机器维护与调试的专用模式。";
            treeNode7.Name = "节点5";
            treeNode7.Text = "维护模式";
            treeNode8.Name = "节点7";
            treeNode8.Text = "1我不想购买了：在任意界面中点击“返回主菜单”键，即可放弃购买。";
            treeNode9.Name = "节点8";
            treeNode9.Text = "2我想要的商品没货了：商品库存不足时，相关人员会尽快补充库存，请您谅解。";
            treeNode10.Name = "节点10";
            treeNode10.Text = "3我想购买我的过敏食品：请联系客服电话获取人工购买服务。";
            treeNode11.Name = "节点8";
            treeNode11.Text = "遇到问题？";
            treeNode12.Name = "节点12";
            treeNode12.Text = "请联系客服电话：158-7755-3015";
            treeNode13.Name = "节点11";
            treeNode13.Text = "我要反馈";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7,
            treeNode11,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(751, 342);
            this.treeView1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 342);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Form4";
            this.Text = "帮助";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;

    }
}