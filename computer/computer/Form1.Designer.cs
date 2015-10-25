namespace computer
{
    partial class Form1
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
            this.Name1 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Percent = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.BtnNmb7 = new System.Windows.Forms.Button();
            this.BtnNmb9 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.BtnNmb3 = new System.Windows.Forms.Button();
            this.Miuns = new System.Windows.Forms.Button();
            this.BtnNmb6 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.BtnNmb0 = new System.Windows.Forms.Button();
            this.OppNmb = new System.Windows.Forms.Button();
            this.BtnNmb5 = new System.Windows.Forms.Button();
            this.BtnNmb8 = new System.Windows.Forms.Button();
            this.ReturnZero = new System.Windows.Forms.Button();
            this.BtnNmb2 = new System.Windows.Forms.Button();
            this.BtnNmb1 = new System.Windows.Forms.Button();
            this.BtnNmb4 = new System.Windows.Forms.Button();
            this.Recip = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.ReLoad = new System.Windows.Forms.Button();
            this.Equel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(12, 9);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(95, 15);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Me Computer";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(27, 52);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(360, 65);
            this.Output.TabIndex = 1;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(27, 178);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(90, 60);
            this.Percent.TabIndex = 2;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(207, 508);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(90, 60);
            this.Dot.TabIndex = 3;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(117, 178);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(90, 60);
            this.Root.TabIndex = 4;
            this.Root.Text = "√";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // BtnNmb7
            // 
            this.BtnNmb7.Location = new System.Drawing.Point(27, 310);
            this.BtnNmb7.Name = "BtnNmb7";
            this.BtnNmb7.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb7.TabIndex = 5;
            this.BtnNmb7.Text = "7";
            this.BtnNmb7.UseVisualStyleBackColor = true;
            this.BtnNmb7.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnNmb9
            // 
            this.BtnNmb9.Location = new System.Drawing.Point(207, 310);
            this.BtnNmb9.Name = "BtnNmb9";
            this.BtnNmb9.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb9.TabIndex = 6;
            this.BtnNmb9.Text = "9";
            this.BtnNmb9.UseVisualStyleBackColor = true;
            this.BtnNmb9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(297, 442);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(90, 60);
            this.Plus.TabIndex = 7;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // BtnNmb3
            // 
            this.BtnNmb3.Location = new System.Drawing.Point(207, 442);
            this.BtnNmb3.Name = "BtnNmb3";
            this.BtnNmb3.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb3.TabIndex = 8;
            this.BtnNmb3.Text = "3";
            this.BtnNmb3.UseVisualStyleBackColor = true;
            this.BtnNmb3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Miuns
            // 
            this.Miuns.Location = new System.Drawing.Point(297, 376);
            this.Miuns.Name = "Miuns";
            this.Miuns.Size = new System.Drawing.Size(90, 60);
            this.Miuns.TabIndex = 9;
            this.Miuns.Text = "-";
            this.Miuns.UseVisualStyleBackColor = true;
            this.Miuns.Click += new System.EventHandler(this.Miuns_Click);
            // 
            // BtnNmb6
            // 
            this.BtnNmb6.Location = new System.Drawing.Point(207, 376);
            this.BtnNmb6.Name = "BtnNmb6";
            this.BtnNmb6.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb6.TabIndex = 10;
            this.BtnNmb6.Text = "6";
            this.BtnNmb6.UseVisualStyleBackColor = true;
            this.BtnNmb6.Click += new System.EventHandler(this.Button_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(297, 310);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(90, 60);
            this.Multiply.TabIndex = 11;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Devide
            // 
            this.Devide.Location = new System.Drawing.Point(297, 244);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(90, 60);
            this.Devide.TabIndex = 12;
            this.Devide.Text = "÷";
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.Devide_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackSpace.Location = new System.Drawing.Point(207, 244);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(90, 60);
            this.BackSpace.TabIndex = 13;
            this.BackSpace.Text = "⇦";
            this.BackSpace.UseVisualStyleBackColor = true;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // BtnNmb0
            // 
            this.BtnNmb0.Location = new System.Drawing.Point(117, 508);
            this.BtnNmb0.Name = "BtnNmb0";
            this.BtnNmb0.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb0.TabIndex = 14;
            this.BtnNmb0.Text = "0";
            this.BtnNmb0.UseVisualStyleBackColor = true;
            this.BtnNmb0.Click += new System.EventHandler(this.Button_Click);
            // 
            // OppNmb
            // 
            this.OppNmb.Location = new System.Drawing.Point(27, 508);
            this.OppNmb.Name = "OppNmb";
            this.OppNmb.Size = new System.Drawing.Size(90, 60);
            this.OppNmb.TabIndex = 15;
            this.OppNmb.Text = "±";
            this.OppNmb.UseVisualStyleBackColor = true;
            this.OppNmb.Click += new System.EventHandler(this.OppNmb_Click);
            // 
            // BtnNmb5
            // 
            this.BtnNmb5.Location = new System.Drawing.Point(117, 376);
            this.BtnNmb5.Name = "BtnNmb5";
            this.BtnNmb5.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb5.TabIndex = 16;
            this.BtnNmb5.Text = "5";
            this.BtnNmb5.UseVisualStyleBackColor = true;
            this.BtnNmb5.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnNmb8
            // 
            this.BtnNmb8.Location = new System.Drawing.Point(117, 310);
            this.BtnNmb8.Name = "BtnNmb8";
            this.BtnNmb8.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb8.TabIndex = 17;
            this.BtnNmb8.Text = "8";
            this.BtnNmb8.UseVisualStyleBackColor = true;
            this.BtnNmb8.Click += new System.EventHandler(this.Button_Click);
            // 
            // ReturnZero
            // 
            this.ReturnZero.Location = new System.Drawing.Point(117, 244);
            this.ReturnZero.Name = "ReturnZero";
            this.ReturnZero.Size = new System.Drawing.Size(90, 60);
            this.ReturnZero.TabIndex = 18;
            this.ReturnZero.Text = "C";
            this.ReturnZero.UseVisualStyleBackColor = true;
            this.ReturnZero.Click += new System.EventHandler(this.ReturnZero_Click);
            // 
            // BtnNmb2
            // 
            this.BtnNmb2.Location = new System.Drawing.Point(117, 442);
            this.BtnNmb2.Name = "BtnNmb2";
            this.BtnNmb2.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb2.TabIndex = 19;
            this.BtnNmb2.Text = "2";
            this.BtnNmb2.UseVisualStyleBackColor = true;
            this.BtnNmb2.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnNmb1
            // 
            this.BtnNmb1.Location = new System.Drawing.Point(27, 442);
            this.BtnNmb1.Name = "BtnNmb1";
            this.BtnNmb1.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb1.TabIndex = 20;
            this.BtnNmb1.Text = "1";
            this.BtnNmb1.UseVisualStyleBackColor = true;
            this.BtnNmb1.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnNmb4
            // 
            this.BtnNmb4.Location = new System.Drawing.Point(27, 376);
            this.BtnNmb4.Name = "BtnNmb4";
            this.BtnNmb4.Size = new System.Drawing.Size(90, 60);
            this.BtnNmb4.TabIndex = 21;
            this.BtnNmb4.Text = "4";
            this.BtnNmb4.UseVisualStyleBackColor = true;
            this.BtnNmb4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Recip
            // 
            this.Recip.Location = new System.Drawing.Point(297, 178);
            this.Recip.Name = "Recip";
            this.Recip.Size = new System.Drawing.Size(90, 60);
            this.Recip.TabIndex = 22;
            this.Recip.Text = "1/x";
            this.Recip.UseVisualStyleBackColor = true;
            this.Recip.Click += new System.EventHandler(this.Recip_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(207, 178);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(90, 60);
            this.Square.TabIndex = 23;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // ReLoad
            // 
            this.ReLoad.Location = new System.Drawing.Point(27, 244);
            this.ReLoad.Name = "ReLoad";
            this.ReLoad.Size = new System.Drawing.Size(90, 60);
            this.ReLoad.TabIndex = 24;
            this.ReLoad.Text = "CE";
            this.ReLoad.UseVisualStyleBackColor = true;
            this.ReLoad.Click += new System.EventHandler(this.ReLoad_Click);
            // 
            // Equel
            // 
            this.Equel.Location = new System.Drawing.Point(297, 508);
            this.Equel.Name = "Equel";
            this.Equel.Size = new System.Drawing.Size(90, 60);
            this.Equel.TabIndex = 25;
            this.Equel.Text = "=";
            this.Equel.UseVisualStyleBackColor = true;
            this.Equel.Click += new System.EventHandler(this.Equel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 606);
            this.Controls.Add(this.Equel);
            this.Controls.Add(this.ReLoad);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Recip);
            this.Controls.Add(this.BtnNmb4);
            this.Controls.Add(this.BtnNmb1);
            this.Controls.Add(this.BtnNmb2);
            this.Controls.Add(this.ReturnZero);
            this.Controls.Add(this.BtnNmb8);
            this.Controls.Add(this.BtnNmb5);
            this.Controls.Add(this.OppNmb);
            this.Controls.Add(this.BtnNmb0);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.BtnNmb6);
            this.Controls.Add(this.Miuns);
            this.Controls.Add(this.BtnNmb3);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.BtnNmb9);
            this.Controls.Add(this.BtnNmb7);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Name1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button BtnNmb7;
        private System.Windows.Forms.Button BtnNmb9;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button BtnNmb3;
        private System.Windows.Forms.Button Miuns;
        private System.Windows.Forms.Button BtnNmb6;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button BtnNmb0;
        private System.Windows.Forms.Button OppNmb;
        private System.Windows.Forms.Button BtnNmb5;
        private System.Windows.Forms.Button BtnNmb8;
        private System.Windows.Forms.Button ReturnZero;
        private System.Windows.Forms.Button BtnNmb2;
        private System.Windows.Forms.Button BtnNmb1;
        private System.Windows.Forms.Button BtnNmb4;
        private System.Windows.Forms.Button Recip;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button ReLoad;
        private System.Windows.Forms.Button Equel;
    }
}

