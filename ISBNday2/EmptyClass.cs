using System;
namespace ISBNday2
{
    public class EmptyClass
    {
        public static bool VerifyISBN(int[] number)
        {
            int multiplicacion = 0;
            int suma = 0;

            if (number.Length == 10)
            {
                int position = 10;

                for (int i = 0; i < number.Length; i++)
                {
                    multiplicacion = number[i] * position;
                    suma = suma + multiplicacion;
                    position--;
                    multiplicacion = 0;
                }
                if(suma % 11 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(number.Length == 13)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        multiplicacion = number[i] * 3;
                    }
                    else
                    {
                        multiplicacion = number[i] * 1;
                    }
                    suma += multiplicacion;
                    multiplicacion = 0;
                }
                if(suma % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
