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
	[Title("RestrictedTypes")]
	[Icon(Small="BULLET.GIF")]
	[ExportToNode("SPM2.SharePoint.Model.SPRestrictedObjectModelNode")]
	[ExportToNode("SPM2.SharePoint.Model.SPClientCallableSettingsNode")]
	public partial class SPObjectModelTypeCollectionNode
	{
	}
}
