//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Process Item</summary>
	[PublishedContentModel("dProcessItem")]
	public partial class DProcessItem : PublishedContentModel, IAbstractlink
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "dProcessItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DProcessItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DProcessItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bubble Text
		///</summary>
		[ImplementPropertyType("bubbleText")]
		public string BubbleText
		{
			get { return this.GetPropertyValue<string>("bubbleText"); }
		}

		///<summary>
		/// Icon: Select the icon you need. You can find the class names together with icons at http://ionicons.com/
		///</summary>
		[ImplementPropertyType("icon")]
		public object Icon
		{
			get { return this.GetPropertyValue("icon"); }
		}

		///<summary>
		/// External Link: Optional link to an external page. External link always opens in a new window. External link OVERRIDES internal link in case it is also set.
		///</summary>
		[ImplementPropertyType("externalLink")]
		public string ExternalLink
		{
			get { return Abstractlink.GetExternalLink(this); }
		}

		///<summary>
		/// Internal Link: Link to a page on your site
		///</summary>
		[ImplementPropertyType("internalLink")]
		public string InternalLink
		{
			get { return Abstractlink.GetInternalLink(this); }
		}
	}
}