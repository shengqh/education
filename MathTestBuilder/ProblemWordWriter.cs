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
    private int countPerLine;
    private int maxDigits;
    private Double fontSize;
    private int spaceLinesBetweenItem;
    private int spaceBetweenProblem;
    private bool addPageBreak;
    private int totalCount;

    public ProblemWordWriter(int countPerLine, int maxDigits, double fontSize, int spaceLinesBetweenItem, int totalCount, int spaceBetweenProblem, bool addPageBreak)
    {
      this.countPerLine = countPerLine;
      this.maxDigits = maxDigits;
      this.fontSize = fontSize;
      this.spaceLinesBetweenItem = spaceLinesBetweenItem;
      this.totalCount = totalCount;
      this.spaceBetweenProblem = spaceBetweenProblem;
      this.addPageBreak = addPageBreak;
    }

    public void WriteToFile(string fileName, List<Problem> source, int numberOfTime = 1)
    {
      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Consolas");
      var rand = new Random(DateTime.Now.Millisecond);
      var gap = new string(' ', spaceBetweenProblem - 1);
      for (int iTime = 0; iTime < numberOfTime; iTime++)
      {
        var count = 0;
        Paragraph lastLine = null;
        var items = new List<Problem>(source);
        while (items.Count > 0 && count < totalCount)
        {
          var line1 = doc.InsertParagraph();
          lastLine = doc.InsertParagraph();
          for (int i = 0; i < countPerLine; i++)
          {
            int index;
            if (items.Count < 3)
            {
              index = items.Count - 1;
            }
            else
            {
              index = Utils.GetIndex(rand, items.Count - 1);
            }
            line1.Append(string.Format("{0} ", items[index].LeftNumber.ToString().PadLeft(maxDigits + 1, ' '))).Font(font).FontSize(fontSize).Append(gap).Font(font).FontSize(fontSize);
            lastLine.Append(string.Format("{0}{1} ", items[index].Sign, items[index].RightNumber.ToString().PadLeft(maxDigits, ' '))).Font(font).FontSize(fontSize).UnderlineStyle(UnderlineStyle.thick).Append(gap).Font(font).FontSize(fontSize);
            items.RemoveAt(index);
            count++;
            if (items.Count == 0)
            {
              break;
            }
          }

          if (count < totalCount)
          {
            for (int i = 0; i < spaceLinesBetweenItem; i++)
            {
              lastLine = doc.InsertParagraph();
            }
          }
        }

        if (iTime != numberOfTime - 1 && addPageBreak)
        {
          lastLine.InsertPageBreakAfterSelf();
        }
      }
      doc.Save();
    }
  }
}
