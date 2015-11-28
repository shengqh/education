﻿using Novacode;
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
    private int totalCount;

    public ProblemWordWriter(int countPerLine, int maxDigits, double fontSize, int spaceLinesBetweenItem, int totalCount, int spaceBetweenProblem)
    {
      this.countPerLine = countPerLine;
      this.maxDigits = maxDigits;
      this.fontSize = fontSize;
      this.spaceLinesBetweenItem = spaceLinesBetweenItem;
      this.totalCount = totalCount;
      this.spaceBetweenProblem = spaceBetweenProblem;
    }

    public void WriteToFile(string fileName, List<Problem> items)
    {
      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Consolas");
      var rand = new Random(DateTime.Now.Millisecond);

      var count = 0;
      var gap = new string(' ', spaceBetweenProblem - 1);
      while (items.Count > 0 && count < totalCount)
      {
        var line1 = doc.InsertParagraph();
        var line2 = doc.InsertParagraph();
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
          line2.Append(string.Format("{0}{1} ", items[index].Sign, items[index].RightNumber.ToString().PadLeft(maxDigits, ' '))).Font(font).FontSize(fontSize).UnderlineStyle(UnderlineStyle.thick).Append(gap).Font(font).FontSize(fontSize);
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
            doc.InsertParagraph();
          }
        }
      }

      doc.Save();
    }
  }
}
