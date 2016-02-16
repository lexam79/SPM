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
	[Title("Solutions")]
    [Icon(Small = "GenericFeature.gif")]
	[ExportToNode("SPM2.SharePoint.Model.SPSiteNode")]
	public partial class SPUserSolutionCollectionNode
	{
	}
}
