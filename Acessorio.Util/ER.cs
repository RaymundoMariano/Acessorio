namespace Acessorio.Util
{
    public static class ER
    {
        #region Inteiro
        /// <summary>
        /// Inteiro
        /// </summary>
        public static string Inteiro
        {
            get { return @"^\d+$"; }
        }
        #endregion

        #region Email
        /// <summary>
        /// Email
        /// </summary>
        public static string Email
        {
            get
            {
                return @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))"
                     + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            }
        }
        #endregion

        #region IP
        /// <summary>
        /// IP
        /// </summary>
        public static string IP
        {
            get { return @"^\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b$"; }
        }
        #endregion

        #region Data_DD_MM_AAAA
        /// <summary>
        /// Data_DD/MM/AAAA
        /// </summary>
        public static string Data_DD_MM_AAAA
        {
            get { return @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$"; }
        }
        #endregion

        #region Telefone
        /// <summary>
        /// Telefone
        /// </summary>
        public static string Telefone
        {
            get { return @"^[0-9]{2}-[0-9]{4}-[0-9]{4}$"; }
        }
        #endregion

        #region CPF
        /// <summary>
        /// CPF
        /// </summary>
        public static string CPF
        {
            get { return @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$"; }
        }
        #endregion

        #region CNPJ
        /// <summary>
        /// CNPJ
        /// </summary>
        public static string CNPJ
        {
            get { return @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$"; }
        }
        #endregion

        #region CEP
        /// <summary>
        /// CEP
        /// </summary>
        public static string CEP
        {
            get { return @"^\d{5}\-?\d{3}$"; }
        }
        #endregion

        #region URL
        /// <summary>
        /// URL
        /// </summary>
        public static string URL
        {
            get { return @"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$"; }
        }
        #endregion

        #region Nome
        /// <summary>
        /// Nome
        /// </summary>
        public static string Nome
        {
            get { return @"^[aA-zZ]+((\s[aA-zZ]+)+)?$"; }
        }
        #endregion
    }
}
