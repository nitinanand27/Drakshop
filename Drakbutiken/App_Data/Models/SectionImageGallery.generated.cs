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
	/// <summary>Image Gallery Section</summary>
	[PublishedContentModel("sectionImageGallery")]
	public partial class SectionImageGallery : PublishedContentModel, IAbstractSectionEffects
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sectionImageGallery";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SectionImageGallery(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SectionImageGallery, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Label for "All" category option: You can specify custom text for the "All" category option - if you don't enter text here the default setting from the Dictionary (Theme.Gallery.All) will be used.
		///</summary>
		[ImplementPropertyType("allOptionLabel")]
		public string AllOptionLabel
		{
			get { return this.GetPropertyValue<string>("allOptionLabel"); }
		}

		///<summary>
		/// Columns: Select how many columns the images will be presented with (2 min, 4 max). If you don't specify a value, 2 columns will be used.
		///</summary>
		[ImplementPropertyType("columns")]
		public int Columns
		{
			get { return this.GetPropertyValue<int>("columns"); }
		}

		///<summary>
		/// Do not display categories: If you check this box, categories will not be displayed in the image listing (category menu will still display and you can still assign items to categories)
		///</summary>
		[ImplementPropertyType("doNotDisplayCategories")]
		public bool DoNotDisplayCategories
		{
			get { return this.GetPropertyValue<bool>("doNotDisplayCategories"); }
		}

		///<summary>
		/// Hide "All" category option: If you check this box, items will be filtered by the first category and there will be no "all" option in the category menu.
		///</summary>
		[ImplementPropertyType("hideAllCategoryOption")]
		public bool HideAllCategoryOption
		{
			get { return this.GetPropertyValue<bool>("hideAllCategoryOption"); }
		}

		///<summary>
		/// Masonry: If you have images of uneven sizes and wish them to retain their sizes check this box. Otherwise the images will be automatically cropped around the focus point to form a grid.
		///</summary>
		[ImplementPropertyType("masonry")]
		public bool Masonry
		{
			get { return this.GetPropertyValue<bool>("masonry"); }
		}

		///<summary>
		/// Spacing between images: If this box is not checked, images will "stick" to each other
		///</summary>
		[ImplementPropertyType("spacing")]
		public bool Spacing
		{
			get { return this.GetPropertyValue<bool>("spacing"); }
		}

		///<summary>
		/// Upscale Images: If you check this box, the images displayed when a user clicks on the thumbs will be upscaled to match a maximum presentation size for the screen. Otherwise, they will be displayed at their original size. 
		///</summary>
		[ImplementPropertyType("upscaleImages")]
		public bool UpscaleImages
		{
			get { return this.GetPropertyValue<bool>("upscaleImages"); }
		}

		///<summary>
		/// Animation Direction: Choose the direction from which the animation will start. If you leave this selection empty and animations are enabled, the section will just "fade" in place.
		///</summary>
		[ImplementPropertyType("animationDirection")]
		public object AnimationDirection
		{
			get { return AbstractSectionEffects.GetAnimationDirection(this); }
		}

		///<summary>
		/// Enable Animation: Check this box to make this section animate. You can then specify the exact kind of animation using the options below.
		///</summary>
		[ImplementPropertyType("animationEnable")]
		public bool AnimationEnable
		{
			get { return AbstractSectionEffects.GetAnimationEnable(this); }
		}

		///<summary>
		/// Larger Animation: Check this to amplify the animation effect
		///</summary>
		[ImplementPropertyType("animationLarger")]
		public bool AnimationLarger
		{
			get { return AbstractSectionEffects.GetAnimationLarger(this); }
		}
	}
}
