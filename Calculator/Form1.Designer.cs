namespace Calculator
{
    partial class Form1
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
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            ModuloBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            MinusPlusBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ClearBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 20F);
            TxtBox.Location = new Point(13, 26);
            TxtBox.Margin = new Padding(4);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(631, 61);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.TextChanged += TxtBox_TextChanged;
            // 
            // SevenBtn
            // 
            SevenBtn.Location = new Point(4, 102);
            SevenBtn.Margin = new Padding(4);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(127, 104);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Location = new Point(6, 217);
            FourBtn.Margin = new Padding(4);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(127, 105);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Location = new Point(4, 330);
            OneBtn.Margin = new Padding(4);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(127, 105);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Location = new Point(4, 439);
            ZeroBtn.Margin = new Padding(4);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(127, 105);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Location = new Point(133, 438);
            DotBtn.Margin = new Padding(4);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(127, 105);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Location = new Point(133, 330);
            TwoBtn.Margin = new Padding(4);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(127, 105);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Location = new Point(133, 217);
            FiveBtn.Margin = new Padding(4);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(127, 105);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Location = new Point(132, 104);
            EightBtn.Margin = new Padding(4);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(127, 105);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Location = new Point(261, 439);
            EqualBtn.Margin = new Padding(4);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(127, 105);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Location = new Point(261, 329);
            ThreeBtn.Margin = new Padding(4);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(127, 105);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Location = new Point(261, 217);
            SixBtn.Margin = new Padding(4);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(127, 105);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Location = new Point(260, 104);
            NineBtn.Margin = new Padding(4);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(127, 105);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // ModuloBtn
            // 
            ModuloBtn.Location = new Point(524, 442);
            ModuloBtn.Margin = new Padding(4);
            ModuloBtn.Name = "ModuloBtn";
            ModuloBtn.Size = new Size(120, 105);
            ModuloBtn.TabIndex = 20;
            ModuloBtn.Text = "%";
            ModuloBtn.UseVisualStyleBackColor = true;
            ModuloBtn.Click += ModuloBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Location = new Point(524, 329);
            MultiplyBtn.Margin = new Padding(4);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(120, 105);
            MultiplyBtn.TabIndex = 19;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Location = new Point(524, 217);
            PlusBtn.Margin = new Padding(4);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(120, 105);
            PlusBtn.TabIndex = 18;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MinusPlusBtn
            // 
            MinusPlusBtn.Location = new Point(402, 442);
            MinusPlusBtn.Margin = new Padding(4);
            MinusPlusBtn.Name = "MinusPlusBtn";
            MinusPlusBtn.Size = new Size(120, 105);
            MinusPlusBtn.TabIndex = 16;
            MinusPlusBtn.Text = "-/+";
            MinusPlusBtn.UseVisualStyleBackColor = true;
            MinusPlusBtn.Click += MinusPlusBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Location = new Point(402, 329);
            DivideBtn.Margin = new Padding(4);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(120, 105);
            DivideBtn.TabIndex = 15;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Location = new Point(402, 217);
            MinusBtn.Margin = new Padding(4);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(120, 105);
            MinusBtn.TabIndex = 14;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(402, 102);
            ClearBtn.Margin = new Padding(4);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(242, 104);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 565);
            Controls.Add(ModuloBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(MinusPlusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button ModuloBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button MinusPlusBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ClearBtn;
    }
}
