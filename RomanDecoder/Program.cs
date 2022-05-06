using System;

namespace RomanDecoder
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public int RomanDecoder(string roman)
        {
            int result = 0;
            foreach (var letter in roman)
            {
                result += GetRomanNumber(letter);
            }
            if (roman.Contains("IV") || roman.Contains("IX")) result -= 2;
            if (roman.Contains("XL") || roman.Contains("XC")) result -= 20;
            if (roman.Contains("CD") || roman.Contains("CM")) result -= 200;

            return result;
        }

        private static int GetRomanNumber(char letter)
        {
            return letter switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Not A Roman Number"),
            };
        }
    }
}