using System;
using System.Collections.Generic;

namespace Calculator
{
class Calc {
  public static List<Token> Calculator(string source) {
     List<Token> tokens = new List<Token>();
     string buf = "";
     char c;
     int i = 0;

     for (i = 0; i < source.Length; i++) {
         c = source[i];
        if (Char.IsWhiteSpace(c)) {
            continue;
        };

        switch (c) {
          case '+':
          case '*':
          case '-':
          case '/':
          tokens.Add(c.ToString);
          continue;
        }

        if (Char.IsNumber(c)) {
            buf += c;
            c = source[i++];
        };
        i--;
        tokens.Add(Integer.Parse(buf));
     }

     int result = 0;
     char op = null;
     char c = "";

     for (i = 0; i < tokens.Length; i++) {
         c = tokens[i];

         switch (c) {
          case '+':
          case '*':
          case '-':
          case '/':
          op = c;
          continue;
        }

        switch (op) {
          case '+': result += c;
          break;
          case '*': result *= c;
          break;
          case '-': result -= c;
          break;
          case '/': result /= c;
          break;
          default: result = c;
          break;
        }
     }
     Console.Write(result);
     return result;
  }
}
