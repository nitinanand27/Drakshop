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
	/// <summary>Testimonial Item</summary>
	[PublishedContentModel("dTestimonialItem")]
	public partial class DTestimonialItem : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "dTestimonialItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DTestimonialItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DTestimonialItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Company, Location or Profession
		///</summary>
		[ImplementPropertyType("authorAdditionalInfo")]
		public string AuthorAdditionalInfo
		{
			get { return this.GetPropertyValue<string>("authorAdditionalInfo"); }
		}

		///<summary>
		/// Information: The name of the node is the author's name.
		///</summary>
		[ImplementPropertyType("information")]
		public string Information
		{
			get { return this.GetPropertyValue<string>("information"); }
		}

		///<summary>
		/// Lead
		///</summary>
		[ImplementPropertyType("lead")]
		public string Lead
		{
			get { return this.GetPropertyValue<string>("lead"); }
		}
	}
}