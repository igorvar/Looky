using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    static class FavoritesManagement
    {

        //static private KeyValuePair<string, string>[] favorites;

        static private List<KeyValuePair<string, string>> favorites;
        const string FAVORITE_FILE = "Favorites.xml";
        const string NODE_XPATH_FAVORITE_COLLECTION = "//Favorites";
        const string NODE_XPATH_FAVORITE_TAG = "Favorite";
        const string XML_ATTRIBUTE_LABEL = "Label";
        const string XML_ATTRIBUTE_PATH = "Folder";
        //const System.Xml.XPath.XPathExpression XPATH_FAVORITES = System.Xml.XPath.XPathExpression.Compile(NODE_XPATH_FAVORITE_COLLECTION + @"\" + NODE_XPATH_FAVORITE_TAG);
        
        static FavoritesManagement()
        {

            string xPathFfavorites = NODE_XPATH_FAVORITE_COLLECTION + @"/" + NODE_XPATH_FAVORITE_TAG;

            XmlDocument doc = new XmlDataDocument();
            try
            {
                doc.Load(FAVORITE_FILE);
            }
            catch (FileNotFoundException)
            {
                favorites = new List<KeyValuePair<string, string>>(0);
                return;
            }
            catch (XmlException)
            {
                favorites = new List<KeyValuePair<string, string>>(0);
                return;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //return;
            XmlNodeList nodes = doc.SelectNodes(xPathFfavorites);
            favorites = new List<KeyValuePair<string, string>>(nodes.Count);
            foreach (XmlNode n in nodes)
                favorites.Add
                    ( 
                    new KeyValuePair<string, string>
                        (
                            n.Attributes[XML_ATTRIBUTE_LABEL].Value,
                            n.Attributes[XML_ATTRIBUTE_PATH].Value
                        )
                    );



        }
        public static void Add(string Name, string Path)
        {
            favorites.Add(new KeyValuePair<string, string>(Name, Path));
            SaveFavorites();
        }
        public static void Remove(int Index)
        {
            favorites.RemoveAt(Index);
            SaveFavorites();
        }
        public static KeyValuePair<string, string>[] Favorites { get { return favorites.ToArray(); } }
        private static void SaveFavorites()
        {

            XmlElement elm = null;
            XmlDocument doc = new XmlDocument();
            doc = ReadXML();

            XmlElement favoriteCollectionParent = (XmlElement)doc.SelectSingleNode(NODE_XPATH_FAVORITE_COLLECTION);
            favoriteCollectionParent.RemoveAll();

            foreach (KeyValuePair<string, string> fav in favorites)
            {
                elm = doc.CreateElement(NODE_XPATH_FAVORITE_TAG);
                elm.SetAttribute(XML_ATTRIBUTE_LABEL, fav.Key);
                elm.SetAttribute(XML_ATTRIBUTE_PATH, fav.Value);
                favoriteCollectionParent.AppendChild(elm);
            }
            doc.Save(FAVORITE_FILE);
            
        }
        /// <summary>
        /// Function try read xml from file. If file not found - return empty xml by 
        /// struct from NODE_XPATH_FAVORITE_COLLECTION. If xml opened, by not have tag, described in
        /// NODE_XPATH_FAVORITE_COLLECTION - the to root element of document adding tag, described in
        /// NODE_XPATH_FAVORITE_COLLECTION 
        /// </summary>
        /// <returns></returns>
        private static XmlDocument ReadXML()
        {
            XmlDocument doc = new XmlDocument();


            if (!File.Exists(FAVORITE_FILE))
            {
                CreateFavoriteTree(doc);
                return doc;
            }

            doc.Load(FAVORITE_FILE);
            XmlNodeList favoriteCollections = doc.SelectNodes(NODE_XPATH_FAVORITE_COLLECTION);
            if (favoriteCollections.Count > 1) throw new XmlException("To many collections of favorites in file");
            if (favoriteCollections.Count == 1) return doc;
            CreateFavoriteTree(doc.DocumentElement);
            return doc;
        }
        private static void CreateFavoriteTree(XmlNode baseNode)
        {
            XmlElement elmnt = null;
            XmlElement elmntC = null;
            XmlDocument doc ;//= 
            if (baseNode.NodeType == XmlNodeType.Document) doc = (XmlDocument)baseNode;
            else if (baseNode.NodeType == XmlNodeType.Element) doc = baseNode.OwnerDocument;
            else throw new ArgumentException("baseNode must be or XmlDocument or XmlElement");
            MatchCollection mc = Regex.Matches(NODE_XPATH_FAVORITE_COLLECTION /*+@"\"+ NODE_XPATH_FAVORITE_TAG*/, @"\w+");
            for (int i = 0;/*mc.Count - 1;*/ i < mc.Count; i++)
            {
                elmntC = doc.CreateElement(mc[i].Value);
                
                if (elmnt == null) elmnt = elmntC;
                else elmnt.AppendChild(elmntC);
            }
            baseNode.AppendChild(elmnt);
        }
        
    }
}
