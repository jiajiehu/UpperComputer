namespace UpperComputer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelCurrentT = new System.Windows.Forms.Label();
            this.LabelSetT = new System.Windows.Forms.Label();
            this.ButtonUpT = new System.Windows.Forms.Button();
            this.ButtonLowT = new System.Windows.Forms.Button();
            this.ButtonStartTrans = new System.Windows.Forms.Button();
            this.ButtonEndTrans = new System.Windows.Forms.Button();
            this.TimerGetT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前温度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(82, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "设定温度:";
            // 
            // LabelCurrentT
            // 
            this.LabelCurrentT.AutoSize = true;
            this.LabelCurrentT.BackColor = System.Drawing.Color.Transparent;
            this.LabelCurrentT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCurrentT.Location = new System.Drawing.Point(228, 67);
            this.LabelCurrentT.Name = "LabelCurrentT";
            this.LabelCurrentT.Size = new System.Drawing.Size(55, 16);
            this.LabelCurrentT.TabIndex = 2;
            this.LabelCurrentT.Text = "未通信";
            // 
            // LabelSetT
            // 
            this.LabelSetT.AutoSize = true;
            this.LabelSetT.BackColor = System.Drawing.Color.Transparent;
            this.LabelSetT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSetT.Location = new System.Drawing.Point(228, 138);
            this.LabelSetT.Name = "LabelSetT";
            this.LabelSetT.Size = new System.Drawing.Size(55, 16);
            this.LabelSetT.TabIndex = 3;
            this.LabelSetT.Text = "未通信";
            // 
            // ButtonUpT
            // 
            this.ButtonUpT.BackColor = System.Drawing.Color.Transparent;
            this.ButtonUpT.Enabled = false;
            this.ButtonUpT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonUpT.Location = new System.Drawing.Point(66, 207);
            this.ButtonUpT.Name = "ButtonUpT";
            this.ButtonUpT.Size = new System.Drawing.Size(100, 25);
            this.ButtonUpT.TabIndex = 4;
            this.ButtonUpT.Text = "温度增加";
            this.ButtonUpT.UseVisualStyleBackColor = false;
            this.ButtonUpT.Click += new System.EventHandler(this.ButtonUpT_Click);
            // 
            // ButtonLowT
            // 
            this.ButtonLowT.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLowT.Enabled = false;
            this.ButtonLowT.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLowT.Location = new System.Drawing.Point(66, 267);
            this.ButtonLowT.Name = "ButtonLowT";
            this.ButtonLowT.Size = new System.Drawing.Size(100, 25);
            this.ButtonLowT.TabIndex = 5;
            this.ButtonLowT.Text = "温度降低";
            this.ButtonLowT.UseVisualStyleBackColor = false;
            this.ButtonLowT.Click += new System.EventHandler(this.ButtonLowT_Click);
            // 
            // ButtonStartTrans
            // 
            this.ButtonStartTrans.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStartTrans.Font = new System.Drawing.Font("宋体", 12F);
            this.ButtonStartTrans.Location = new System.Drawing.Point(212, 207);
            this.ButtonStartTrans.Name = "ButtonStartTrans";
            this.ButtonStartTrans.Size = new System.Drawing.Size(100, 25);
            this.ButtonStartTrans.TabIndex = 6;
            this.ButtonStartTrans.Text = "开始通信";
            this.ButtonStartTrans.UseVisualStyleBackColor = false;
            this.ButtonStartTrans.Click += new System.EventHandler(this.ButtonStartTrans_Click);
            // 
            // ButtonEndTrans
            // 
            this.ButtonEndTrans.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEndTrans.Enabled = false;
            this.ButtonEndTrans.Font = new System.Drawing.Font("宋体", 12F);
            this.ButtonEndTrans.Location = new System.Drawing.Point(212, 267);
            this.ButtonEndTrans.Name = "ButtonEndTrans";
            this.ButtonEndTrans.Size = new System.Drawing.Size(100, 25);
            this.ButtonEndTrans.TabIndex = 7;
            this.ButtonEndTrans.Text = "停止通信";
            this.ButtonEndTrans.UseVisualStyleBackColor = false;
            this.ButtonEndTrans.Click += new System.EventHandler(this.ButtonEndTrans_Click);
            // 
            // TimerGetT
            // 
            this.TimerGetT.Interval = 500;
            this.TimerGetT.Tick += new System.EventHandler(this.TimerGetT_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.ButtonEndTrans);
            this.Controls.Add(this.ButtonStartTrans);
            this.Controls.Add(this.ButtonLowT);
            this.Controls.Add(this.ButtonUpT);
            this.Controls.Add(this.LabelSetT);
            this.Controls.Add(this.LabelCurrentT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温度控制";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelCurrentT;
        private System.Windows.Forms.Label LabelSetT;
        private System.Windows.Forms.Button ButtonUpT;
        private System.Windows.Forms.Button ButtonLowT;
        private System.Windows.Forms.Button ButtonStartTrans;
        private System.Windows.Forms.Button ButtonEndTrans;
        private System.Windows.Forms.Timer TimerGetT;
    }
}

