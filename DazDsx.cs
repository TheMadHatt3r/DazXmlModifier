using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DazXmlModifier
{
    class DazDsx
    {
        String filepathfull { get; set; }
        XDocument xfile;
        public String productName { get; set; }
        public String globalID { get; set; }
        public List<String> AssetNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepathfull"></param>
        public DazDsx(String filepathfull)
        {
            this.filepathfull = filepathfull;
            this.AssetNames = new List<String>();
            readXmlDoc();
        }

        /// <summary>
        /// 
        /// </summary>
        private void readXmlDoc()
        {
            //Load file and fill out basic variables.
            this.xfile = XDocument.Load(filepathfull);
            var xProductNode = xfile.Descendants().Where(n => n.Name == "Product").FirstOrDefault();
            if ((xProductNode != null) & (xProductNode.FirstAttribute != null))
                productName = xProductNode.FirstAttribute.Value;
            var xGlobalIDNode = xfile.Descendants().Where(n => n.Name == "GlobalID").FirstOrDefault();
            if ((xGlobalIDNode != null) & (xGlobalIDNode.FirstAttribute != null))
                globalID = xGlobalIDNode.FirstAttribute.Value;

            //This will loop through every asset to populate names.
            var xAssetsNode = xfile.Descendants().Where(n => n.Name == "Assets").FirstOrDefault();
            foreach (XElement xasset in xAssetsNode.Descendants("Asset"))
            {
                AssetNames.Add(xasset.FirstAttribute.Value);
            }
            
        }



        public Boolean ProcessAssets(String assetName, String content, String cat, String comp, Boolean compBase)
        {
            var xAssetsNode = xfile.Descendants().Where(n => n.Name == "Assets").FirstOrDefault();
            //This will loop through every asset.
            foreach (XElement xasset in xAssetsNode.Descendants("Asset"))
            {
                String localAssetName = xasset.FirstAttribute.Value;

                //Check if this is the asset we want to modify.
                if (assetName != localAssetName)
                    continue;

                Console.WriteLine(localAssetName);

                //====== Content Type ======
                //<ContentType VALUE="Follower/Wardrobe/Dress"/>
                if (content != "")
                {
                    xasset.Add(new XElement("ContentType", new XAttribute("VALUE", content)));
                }

                //====== Categories ======
                //<Categories>
                //    < Category VALUE = "/Default/Wardrobe/Dresses" />
                //</Categories>
                if (cat != "")
                {
                    XElement xcatagories = new XElement("Categories");
                    xcatagories.Add(new XElement("Category", new XAttribute("VALUE", cat)));
                    xasset.Add(xcatagories);
                }

                //====== Compatibilitybase  ======
                //<CompatibilityBase VALUE="/Belle Dress for Genesis 8 Females/Belle Dress"/>
                if (compBase)
                {
                    String baseName = localAssetName.Split('/').Last();
                    String info = "/" + productName + "/" + baseName.Substring(0, baseName.Length - 4);
                    xasset.Add(new XElement("CompatibilityBase", new XAttribute("VALUE", info)));
                }

                //====== Compatibility ======
                //<Compatibilities>
                //    < Compatibility VALUE = "/Genesis 8/Female" />
                //</Compatibilities>
                if ((comp != "") & (comp != "Null (do not add)"))
                {
                    XElement xcatagories = new XElement("Compatibilities");
                    xcatagories.Add(new XElement("Compatibility", new XAttribute("VALUE", cat)));
                    xasset.Add(xcatagories);
                }
            }
                return true;
        }

        /// <summary>
        /// DO NOT USE
        /// </summary>
        /// <returns></returns>
        public Boolean ProcessAssets(String content, String cat, String comp, Boolean compBase)
        {
            var xAssetsNode = xfile.Descendants().Where(n => n.Name == "Assets").FirstOrDefault();
            //This will loop through every asset.
            foreach (XElement xasset in xAssetsNode.Descendants("Asset"))
            {
                String assetName = xasset.FirstAttribute.Value;
                Console.WriteLine(assetName);
                //xasset.FirstAttribute.SetValue("TESTING");

                //====== Content Type ======
                //<ContentType VALUE="Follower/Wardrobe/Dress"/>
                if (content != "")
                {
                    xasset.Add(new XElement("ContentType", new XAttribute("VALUE", content)));
                }

                //====== Categories ======
                //<Categories>
                //    < Category VALUE = "/Default/Wardrobe/Dresses" />
                //</Categories>
                if (cat != "")
                {
                    XElement xcatagories = new XElement("Categories");
                    xcatagories.Add(new XElement("Category", new XAttribute("VALUE", cat)));
                    xasset.Add(xcatagories);
                }

                //====== Compatibilitybase  ======
                if (compBase)
                {
                    String baseName = assetName.Split('/').Last();
                    String info = "/" + productName + "/" + baseName.Substring(0, baseName.Length - 4);
                    xasset.Add(new XElement("CompatibilityBase", new XAttribute("VALUE", info)));
                }

                //====== Compatibility ======
                if (comp != "")
                {
                    XElement xcatagories = new XElement("Compatibilities");
                    xcatagories.Add(new XElement("Compatibility", new XAttribute("VALUE", cat)));
                    xasset.Add(xcatagories);
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean saveChanges()
        {
            this.xfile.Save(filepathfull);
            return true;
        }

    }
}
