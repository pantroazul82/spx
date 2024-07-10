
using System;
using System.Collections.Generic;
using System.Text;

namespace SPXUtilidades
{
   public class clsFormato
    {
        /// <summary>
        /// Cambio los puntos y las comas por el separador decimal configurado en el equipo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static void formatoDecimal(object objTextBox) 
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)objTextBox;
            textBox.Text = textBox.Text.Replace(".", ",").Replace(",", System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
            textBox.FindForm().SelectNextControl(textBox, true, true, true, true);
        }

        /// <summary>
        /// Cambio los puntos y las comas por el separador decimal configurado en el equipo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static void formatoDinero(System.Windows.Forms.TextBox  txt,bool completarDecimal)
        {
            //miramos cual fue el ultimo caracter
            string texto = txt.Text;
            if(texto.Length <= 0) return ;
            bool tieneDecimales = false;
            bool negativo=false;
            char[] arr = texto.ToCharArray();
            string pentera="";
            string pdecimal ="";
            int numeros = 0;
            int dec=0;
            if(arr[0]=='-')negativo=true;
            if(texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)>=0)tieneDecimales=true;

            if (tieneDecimales)
            {
                pentera = texto.Substring(0, texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator));
                pdecimal = texto.Substring(texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)+1,
                    texto.Length - (texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)+1 )
                    );
            }else {
                pentera = texto;
            }
            
            arr= pdecimal.ToCharArray();
            pdecimal="";
            for(int k=0;k<arr.Length;k++)
            {
                if(char.IsDigit(arr[k]))
                pdecimal+=arr[k].ToString();
            }
            arr= pentera.ToCharArray();
            pentera="";
            for(int k=arr.Length-1;k>=0;k--)
            {
                if (char.IsDigit(arr[k]))
                {
                    if (numeros == 3)
                    {
                        pentera = arr[k].ToString() + System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyGroupSeparator + pentera;
                        numeros = 1;
                    }
                    else {
                        pentera = arr[k].ToString() +pentera;
                        numeros++;
                    }
                }
            }
            
            if(negativo)
            {
                texto = "-$";
            }else{
                texto = "$";
            }
            //
            if (tieneDecimales)
            {
                int.TryParse(pdecimal, out dec);
                if (pentera.Length == 0) {
                    if (completarDecimal)
                    {
                        texto = texto + "0" +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + dec.ToString();
                    }
                    else {
                        texto = texto + "0" +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + pdecimal;
                    }
                }
                else
                {
                    if (completarDecimal)
                    {
                        texto = texto + pentera +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + dec.ToString();
                    }
                    else {
                        texto = texto + pentera +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + pdecimal;
                    }
                }
            }
            else
            {
                    texto = texto + pentera;
            }
        

            txt.Text = texto;
            txt.SelectionStart = txt.Text.Length;




        }

       /// <summary>
       /// De una cadena con formato numerico retorna el valor para guardarlo en una variable decimal
       /// </summary>
       /// <param name="texto"></param>
       /// <returns></returns>
        public static decimal formatoDineroToDecimal(string txt)
        { 
            //miramos cual fue el ultimo caracter
            string texto = txt;
            if(texto.Length <= 0) return 0;
            bool tieneDecimales = false;
            bool negativo=false;
            char[] arr = texto.ToCharArray();
            string pentera="";
            string pdecimal ="";
            int dec=0;
            if(arr[0]=='-')negativo=true;
            if(texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)>=0)tieneDecimales=true;

            if (tieneDecimales)
            {
                pentera = texto.Substring(0, texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator));
                pdecimal = texto.Substring(texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)+1,
                    texto.Length - (texto.IndexOf(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)+1 )
                    );
            }else {
                pentera = texto;
            }
            
            arr= pdecimal.ToCharArray();
            pdecimal="";
            for(int k=0;k<arr.Length;k++)
            {
                if(char.IsDigit(arr[k]))
                pdecimal+=arr[k].ToString();
            }
            arr= pentera.ToCharArray();
            pentera="";
            for(int k=arr.Length-1;k>=0;k--)
            {
                if (char.IsDigit(arr[k]))
                {
                    pentera = arr[k].ToString() +pentera;
                }
            }

            if (negativo)
            {
                texto = "-";
            }
            else {
                texto = "";
            }
            //
            if (tieneDecimales)
            {
                int.TryParse(pdecimal, out dec);
                if (pentera.Length == 0) {
                        texto = texto + "0" +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + dec.ToString();
                }
                else
                {
                   texto = texto + pentera +
                            System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator
                            + dec.ToString();
                }
            }
            else
            {
                    texto = texto + pentera;
            }

            decimal res = 0;
            decimal.TryParse(texto, out res);
            return res;
        }

       public static bool formatoEmailValido(string direccionEmail) 
       {
           string formato=@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
           return System.Text.RegularExpressions.Regex.IsMatch(direccionEmail,formato);
    // Return true if strIn is in valid e-mail format.
        
       }
    }
}
