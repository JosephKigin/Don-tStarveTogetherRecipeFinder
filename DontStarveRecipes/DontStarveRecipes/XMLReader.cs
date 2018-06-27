using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DontStarveRecipes
{
    class XMLReader : Recipe
    {
        public XMLReader()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("");

            for(int i = 0; xmlDoc.ChildNodes.Count < i; i++)
            {
                XmlNode recipe = xmlDoc.SelectSingleNode("/Recipe" + (i + 1));

            }
        }
    }
}
