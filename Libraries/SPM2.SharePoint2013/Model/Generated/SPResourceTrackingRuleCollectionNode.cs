/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;

using Microsoft.SharePoint.Administration;
using SPM2.Framework; using SPM2.SharePoint.Model;

namespace SPM2.SharePoint2013.Model
{
	[AdapterItemType("Microsoft.SharePoint.Administration.SPResourceTrackingRuleCollection, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c")]
	public partial class SPResourceTrackingRuleCollectionNode : SPNodeCollection
	{
		[System.Xml.Serialization.XmlIgnore]
        public SPResourceTrackingRuleCollection ResourceTrackingRuleCollection
        {
            get
            {
                return (SPResourceTrackingRuleCollection)this.SPObject;
            }
            set
            {
                this.SPObject = value;
            }
        }
	}
}
