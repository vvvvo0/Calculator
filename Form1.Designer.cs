﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonAllClear = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(374, 23);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAllClear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSubtract, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 391);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(84, 91);
            this.ButtonSeven.TabIndex = 0;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = true;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonEight.Location = new System.Drawing.Point(93, 3);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(84, 91);
            this.ButtonEight.TabIndex = 1;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = true;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonNine.Location = new System.Drawing.Point(183, 3);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(84, 91);
            this.ButtonNine.TabIndex = 2;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = true;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonDivide.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDivide.ForeColor = System.Drawing.Color.Black;
            this.ButtonDivide.Location = new System.Drawing.Point(273, 3);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(84, 91);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "÷";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 100);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(84, 91);
            this.ButtonFour.TabIndex = 4;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = true;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFive.Location = new System.Drawing.Point(93, 100);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(84, 91);
            this.ButtonFive.TabIndex = 5;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = true;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSix.Location = new System.Drawing.Point(183, 100);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(84, 91);
            this.ButtonSix.TabIndex = 6;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = true;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonMultiply.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMultiply.Location = new System.Drawing.Point(273, 100);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(84, 91);
            this.ButtonMultiply.TabIndex = 7;
            this.ButtonMultiply.Text = "×";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 197);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(84, 91);
            this.ButtonOne.TabIndex = 8;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = true;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTwo.Location = new System.Drawing.Point(93, 197);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(84, 91);
            this.ButtonTwo.TabIndex = 9;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = true;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonThree.Location = new System.Drawing.Point(183, 197);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(84, 91);
            this.ButtonThree.TabIndex = 10;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = true;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSubtract.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSubtract.Location = new System.Drawing.Point(273, 197);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(84, 91);
            this.ButtonSubtract.TabIndex = 11;
            this.ButtonSubtract.Text = "－";
            this.ButtonSubtract.UseVisualStyleBackColor = false;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonAllClear
            // 
            this.ButtonAllClear.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonAllClear.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAllClear.Location = new System.Drawing.Point(3, 294);
            this.ButtonAllClear.Name = "ButtonAllClear";
            this.ButtonAllClear.Size = new System.Drawing.Size(84, 91);
            this.ButtonAllClear.TabIndex = 12;
            this.ButtonAllClear.Text = "AC";
            this.ButtonAllClear.UseVisualStyleBackColor = false;
            this.ButtonAllClear.Click += new System.EventHandler(this.ButtonAllClear_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonZero.Location = new System.Drawing.Point(93, 294);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(84, 91);
            this.ButtonZero.TabIndex = 13;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = true;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonPoint.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonPoint.Location = new System.Drawing.Point(183, 294);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(84, 91);
            this.ButtonPoint.TabIndex = 14;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = false;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonAdd.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAdd.Location = new System.Drawing.Point(273, 294);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(84, 91);
            this.ButtonAdd.TabIndex = 15;
            this.ButtonAdd.Text = "＋";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonResult
            // 
            this.ButtonResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonResult.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonResult.Location = new System.Drawing.Point(0, 428);
            this.ButtonResult.Name = "ButtonResult";
            this.ButtonResult.Size = new System.Drawing.Size(374, 85);
            this.ButtonResult.TabIndex = 14;
            this.ButtonResult.Text = "=";
            this.ButtonResult.UseVisualStyleBackColor = false;
            this.ButtonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 513);
            this.Controls.Add(this.ButtonResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button ButtonAllClear;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button ButtonResult;
    }
}

