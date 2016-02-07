namespace MathTestBuilder
{
  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnTarget = new System.Windows.Forms.Button();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfTest = new System.Windows.Forms.NumericUpDown();
            this.btnLevel4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLevel1
            // 
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.Location = new System.Drawing.Point(22, 148);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(146, 70);
            this.btnLevel1.TabIndex = 0;
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = true;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.Location = new System.Drawing.Point(186, 148);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(146, 70);
            this.btnLevel2.TabIndex = 1;
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = true;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnTarget
            // 
            this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarget.Location = new System.Drawing.Point(22, 26);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(310, 38);
            this.btnTarget.TabIndex = 2;
            this.btnTarget.Text = "button1";
            this.btnTarget.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(349, 30);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(771, 31);
            this.txtTargetDirectory.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(699, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 70);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.Location = new System.Drawing.Point(349, 148);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(146, 70);
            this.btnLevel3.TabIndex = 4;
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = true;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of test:";
            // 
            // numberOfTest
            // 
            this.numberOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTest.Location = new System.Drawing.Point(349, 78);
            this.numberOfTest.Name = "numberOfTest";
            this.numberOfTest.Size = new System.Drawing.Size(87, 31);
            this.numberOfTest.TabIndex = 6;
            this.numberOfTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLevel4
            // 
            this.btnLevel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel4.Location = new System.Drawing.Point(510, 148);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.Size = new System.Drawing.Size(146, 70);
            this.btnLevel4.TabIndex = 4;
            this.btnLevel4.Text = "Level 4";
            this.btnLevel4.UseVisualStyleBackColor = true;
            this.btnLevel4.Click += new System.EventHandler(this.btnLevel4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 242);
            this.Controls.Add(this.numberOfTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLevel4);
            this.Controls.Add(this.btnLevel3);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLevel2);
            this.Controls.Add(this.btnLevel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Math Test Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnLevel1;
    private System.Windows.Forms.Button btnLevel2;
    private System.Windows.Forms.Button btnTarget;
    private System.Windows.Forms.TextBox txtTargetDirectory;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnLevel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numberOfTest;
        private System.Windows.Forms.Button btnLevel4;
    }
}

