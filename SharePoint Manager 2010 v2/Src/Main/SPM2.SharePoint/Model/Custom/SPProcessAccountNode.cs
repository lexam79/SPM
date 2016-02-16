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
	[Title("ProcessAccount")]
	[Icon(Small="BULLET.GIF")]
	[ExportToNode("SPM2.SharePoint.Model.SPProcessIdentityNode")]
	[ExportToNode("SPM2.SharePoint.Model.SPApplicationPoolNode")]
	[ExportToNode("SPM2.SharePoint.Model.SPFarmNode")]
	public partial class SPProcessAccountNode
	{
	}
}
