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
      this.btnLevel1 = new System.Windows.Forms.Button();
      this.btnLevel2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnLevel1
      // 
      this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLevel1.Location = new System.Drawing.Point(24, 26);
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
      this.btnLevel2.Location = new System.Drawing.Point(213, 26);
      this.btnLevel2.Name = "btnLevel2";
      this.btnLevel2.Size = new System.Drawing.Size(146, 70);
      this.btnLevel2.TabIndex = 1;
      this.btnLevel2.Text = "Level 2";
      this.btnLevel2.UseVisualStyleBackColor = true;
      this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(702, 124);
      this.Controls.Add(this.btnLevel2);
      this.Controls.Add(this.btnLevel1);
      this.Name = "MainForm";
      this.Text = "Math Test Builder";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLevel1;
    private System.Windows.Forms.Button btnLevel2;
  }
}

