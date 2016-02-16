/* ---------------------------
 * SharePoint Manager 2010 v2
 * Created by Carsten Keutmann
 * ---------------------------
 */

using System;

using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using SPM2.Framework;

namespace SPM2.SharePoint.Model
{
	[Title("Properties")]
	[AdapterItemType("Microsoft.SharePoint.SPModule+SPModulePropertyBag, Microsoft.SharePoint, Version=14.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c")]
	[ExportToNode("SPM2.SharePoint.Model.SPModuleNode")]
	public partial class SPModulePropertyBagNode : SPNode
	{
	}
}
