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
	/// <summary>Team Item</summary>
	[PublishedContentModel("dTeamItem")]
	public partial class DTeamItem : PublishedContentModel, IAbstractlink
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "dTeamItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DTeamItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DTeamItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Facebook URL
		///</summary>
		[ImplementPropertyType("facebookUrl")]
		public string FacebookUrl
		{
			get { return this.GetPropertyValue<string>("facebookUrl"); }
		}

		///<summary>
		/// GitHub URL
		///</summary>
		[ImplementPropertyType("githubUrl")]
		public string GithubUrl
		{
			get { return this.GetPropertyValue<string>("githubUrl"); }
		}

		///<summary>
		/// Google Plus URL
		///</summary>
		[ImplementPropertyType("googlePlusUrl")]
		public string GooglePlusUrl
		{
			get { return this.GetPropertyValue<string>("googlePlusUrl"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// LinkedIn URL
		///</summary>
		[ImplementPropertyType("linkedinUrl")]
		public string LinkedinUrl
		{
			get { return this.GetPropertyValue<string>("linkedinUrl"); }
		}

		///<summary>
		/// Personal Page URL
		///</summary>
		[ImplementPropertyType("personalPageUrl")]
		public string PersonalPageUrl
		{
			get { return this.GetPropertyValue<string>("personalPageUrl"); }
		}

		///<summary>
		/// Pinterest URL
		///</summary>
		[ImplementPropertyType("pinterestUrl")]
		public string PinterestUrl
		{
			get { return this.GetPropertyValue<string>("pinterestUrl"); }
		}

		///<summary>
		/// Role
		///</summary>
		[ImplementPropertyType("role")]
		public string Role
		{
			get { return this.GetPropertyValue<string>("role"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return this.GetPropertyValue<string>("summary"); }
		}

		///<summary>
		/// Tumblr URL
		///</summary>
		[ImplementPropertyType("tumblrUrl")]
		public string TumblrUrl
		{
			get { return this.GetPropertyValue<string>("tumblrUrl"); }
		}

		///<summary>
		/// Twitter URL
		///</summary>
		[ImplementPropertyType("twitterUrl")]
		public string TwitterUrl
		{
			get { return this.GetPropertyValue<string>("twitterUrl"); }
		}

		///<summary>
		/// Vimeo URL
		///</summary>
		[ImplementPropertyType("vimeoUrl")]
		public string VimeoUrl
		{
			get { return this.GetPropertyValue<string>("vimeoUrl"); }
		}

		///<summary>
		/// Youtube URL
		///</summary>
		[ImplementPropertyType("youtubeUrl")]
		public string YoutubeUrl
		{
			get { return this.GetPropertyValue<string>("youtubeUrl"); }
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