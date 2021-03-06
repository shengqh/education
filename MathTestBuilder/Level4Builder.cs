﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class Level4Builder : IBuilder
  {
    public List<Problem> Build()
    {
      var digits = new[] { 2, 3, 4, 5, 6, 7, 8, 9 };
      var signs = new[] { "×", "÷" };
      var seed = DateTime.Now.Millisecond;
      var rand = new Random(seed);

      var data = new Dictionary<string, HashSet<Problem>>();
      data[signs[0]] = new HashSet<Problem>();
      data[signs[1]] = new HashSet<Problem>();
      var maxvalue = digits.Max() * digits.Max();
      var minvalue = 0;

      foreach (var digit1 in digits)
      {
        foreach (var digit2 in digits)
        {
          var sum = digit1 * digit2;
          if (sum <= maxvalue && sum >= minvalue)
          {
            data["×"].Add(new Problem(digit1, "×", digit2));
            data["×"].Add(new Problem(digit2, "×", digit1));
            data["÷"].Add(new Problem(sum, "÷", digit1));
            data["÷"].Add(new Problem(sum, "÷", digit2));
          }
        }
      }

      return (from v in data.Values
              from vv in v
              select vv).ToList();
    }
  }
}
