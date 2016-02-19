using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
namespace NumToWordNS.Objects
{
  public class NumToWord
  {
    private long _num;
    private string[] _upToTwenty;
    private string[] _tensPlace;

    public NumToWord(long num)
    {
      _num = num;
      _upToTwenty = new string[21] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
      _tensPlace = new string[8] {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
    }

    private List<string> _output;
    public string ChangeToWord()
    {
      long num = _num;
      _output = new List<string>(){};
      Dictionary<string,long> placesToCheck = new Dictionary<string,long>(){};
      placesToCheck.Add("quintillion", 1000000000000000000);
      placesToCheck.Add("quadrillion", 1000000000000000);
      placesToCheck.Add("trillion",    1000000000000);
      placesToCheck.Add("billion",     1000000000);
      placesToCheck.Add("million",     1000000);
      placesToCheck.Add("thousand",    1000);
      foreach(var item in placesToCheck)
      {
        num = AboveThousand(num, item.Value, item.Key);
      }
      if(num > 0 && num < 1000)
        _output.Add(LessThanThousand(num));
      return string.Join(" ", _output.ToArray());
    }
    public long AboveThousand(long num, long place, string name)
    {
      if( num >= place )
      {
        _output.Add(LessThanThousand((num - num % place) / place) + " " + name);
        num = num - (num - (num % place));
        // Console.WriteLine("Millions, Num Value: " + num);
      }
      return num;
    }

    public string LessThanThousand(long num)
    {
      List<string> output = new List<string>(){};
      if( num >= 100 && num < 1000)
      {
        long hundreds = (num - (num % 100)) / 100; //has to equal num + 00
        output.Add(_upToTwenty[hundreds] + " hundred");
        num = num - (hundreds * 100);
        // Console.WriteLine("Hundreds, Num Value: " + num);
      }
      if( num > 20 && num < 100 )
      {
        long tens = (num - (num % 10)) / 10 - 2;
        output.Add(_tensPlace[tens]);
        num = num - (num - (num % 10));
        // Console.WriteLine("Tens, Num Value: " + num);
      }
      if(num > 0)
      {
        output.Add(_upToTwenty[num]);
      }

      // Console.WriteLine(string.Join(" ", output.ToArray()).Trim());
     return string.Join(" ", output.ToArray()).Trim();
    }

  } // end class
} // end namespace
