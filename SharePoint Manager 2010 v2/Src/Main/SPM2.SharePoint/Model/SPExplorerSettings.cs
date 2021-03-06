﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPM2.Framework.ComponentModel;
using System.ComponentModel;
using SPM2.Framework;
using System.Xml.Serialization;
using SPM2.Framework.Configuration;

namespace SPM2.SharePoint.Model
{
    [Title("SharePoint Explorer")]
    //[XmlType(TypeName = AddInID)]
    [ExportToSettings()]
    public class SPExplorerSettings : Settings<SPExplorerSettings>
    {
        
        public const string AddInID = "SPM2.SharePoint.Model.SPExplorerSettings";

        private int _batchNodeLoad = 200;
        [DisplayName("Batch load")]
        [Description("If a list contains a high number of items, the explorer will only load the number of items specified. It will be possible to load more items by selecting the last node in the collection.")]
        public int BatchNodeLoad
        {
            get { return _batchNodeLoad; }
            set { _batchNodeLoad = value; }
        }


    }
}
