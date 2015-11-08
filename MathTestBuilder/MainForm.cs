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

    private static int GetIndex(Random rand, int maxValue)
    {
      var result = rand.Next(maxValue + 1);
      if (result == maxValue + 1)
      {
        result = maxValue;
      }
      return result;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //var digits = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      //string fileName = @"D:\sqh\test\zero2ten.docx";
      var digits = new[] { 0, 1, 2, 3, 4, 5 };
      string fileName = @"D:\sqh\test\zero2five.docx";
      var countPerLine = 7;

      var signs = new[] { '-', '+' };
      var seed = DateTime.Now.Millisecond;
      var rand = new Random(seed);

      Dictionary<char, List<Tuple<int, char, int>>> data = new Dictionary<char, List<Tuple<int, char, int>>>();
      data[signs[0]] = new List<Tuple<int, char, int>>();
      data[signs[1]] = new List<Tuple<int, char, int>>();
      var maxvalue = digits.Max();

      foreach (var digit1 in digits)
      {
        foreach (var digit2 in digits)
        {
          var sum = digit1 + digit2;
          if (sum <= maxvalue)
          {
            data['+'].Add(new Tuple<int, char, int>(digit1, '+', digit2));
          }

          var sub = digit1 - digit2;
          if (sub >= 0)
          {
            data['-'].Add(new Tuple<int, char, int>(digit1, '-', digit2));
          }
        }
      }

      var allvalues = (from v in data.Values
                       from vv in v
                       select vv).ToList();

      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Courier New");
      var fontsize = 19D;

      while (allvalues.Count > 0)
      {
        var line1 = doc.InsertParagraph();
        var line2 = doc.InsertParagraph();
        for (int i = 0; i < countPerLine; i++)
        {
          int index;
          if (allvalues.Count < 3)
          {
            index = allvalues.Count - 1;
          }
          else
          {
            index = GetIndex(rand, allvalues.Count - 1);
          }
          line1.Append(string.Format("{0}     ", allvalues[index].Item1.ToString().PadLeft(2, ' '))).Font(font).FontSize(fontsize);
          line2.Append(string.Format("{0}{1} ", allvalues[index].Item2, allvalues[index].Item3)).Font(font).FontSize(fontsize).UnderlineStyle(UnderlineStyle.thick).Append("    ").Font(font).FontSize(fontsize);
          allvalues.RemoveAt(index);
          if (allvalues.Count == 0)
          {
            break;
          }
        }
        doc.InsertParagraph();
        doc.InsertParagraph();
        doc.InsertParagraph();
        doc.InsertParagraph();
      }

      doc.Save();

      Process.Start("WINWORD.EXE", fileName);
    }
  }
}
