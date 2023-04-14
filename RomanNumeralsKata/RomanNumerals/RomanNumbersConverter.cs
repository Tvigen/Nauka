
using System;

namespace RomanNumerals
{
    public class RomanNumbersConverter
    {
        public string Convert(int number)
        {
            string convertedNumber = "";
            int actualNumber = number;
            for (int i = 0; i < number; i++)
            {
                if (actualNumber >= 100)
                {
                    if (actualNumber == 100)
                    {
                        convertedNumber += "C";
                        return convertedNumber;
                    }
                    if (actualNumber > 100)
                    {
                        convertedNumber += "C";
                        actualNumber -= 100;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (actualNumber >= 50)
            {
                if (actualNumber == 50)
                {
                    convertedNumber += "L";
                    return convertedNumber;
                }
                else
                {
                    convertedNumber += "L";
                    actualNumber -= 50;
                }

            }
            for (int i = 0;i < number; i++)
            {
                if (actualNumber >= 10)
                {
                    if (actualNumber == 10)
                    {
                        convertedNumber += "X"; 
                        actualNumber -= 10;
                        break;
                    }
                    else if(actualNumber > 10)
                    {
                        convertedNumber += "X";
                        actualNumber -= 10;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (actualNumber < 10) 
            {
                if(actualNumber == 1)
                {
                    convertedNumber += "I";
                    return convertedNumber;
                }
                else if(actualNumber == 2)
                {
                    convertedNumber += "II";
                    return convertedNumber;
                }
                else if(actualNumber == 3)
                {
                    convertedNumber += "III";
                    return convertedNumber;
                }
                else if(actualNumber == 4)
                {
                    convertedNumber += "IV";
                    return convertedNumber;
                }
                else if(actualNumber == 5)
                {
                    convertedNumber += "V";
                    return convertedNumber;
                }
                else if(actualNumber == 6)
                {
                    convertedNumber += "VI";
                    return convertedNumber;
                }
                else if(actualNumber == 7)
                {
                    convertedNumber += "VII";
                    return convertedNumber;
                }
                else if(actualNumber == 8)
                {
                    convertedNumber += "VIII";
                    return convertedNumber;
                }
                else if(actualNumber == 9)
                {
                    convertedNumber += "IX";
                    return convertedNumber;
                }
                else
                {
                    return convertedNumber;
                }
            }
            return convertedNumber;
        }
    }
}