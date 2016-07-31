using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class ProblemWordRowColWriter
  {
    private int rowCount;
    private int colCount;
    private int maxDigits;
    private Double fontSize;
    private int spaceLinesBetweenItem;
    private int spaceBetweenProblem;
    private bool addPageBreak;

    public ProblemWordRowColWriter(int colCount, int rowCount, int maxDigits, double fontSize, int spaceLinesBetweenItem, int spaceBetweenProblem, bool addPageBreak)
    {
      this.colCount = colCount;
      this.rowCount = rowCount;
      this.maxDigits = maxDigits;
      this.fontSize = fontSize;
      this.spaceLinesBetweenItem = spaceLinesBetweenItem;
      this.spaceBetweenProblem = spaceBetweenProblem;
      this.addPageBreak = addPageBreak;
    }

    public void WriteToFile(string fileName, List<Problem> source, int numberOfPage)
    {
      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Consolas");
      var rand = new Random(DateTime.Now.Millisecond);
      var gap = new string(' ', spaceBetweenProblem - 1);

      var totalCount = colCount * rowCount * numberOfPage;

      List<Problem> allItems = new List<Problem>();
      while (allItems.Count < totalCount)
      {
        var problems = source.ToArray();
        Utils.Shuffle(problems);
        allItems.AddRange(problems);
      }

      Paragraph lastLine = null;
      for (int page = 0; page < numberOfPage; page++)
      {
        var from = colCount * rowCount * page;

        for (int row = 0; row < rowCount; row++)
        {
          var line1 = doc.InsertParagraph();
          lastLine = doc.InsertParagraph();
          for (int col = 0; col < colCount; col++)
          {
            line1.Append(string.Format("{0} ", allItems[from].LeftNumber.ToString().PadLeft(maxDigits + 1, ' '))).Font(font).FontSize(fontSize).Append(gap).Font(font).FontSize(fontSize);
            lastLine.Append(string.Format("{0}{1} ", allItems[from].Sign, allItems[from].RightNumber.ToString().PadLeft(maxDigits, ' '))).Font(font).FontSize(fontSize).UnderlineStyle(UnderlineStyle.thick).Append(gap).Font(font).FontSize(fontSize);
            from++;
          }

          if (row != rowCount - 1)
          {
            for (int i = 0; i < spaceLinesBetweenItem; i++)
            {
              lastLine = doc.InsertParagraph();
            }
          }
        }

        if (page != numberOfPage - 1 && addPageBreak)
        {
          lastLine.InsertPageBreakAfterSelf();
        }
      }
      doc.Save();
    }
  }
}
