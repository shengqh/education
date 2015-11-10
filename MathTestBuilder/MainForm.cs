using Novacode;
using RCPA.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTestBuilder
{
  public partial class MainForm : ComponentUI
  {
    private RcpaDirectoryField targetDirectory;

    public MainForm()
    {
      InitializeComponent();

      this.targetDirectory = new RcpaDirectoryField(btnTarget, txtTargetDirectory, "TargetDirectory", "Target", true);

      AddComponent(this.targetDirectory);

      LoadOption();

      if (!Directory.Exists(this.targetDirectory.FullName))
      {
        this.targetDirectory.FullName = AppDomain.CurrentDomain.BaseDirectory;
      }

      this.Text = MyAssembly.Description + ": v" + MyAssembly.Version;
    }

    private void btnLevel1_Click(object sender, EventArgs e)
    {
      var allvalues = new Level1Builder().Build();
      string fileName = Path.Combine(this.targetDirectory.FullName, "level1.doc");
      new ProblemWordWriter(7, 1, 22, 4, allvalues.Count, 3).WriteToFile(fileName, allvalues);
      Process.Start("WINWORD.EXE", fileName);
    }

    private void btnLevel2_Click(object sender, EventArgs e)
    {
      var allvalues = new Level2Builder().Build();
      string fileName = Path.Combine(this.targetDirectory.FullName, "level2.doc");
      new ProblemWordWriter(6, 2, 22, 4, 75, 3).WriteToFile(fileName, allvalues);
      Process.Start("WINWORD.EXE", fileName);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      SaveOption();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
