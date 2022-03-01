namespace Acessorio.Util
{
    public static class Formate
    {
        #region CGC
        /// <summary>
        /// Formatar cgc  
        /// </summary>
        /// <param name="cgc"></param>
        /// <returns></returns>
        public static string CGC(object cgc)
        {
            string str = cgc.ToString().PadLeft(14, '0');
            if (str == "00000000000000")
                return string.Empty;
            str = str.Substring(0, 2) + "." + str.Substring(2, 3) + "." + str.Substring(5, 3) + "/" + str.Substring(8, 4) + "-" + str.Substring(12, 2);
            return str;
        }
        #endregion

        #region CPF
        /// <summary>
        /// Formatar cpf  
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static string CPF(object cpf)
        {
            cpf = Remove.Mascara(cpf);

            string str = cpf.ToString().PadLeft(11, '0');
            if (str == "00000000000")
                return string.Empty;
            str = str.Substring(0, 3) + "." + str.Substring(3, 3) + "." + str.Substring(6, 3) + "-" + str.Substring(9, 2);
            return str;
        }
        #endregion

        #region CEP
        /// <summary>
        /// Formatar CEP  
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static string CEP(object cep)
        {
            cep = Remove.Mascara(cep);

            string str = cep.ToString().PadLeft(8, '0');
            if (str == "00000000")
                return string.Empty;
            str = str.Substring(0, 5) + "-" + str.Substring(5, 3);
            return str;
        }
        #endregion        
    }
}
