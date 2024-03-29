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
	// Mixin content Type 1084 with alias "abstractSectionEffects"
	/// <summary>Abstract Section Effects</summary>
	public partial interface IAbstractSectionEffects : IPublishedContent
	{
		/// <summary>Animation Direction</summary>
		object AnimationDirection { get; }

		/// <summary>Enable Animation</summary>
		bool AnimationEnable { get; }

		/// <summary>Larger Animation</summary>
		bool AnimationLarger { get; }
	}

	/// <summary>Abstract Section Effects</summary>
	[PublishedContentModel("abstractSectionEffects")]
	public partial class AbstractSectionEffects : PublishedContentModel, IAbstractSectionEffects
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "abstractSectionEffects";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AbstractSectionEffects(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AbstractSectionEffects, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Animation Direction: Choose the direction from which the animation will start. If you leave this selection empty and animations are enabled, the section will just "fade" in place.
		///</summary>
		[ImplementPropertyType("animationDirection")]
		public object AnimationDirection
		{
			get { return GetAnimationDirection(this); }
		}

		/// <summary>Static getter for Animation Direction</summary>
		public static object GetAnimationDirection(IAbstractSectionEffects that) { return that.GetPropertyValue("animationDirection"); }

		///<summary>
		/// Enable Animation: Check this box to make this section animate. You can then specify the exact kind of animation using the options below.
		///</summary>
		[ImplementPropertyType("animationEnable")]
		public bool AnimationEnable
		{
			get { return GetAnimationEnable(this); }
		}

		/// <summary>Static getter for Enable Animation</summary>
		public static bool GetAnimationEnable(IAbstractSectionEffects that) { return that.GetPropertyValue<bool>("animationEnable"); }

		///<summary>
		/// Larger Animation: Check this to amplify the animation effect
		///</summary>
		[ImplementPropertyType("animationLarger")]
		public bool AnimationLarger
		{
			get { return GetAnimationLarger(this); }
		}

		/// <summary>Static getter for Larger Animation</summary>
		public static bool GetAnimationLarger(IAbstractSectionEffects that) { return that.GetPropertyValue<bool>("animationLarger"); }
	}
}
