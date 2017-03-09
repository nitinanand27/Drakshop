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
	/// <summary>Counters Section</summary>
	[PublishedContentModel("sectionCounter")]
	public partial class SectionCounter : PublishedContentModel, IAbstractBackgroundImage, IAbstractSectionEffects
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sectionCounter";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SectionCounter(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SectionCounter, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Counter 1: First counter is mandatory. You can have one to four counters active. To exclude a specific counter (except the first one), leave the corresponding "text" field blank.
		///</summary>
		[ImplementPropertyType("counter1")]
		public int Counter1
		{
			get { return this.GetPropertyValue<int>("counter1"); }
		}

		///<summary>
		/// Counter 2
		///</summary>
		[ImplementPropertyType("counter2")]
		public int Counter2
		{
			get { return this.GetPropertyValue<int>("counter2"); }
		}

		///<summary>
		/// Counter 3
		///</summary>
		[ImplementPropertyType("counter3")]
		public int Counter3
		{
			get { return this.GetPropertyValue<int>("counter3"); }
		}

		///<summary>
		/// Counter 4
		///</summary>
		[ImplementPropertyType("counter4")]
		public int Counter4
		{
			get { return this.GetPropertyValue<int>("counter4"); }
		}

		///<summary>
		/// Text for Counter 1
		///</summary>
		[ImplementPropertyType("text1")]
		public string Text1
		{
			get { return this.GetPropertyValue<string>("text1"); }
		}

		///<summary>
		/// Text for Counter 2
		///</summary>
		[ImplementPropertyType("text2")]
		public string Text2
		{
			get { return this.GetPropertyValue<string>("text2"); }
		}

		///<summary>
		/// Text for Counter 3
		///</summary>
		[ImplementPropertyType("text3")]
		public string Text3
		{
			get { return this.GetPropertyValue<string>("text3"); }
		}

		///<summary>
		/// Text for Counter 4
		///</summary>
		[ImplementPropertyType("text4")]
		public string Text4
		{
			get { return this.GetPropertyValue<string>("text4"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return AbstractBackgroundImage.GetImage(this); }
		}

		///<summary>
		/// Use Light Overlay: If you have checked "Use Overlay" above, check this box to use a light overlay. If you leave this box unchecked, a dark overlay will be used.
		///</summary>
		[ImplementPropertyType("useLightOverlay")]
		public bool UseLightOverlay
		{
			get { return AbstractBackgroundImage.GetUseLightOverlay(this); }
		}

		///<summary>
		/// Use Light Text Color: Check to use light color for text. If unchecked, dark color will be used.
		///</summary>
		[ImplementPropertyType("useLightTextColor")]
		public bool UseLightTextColor
		{
			get { return AbstractBackgroundImage.GetUseLightTextColor(this); }
		}

		///<summary>
		/// Use Overlay: If you have set a background image, you can use a dark or light overlay
		///</summary>
		[ImplementPropertyType("useOverlay")]
		public bool UseOverlay
		{
			get { return AbstractBackgroundImage.GetUseOverlay(this); }
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