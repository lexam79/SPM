/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;

using Microsoft.SharePoint;
using SPM2.Framework; using SPM2.SharePoint.Model;

namespace SPM2.SharePoint2013.Model
{
	[AdapterItemType("Microsoft.SharePoint.SPUserIdInfo, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c")]
	public partial class SPUserIdInfoNode : SPNode
	{
		[System.Xml.Serialization.XmlIgnore]
        public SPUserIdInfo UserIdInfo
        {
            get
            {
                return (SPUserIdInfo)this.SPObject;
            }
            set
            {
                this.SPObject = value;
            }
        }
	}
}
