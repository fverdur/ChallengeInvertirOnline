using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.Classes
{
    public class Textos
    {
        #region propiedades

        private IDictionary<string, IDictionary<string, string>> textos { get; set; }

        #endregion propiedades

        public Textos()
        {
            textos = new Dictionary<string, IDictionary<string, string>>();
        }

        public void SetTexto(string idioma, string clave, string valor)
        {
            IDictionary<string, string> lista;
            if (textos.Keys.Any(k => k == idioma))
            {
                lista = textos[idioma];
            }
            else
            {
                lista = new Dictionary<string, string>();
                textos[idioma] = lista;
            }
            lista[clave] = valor;
        }

        public string GetTexto(string idioma, string clave)
        {
            return textos[idioma][clave];
        }
    }
}