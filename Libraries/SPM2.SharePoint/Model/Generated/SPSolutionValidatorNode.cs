/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;
using System.Xml.Serialization;
using Microsoft.SharePoint.UserCode;
using SPM2.Framework;

namespace SPM2.SharePoint.Model
{
	[AdapterItemType("Microsoft.SharePoint.UserCode.SPSolutionValidator, Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c")]
	public partial class SPSolutionValidatorNode : SPNode
	{
        [XmlIgnore]
		public SPSolutionValidator SolutionValidator
        {
            get
            {
                return (SPSolutionValidator)this.SPObject;
            }
            set
            {
                this.SPObject = value;
            }
        }
	}
}
