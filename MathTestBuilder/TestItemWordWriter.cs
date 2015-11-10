using Novacode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class TestItemWordWriter
  {
    private int countPerLine;
    private int maxDigits;
    private Double fontSize;
    private int spaceLinesBetweenItem;

    public TestItemWordWriter(int countPerLine, int maxDigits, double fontSize, int spaceLinesBetweenItem)
    {
      this.countPerLine = countPerLine;
      this.maxDigits = maxDigits;
      this.fontSize = fontSize;
      this.spaceLinesBetweenItem = spaceLinesBetweenItem;
    }

    public void WriteToFile(string fileName, List<TestItem> items)
    {
      DocX doc = DocX.Create(fileName);
      var font = new System.Drawing.FontFamily("Courier New");
      var rand = new Random(DateTime.Now.Millisecond);

      while (items.Count > 0)
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
            index = MathTestUtils.GetIndex(rand, items.Count - 1);
          }
          line1.Append(string.Format("{0}     ", items[index].LeftNumber.ToString().PadLeft(maxDigits + 1, ' '))).Font(font).FontSize(fontSize);
          line2.Append(string.Format("{0}{1} ", items[index].Sign, items[index].RightNumber.ToString().PadLeft(maxDigits, ' '))).Font(font).FontSize(fontSize).UnderlineStyle(UnderlineStyle.thick).Append("    ").Font(font).FontSize(fontSize);
          items.RemoveAt(index);
          if (items.Count == 0)
          {
            break;
          }
        }
        for (int i = 0; i < spaceLinesBetweenItem; i++)
        {
          doc.InsertParagraph();
        }
      }

      doc.Save();
    }
  }
}
