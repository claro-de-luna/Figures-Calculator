namespace Figures
{
    partial class Figures
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
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.rbPerimeter = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.btCompute = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.gbDimension = new System.Windows.Forms.GroupBox();
            this.gbCalculation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.gbType.SuspendLayout();
            this.gbDimension.SuspendLayout();
            this.gbCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(35, 47);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(72, 20);
            this.rbSquare.TabIndex = 4;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(166, 47);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(90, 20);
            this.rbRectangle.TabIndex = 5;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(319, 47);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(78, 20);
            this.rbTriangle.TabIndex = 6;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(58, 40);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(59, 22);
            this.tbA.TabIndex = 8;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(181, 40);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(59, 22);
            this.tbB.TabIndex = 9;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(310, 40);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(59, 22);
            this.tbC.TabIndex = 10;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(38, 44);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(16, 16);
            this.lbA.TabIndex = 11;
            this.lbA.Text = "A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(163, 43);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(16, 16);
            this.lbB.TabIndex = 12;
            this.lbB.Text = "B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(294, 41);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(16, 16);
            this.lbC.TabIndex = 13;
            this.lbC.Text = "C";
            // 
            // rbPerimeter
            // 
            this.rbPerimeter.AutoSize = true;
            this.rbPerimeter.Location = new System.Drawing.Point(95, 43);
            this.rbPerimeter.Name = "rbPerimeter";
            this.rbPerimeter.Size = new System.Drawing.Size(86, 20);
            this.rbPerimeter.TabIndex = 15;
            this.rbPerimeter.TabStop = true;
            this.rbPerimeter.Text = "Perimeter";
            this.rbPerimeter.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(266, 43);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(57, 20);
            this.rbArea.TabIndex = 16;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // btCompute
            // 
            this.btCompute.Location = new System.Drawing.Point(65, 411);
            this.btCompute.Name = "btCompute";
            this.btCompute.Size = new System.Drawing.Size(93, 23);
            this.btCompute.TabIndex = 17;
            this.btCompute.Text = "COMPUTE";
            this.btCompute.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(352, 411);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 18;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(30, 457);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(460, 67);
            this.tbResult.TabIndex = 19;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbTriangle);
            this.gbType.Controls.Add(this.rbRectangle);
            this.gbType.Controls.Add(this.rbSquare);
            this.gbType.Location = new System.Drawing.Point(30, 24);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(460, 112);
            this.gbType.TabIndex = 20;
            this.gbType.TabStop = false;
            this.gbType.Text = "TYPE";
            // 
            // gbDimension
            // 
            this.gbDimension.Controls.Add(this.lbC);
            this.gbDimension.Controls.Add(this.lbB);
            this.gbDimension.Controls.Add(this.lbA);
            this.gbDimension.Controls.Add(this.tbC);
            this.gbDimension.Controls.Add(this.tbB);
            this.gbDimension.Controls.Add(this.tbA);
            this.gbDimension.Location = new System.Drawing.Point(30, 174);
            this.gbDimension.Name = "gbDimension";
            this.gbDimension.Size = new System.Drawing.Size(460, 94);
            this.gbDimension.TabIndex = 21;
            this.gbDimension.TabStop = false;
            this.gbDimension.Text = "DIMENSION";
            // 
            // gbCalculation
            // 
            this.gbCalculation.Controls.Add(this.rbArea);
            this.gbCalculation.Controls.Add(this.rbPerimeter);
            this.gbCalculation.Location = new System.Drawing.Point(30, 301);
            this.gbCalculation.Name = "gbCalculation";
            this.gbCalculation.Size = new System.Drawing.Size(460, 90);
            this.gbCalculation.TabIndex = 22;
            this.gbCalculation.TabStop = false;
            this.gbCalculation.Text = "CALCULATION";
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 536);
            this.Controls.Add(this.gbCalculation);
            this.Controls.Add(this.gbDimension);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCompute);
            this.Name = "Figures";
            this.Text = "Figures App";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbDimension.ResumeLayout(false);
            this.gbDimension.PerformLayout();
            this.gbCalculation.ResumeLayout(false);
            this.gbCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbTriangle;
        protected System.Windows.Forms.TextBox tbA;
        protected System.Windows.Forms.TextBox tbB;
        protected System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.RadioButton rbPerimeter;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Button btCompute;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbDimension;
        private System.Windows.Forms.GroupBox gbCalculation;
    }
}

