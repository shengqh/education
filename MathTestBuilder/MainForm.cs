using RCPA.Gui;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MathTestBuilder
{
  public partial class MainForm : ComponentUI
  {
    private RcpaDirectoryField targetDirectory;

    [RcpaOption("NumberOfTest", RcpaOptionType.Int32)]
    private int repeatTime { get { return (int)numberOfTest.Value; } set { numberOfTest.Value = value; } }

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
      try
      {
        new ProblemWordWriter(7, 1, 22, 4, allvalues.Count, 3, true).WriteToFile(fileName, allvalues, (int)numberOfTest.Value);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Cannot write the problems to file {0}, make sure that file not exist or has been closed : {1}", fileName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      Process.Start("WINWORD.EXE", fileName);

    }

    private void btnLevel2_Click(object sender, EventArgs e)
    {
      var allvalues = new Level2Builder().Build();
      string fileName = Path.Combine(this.targetDirectory.FullName, "level2.doc");
      try
      {
        new ProblemWordWriter(9, 2, 16, 2, allvalues.Count, 3, true).WriteToFile(fileName, allvalues, (int)numberOfTest.Value);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Cannot write the problems to file {0}, make sure that file not exist or has been closed : {1}", fileName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
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

    private void btnLevel3_Click(object sender, EventArgs e)
    {
      var allvalues = new Level3Builder().Build();
      string fileName = Path.Combine(this.targetDirectory.FullName, "level3.doc");
      try
      {
        new ProblemWordWriter(10, 2, 14, 3, allvalues.Count, 3, true).WriteToFile(fileName, allvalues, (int)numberOfTest.Value);
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("Cannot write the problems to file {0}, make sure that file not exist or has been closed : {1}", fileName, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      Process.Start("WINWORD.EXE", fileName);
    }
  }
}
