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
	/// <summary>Pricing Item</summary>
	[PublishedContentModel("dPricingItem")]
	public partial class DPricingItem : PublishedContentModel, IAbstractlink
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "dPricingItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DPricingItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DPricingItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Button Text: In order for the button to appear, button text must be filled and there must also be a working link. If a link is not present, then the button will be replaced with plain text.
		///</summary>
		[ImplementPropertyType("buttonText")]
		public string ButtonText
		{
			get { return this.GetPropertyValue<string>("buttonText"); }
		}

		///<summary>
		/// Currency: E.g. "$" or "€"
		///</summary>
		[ImplementPropertyType("currency")]
		public string Currency
		{
			get { return this.GetPropertyValue<string>("currency"); }
		}

		///<summary>
		/// Description: Type features, one per line. You can use bold etc.
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Highlight: If you check this box, the current pricing item will be highlighted.
		///</summary>
		[ImplementPropertyType("highlight")]
		public bool Highlight
		{
			get { return this.GetPropertyValue<bool>("highlight"); }
		}

		///<summary>
		/// Period: E.g. "per month", "per year"
		///</summary>
		[ImplementPropertyType("period")]
		public string Period
		{
			get { return this.GetPropertyValue<string>("period"); }
		}

		///<summary>
		/// Price
		///</summary>
		[ImplementPropertyType("price")]
		public string Price
		{
			get { return this.GetPropertyValue<string>("price"); }
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
