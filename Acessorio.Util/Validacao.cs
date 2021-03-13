using System;
using System.Text.RegularExpressions;

namespace Acessorio.Util
{
    public static class Validacao
    {
        #region CPFValido
        /// <summary>
        /// Verifica se o cpf é válido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool CPFValido(string cpf)
        {
            string valor = cpf.Replace(".", "").Replace("-", "");

            if (valor.Length != 11)
            {
                return false;
            }

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
            {
                if (valor[i] != valor[0])
                {
                    igual = false;
                }
            }

            if (igual || valor == "12345678909")
            {
                return false;
            }

            int[] numeros = new int[11];
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    numeros[i] = Convert.ToInt32(valor[i].ToString());
                }
            }
            catch
            {
                return false;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (10 - i) * numeros[i];
            }

            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                {
                    return false;
                }
            }
            else
            {
                if (numeros[9] != 11 - resultado)
                {
                    return false;
                }
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (11 - i) * numeros[i];
            }

            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                {
                    return false;
                }
            }
            else
            {
                if (numeros[10] != 11 - resultado)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region CNPJValido
        /// <summary>
        /// Verifica se o CNPJ é válido
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static bool CNPJValido(string cnpj)
        {
            string CNPJ = cnpj.Replace(".", "").Replace("/", "").Replace("-", "");
            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;

            ftmt = "6543298765432";
            digitos = new int[14];

            soma = new int[2];
            soma[0] = 0;
            soma[1] = 0;

            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;

            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = Convert.ToInt32(CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                    {
                        soma[0] += (digitos[nrDig] * Convert.ToInt32(ftmt.Substring(nrDig + 1, 1)));
                    }

                    if (nrDig <= 12)
                    {
                        soma[1] += (digitos[nrDig] * Convert.ToInt32(ftmt.Substring(nrDig, 1)));
                    }
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                    {
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    }
                    else
                    {
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                    }
                }

                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region CEPValido
        /// <summary>
        /// Verifica se o CEP é válido
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool CEPValido(object cep)
        {
            string CEP = cep.ToString().Replace("-", "").Trim();
            Match regex = Regex.Match(cep.ToString(), "^[0-9]{8}$");
            if (regex.Success)
                return true;
            else
                return false;
        }
        #endregion

        #region DataValida
        /// <summary>
        /// Verifica se o Data é válida
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool DataValida(object data)
        {
            Match regex = Regex.Match(data.ToString(), ER.Data_DD_MM_AAAA);
            if (regex.Success)
                return true;
            else
                return false;
        }
        #endregion

        #region EmailValido
        public static bool EmailValido(string email)
        {
            return Regex.IsMatch(email, ER.Email, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        #endregion
    }
}
