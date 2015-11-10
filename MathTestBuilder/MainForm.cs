using Novacode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTestBuilder
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnLevel1_Click(object sender, EventArgs e)
    {
      var allvalues = new TestLevel1Builder().Build();
      string fileName = @"D:\sqh\test\zero2five.docx";
      new TestItemWordWriter(7, 1, 19, 4).WriteToFile(fileName, allvalues);
      Process.Start("WINWORD.EXE", fileName);
    }

    private void btnLevel2_Click(object sender, EventArgs e)
    {
      var allvalues = new TestLevel2Builder().Build();
      string fileName = @"D:\sqh\test\five2ten.docx";
      new TestItemWordWriter(6, 2, 19, 3).WriteToFile(fileName, allvalues);
      Process.Start("WINWORD.EXE", fileName);
    }
  }
}
