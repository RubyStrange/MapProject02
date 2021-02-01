
namespace MapProject02
{
    partial class FormMapBoard
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJsonLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BaiduMapBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJsonLoad
            // 
            this.btnJsonLoad.Location = new System.Drawing.Point(691, 12);
            this.btnJsonLoad.Name = "btnJsonLoad";
            this.btnJsonLoad.Size = new System.Drawing.Size(150, 105);
            this.btnJsonLoad.TabIndex = 0;
            this.btnJsonLoad.Text = "绘制地图";
            this.btnJsonLoad.UseVisualStyleBackColor = true;
            this.btnJsonLoad.Click += new System.EventHandler(this.btnJsonLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(691, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "百度地图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 426);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // BaiduMapBrowser
            // 
            this.BaiduMapBrowser.Location = new System.Drawing.Point(12, 12);
            this.BaiduMapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.BaiduMapBrowser.Name = "BaiduMapBrowser";
            this.BaiduMapBrowser.Size = new System.Drawing.Size(664, 426);
            this.BaiduMapBrowser.TabIndex = 3;
            this.BaiduMapBrowser.Visible = false;
            // 
            // FormMapBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.BaiduMapBrowser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJsonLoad);
            this.Name = "FormMapBoard";
            this.Text = "MapProject";
            this.Load += new System.EventHandler(this.FormMapBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJsonLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser BaiduMapBrowser;
    }
}

