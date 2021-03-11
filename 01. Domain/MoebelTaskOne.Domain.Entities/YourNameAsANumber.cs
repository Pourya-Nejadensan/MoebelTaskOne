using System;

namespace MoebelTaskOne.Domain.Entities
{
    public class YourNameAsANumber
    {
        private string InputString { get; set; }
        private int SumString { get; set; } = 0;

        public YourNameAsANumber(string inputString)
        {
            this.InputString = inputString.ToUpper();
        }

        public int CalcSumOfInputString()
        {
            for (int indexOfCharacterOfString = 0; indexOfCharacterOfString < InputString.Length; indexOfCharacterOfString++)
            {
                SumString = CompareInputString(indexOfCharacterOfString);
            }
            return SumString;
        }

        private int CompareInputString(int indexOfCharacterOfString)
        {
            foreach (EnumNumberMapper item in Enum.GetValues(typeof(EnumNumberMapper)))
            {
                SumString += CheckCondition(indexOfCharacterOfString, item);
            }
            return SumString;
        }

        private int CheckCondition(int indexOfCharacterOfString, EnumNumberMapper item)
        {
            if (item.ToString() == InputString[indexOfCharacterOfString].ToString())
            {
                return (int)item;
            }
            return 0;
        }
    }
}
