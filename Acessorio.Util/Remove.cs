namespace Acessorio.Util
{
    public static class Remove
    {
        #region Mascara
        /// <summary>
        /// Desformatar
        /// </summary>
        /// <param name="campo formatado"></param>
        /// <returns></returns>
        public static string Mascara(object campo)
        {
            if (campo is null || string.IsNullOrEmpty(campo.ToString())) return null;

            string str = campo.ToString().Replace(".", "").Replace("-", "").Replace("/", "");
            str = str.Replace("(", "").Replace(")", "");
            return str;
        }
        #endregion

        #region Acentos
        public static string Acentos(string input)
        {
            if (string.IsNullOrEmpty(input)) return null;

            byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(input);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
        #endregion
    }
}
