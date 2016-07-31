using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class ProblemWordWriter
  {
    //private int rowCount;
    private int colCount;
    private int maxDigits;
    private Double fontSize;
    private int spaceLinesBetweenItem;
    private int spaceBetweenProblem;
    private bool addPageBreak;
    private int totalCount;

    public ProblemWordWriter(int colCount, /*int rowCount,*/ int maxDigits, double fontSize, int spaceLinesBetweenItem, int totalCount, int spaceBetweenProblem, bool addPageBreak)
    {
      this.colCount = colCount;
      //this.rowCount = rowCount;
      this.maxDigits = maxDigits;
      this.fontSize = fontSize;
      this.spaceLinesBetweenItem = spaceLinesBetweenItem;
      this.totalCount = totalCount;
      this.spaceBetweenProblem = spaceBetweenProblem;
      this.addPageBreak = addPageBreak;
    }

    public void WriteToFile(string fileName, List<Problem> source, int numberOfTime = 1, int splitTo = 1)
    {
      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Consolas");
      var rand = new Random(DateTime.Now.Millisecond);
      var gap = new string(' ', spaceBetweenProblem - 1);
      var maxcount = (int)Math.Round(source.Count * 1.0 / splitTo);

      List<Problem[]> allItems = new List<Problem[]>();
      while (allItems.Count < numberOfTime)
      {
        var problems = source.ToArray();
        Utils.Shuffle(problems);
        var eachBin = problems.Length / splitTo;
        for (int index = 0; index < splitTo; index++)
        {
          var min = index * eachBin;
          var len = eachBin;
          if (index == splitTo - 1)
          {
            len = problems.Length - (splitTo - 1) * eachBin;
          }
          allItems.Add(problems.Skip(min).Take(len).ToArray());
        }
      }

      foreach(var items in allItems)
      {
        var count = 0;
        Paragraph lastLine = null;

        for(int pi = 0;pi < items.Length && pi < totalCount; pi += colCount)
        {
          var line1 = doc.InsertParagraph();
          lastLine = doc.InsertParagraph();
          for (int i = 0; i < colCount; i++)
          {
            int index = pi + i;
            if(index >= items.Length)
            {
              break;
            }
            line1.Append(string.Format("{0} ", items[index].LeftNumber.ToString().PadLeft(maxDigits + 1, ' '))).Font(font).FontSize(fontSize).Append(gap).Font(font).FontSize(fontSize);
            lastLine.Append(string.Format("{0}{1} ", items[index].Sign, items[index].RightNumber.ToString().PadLeft(maxDigits, ' '))).Font(font).FontSize(fontSize).UnderlineStyle(UnderlineStyle.thick).Append(gap).Font(font).FontSize(fontSize);
            count++;
          }

          if (count < totalCount)
          {
            for (int i = 0; i < spaceLinesBetweenItem; i++)
            {
              lastLine = doc.InsertParagraph();
            }
          }
        }

        if (items != allItems.Last() && addPageBreak)
        {
          lastLine.InsertPageBreakAfterSelf();
        }
      }
      doc.Save();
    }
  }
}
