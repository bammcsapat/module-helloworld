/*
' Copyright (c) 2024 BAMM
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Bamm.Dnn.Dnn.Bamm.HelloWorld.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.Bamm.HelloWorld
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.Bamm.HelloWorldInfo> colDnn.Bamm.HelloWorlds = GetDnn.Bamm.HelloWorlds(ModuleID);
        //if (colDnn.Bamm.HelloWorlds.Count != 0)
        //{
        //    strXML += "<Dnn.Bamm.HelloWorlds>";

        //    foreach (Dnn.Bamm.HelloWorldInfo objDnn.Bamm.HelloWorld in colDnn.Bamm.HelloWorlds)
        //    {
        //        strXML += "<Dnn.Bamm.HelloWorld>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.Bamm.HelloWorld.Content) + "</content>";
        //        strXML += "</Dnn.Bamm.HelloWorld>";
        //    }
        //    strXML += "</Dnn.Bamm.HelloWorlds>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.Bamm.HelloWorlds = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.Bamm.HelloWorlds");
        //foreach (XmlNode xmlDnn.Bamm.HelloWorld in xmlDnn.Bamm.HelloWorlds.SelectNodes("Dnn.Bamm.HelloWorld"))
        //{
        //    Dnn.Bamm.HelloWorldInfo objDnn.Bamm.HelloWorld = new Dnn.Bamm.HelloWorldInfo();
        //    objDnn.Bamm.HelloWorld.ModuleId = ModuleID;
        //    objDnn.Bamm.HelloWorld.Content = xmlDnn.Bamm.HelloWorld.SelectSingleNode("content").InnerText;
        //    objDnn.Bamm.HelloWorld.CreatedByUser = UserID;
        //    AddDnn.Bamm.HelloWorld(objDnn.Bamm.HelloWorld);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.Bamm.HelloWorldInfo> colDnn.Bamm.HelloWorlds = GetDnn.Bamm.HelloWorlds(ModInfo.ModuleID);

        //foreach (Dnn.Bamm.HelloWorldInfo objDnn.Bamm.HelloWorld in colDnn.Bamm.HelloWorlds)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.Bamm.HelloWorld.Content, objDnn.Bamm.HelloWorld.CreatedByUser, objDnn.Bamm.HelloWorld.CreatedDate, ModInfo.ModuleID, objDnn.Bamm.HelloWorld.ItemId.ToString(), objDnn.Bamm.HelloWorld.Content, "ItemId=" + objDnn.Bamm.HelloWorld.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
