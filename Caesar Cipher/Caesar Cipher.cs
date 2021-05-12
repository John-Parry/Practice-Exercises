using System;

namespace CaesarCipher
{
    class Program
    {
        const int ALPHABET_LENGTH = 26;
        const int MINIMUM_ASCII_LOWER_CASE_VALUE = 97;
        const int MINIMUM_ASCII_UPPER_CASE_VALUE = 65;

        static void Main()
        {
            //Variables
            string plainMessage = "";
            string encryptedMessage = "";
            int shift;

            //Recieve message to encrypt
            Console.Write("Please enter the message you would like to encrypt: ");
            plainMessage = Console.ReadLine();

            //Recieve number of spaces to shift the message by
            Console.Write("Please enter the number to shift the message by: ");
            shift = int.Parse(Console.ReadLine());


            //Itterate over each character, and shift it by the required ammount
            foreach (byte charDecimal in plainMessage)
            {    
                int shiftedCharDecimal; 

                //If the character is lowercase, shift it in the lowercase range
                if (charDecimal >= 97 && charDecimal <= 122) { shiftedCharDecimal = mod((charDecimal + shift - MINIMUM_ASCII_LOWER_CASE_VALUE), ALPHABET_LENGTH) + MINIMUM_ASCII_LOWER_CASE_VALUE;}
                //If the character is uppercase, shift it in the uppercase range
                else if (charDecimal >= 65 && charDecimal <= 90) { shiftedCharDecimal = mod((charDecimal + shift - MINIMUM_ASCII_UPPER_CASE_VALUE), ALPHABET_LENGTH) + MINIMUM_ASCII_UPPER_CASE_VALUE; }
                //Else, assume it's a symbol, number or space and just keep it as is
                else { shiftedCharDecimal = charDecimal; }

                //Add it to the shifted message
                encryptedMessage += Convert.ToChar(shiftedCharDecimal);
            }

            //Display the message and pause
            Console.WriteLine(encryptedMessage);
            Console.ReadKey();
        }

        //Microsoft devs be like "HURR DURR LETS FUCK UP THE MOD~ OPPERATOR!"
        static int mod(int n, int m) 
        {
            int r = n%m;
            return r<0 ? r+m : r;
        }
    }
}