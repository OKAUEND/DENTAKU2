namespace WindowsFormsApp1
{
    partial class CalcPlus4
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMultipl = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSubtrac = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.表示VToolStripMenuItem,
            this.編集EToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(297, 26);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.表示VToolStripMenuItem.Text = "メニュー(V)";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピーToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.編集EToolStripMenuItem.Text = "編集(E)";
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.コピーToolStripMenuItem.Text = "コピー";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.LightCyan;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(12, 41);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(269, 45);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(12, 89);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(104, 29);
            this.btnUndo.TabIndex = 2;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(122, 89);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(104, 29);
            this.btnRedo.TabIndex = 3;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(12, 124);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(104, 44);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(122, 124);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(49, 44);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(232, 124);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(49, 44);
            this.btnSquare.TabIndex = 7;
            this.btnSquare.Text = "√";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(177, 124);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(49, 44);
            this.BtnPlus.TabIndex = 6;
            this.BtnPlus.Text = "±";
            this.BtnPlus.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(177, 174);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(49, 44);
            this.btnDivision.TabIndex = 11;
            this.btnDivision.Tag = "Division";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.MouseCaptureChanged += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(122, 174);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(49, 44);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(67, 174);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(49, 44);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 174);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(49, 44);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnMultipl
            // 
            this.btnMultipl.Location = new System.Drawing.Point(177, 224);
            this.btnMultipl.Name = "btnMultipl";
            this.btnMultipl.Size = new System.Drawing.Size(49, 44);
            this.btnMultipl.TabIndex = 15;
            this.btnMultipl.Tag = "Multipl";
            this.btnMultipl.Text = "*";
            this.btnMultipl.UseVisualStyleBackColor = true;
            this.btnMultipl.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(122, 224);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(49, 44);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(67, 224);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(49, 44);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 224);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(49, 44);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnSubtrac
            // 
            this.btnSubtrac.Location = new System.Drawing.Point(177, 274);
            this.btnSubtrac.Name = "btnSubtrac";
            this.btnSubtrac.Size = new System.Drawing.Size(49, 44);
            this.btnSubtrac.TabIndex = 19;
            this.btnSubtrac.Tag = "Subtrac";
            this.btnSubtrac.Text = "-";
            this.btnSubtrac.UseVisualStyleBackColor = true;
            this.btnSubtrac.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(122, 274);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(49, 44);
            this.btnThree.TabIndex = 16;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(67, 274);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(49, 44);
            this.btnTwo.TabIndex = 18;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 274);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(49, 44);
            this.btnOne.TabIndex = 17;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(12, 324);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(104, 44);
            this.btnZero.TabIndex = 20;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.BtnFigure_Click);
            // 
            // btnComma
            // 
            this.btnComma.Location = new System.Drawing.Point(122, 324);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(49, 44);
            this.btnComma.TabIndex = 21;
            this.btnComma.Text = ".";
            this.btnComma.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(177, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(232, 224);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(49, 144);
            this.btnNum.TabIndex = 23;
            this.btnNum.Text = "=";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // CalcPlus4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 384);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSubtrac);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMultipl);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "CalcPlus4";
            this.Text = "ClaC#";
            this.Load += new System.EventHandler(this.CalcPlus4_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnMultipl;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSubtrac;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNum;
    }
}

