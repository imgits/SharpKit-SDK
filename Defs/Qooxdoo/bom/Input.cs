// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Cross browser abstractions to work with input elements.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Input", OmitOptionalParameters = true, Export = false)]
    public partial class Input 
    {
		#region Methods

		public Input() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates an DOM input/textarea/select element.</para>
		/// <para>Attributes may be given directly with this call. This is critical
		/// for some attributes e.g. name, type, ... in many clients.</para>
		/// <para>Note: select and textarea elements are created
		/// using the identically named type.</para>
		/// </summary>
		/// <param name="type">Any valid type for HTML, select and textarea</param>
		/// <param name="attributes">Map of attributes to apply</param>
		/// <param name="win">Window to create the element for</param>
		/// <returns>The created input node</returns>
		[JsMethod(Name = "create")]
		public static qx.html.Element Create(string type, object attributes, Window win) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the currently configured value.</para>
		/// <para>Works with simple input fields as well as with
		/// select boxes or option elements.</para>
		/// <para>Returns an array in cases of multi-selection in
		/// select boxes but in all other cases a string.</para>
		/// </summary>
		/// <param name="element">DOM element to query</param>
		/// <returns>The value of the given element</returns>
		[JsMethod(Name = "getValue")]
		public static object GetValue(qx.html.Element element) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the given value to the element.</para>
		/// <para>Normally the value is given as a string/number value and applied
		/// to the field content (textfield, textarea) or used to
		/// detect whether the field is checked (checkbox, radiobutton).</para>
		/// <para>Supports array values for selectboxes (multiple-selection)
		/// and checkboxes or radiobuttons (for convenience).</para>
		/// <para>Please note: To modify the value attribute of a checkbox or
		/// radiobutton use <see cref="qx.bom.element.Attribute.Set"/> instead.</para>
		/// </summary>
		/// <param name="element">element to update</param>
		/// <param name="value">the value to apply</param>
		[JsMethod(Name = "setValue")]
		public static void SetValue(qx.html.Element element, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the text wrap behaviour of a text area element.
		/// This property uses the attribute &#8220;wrap&#8221; respectively
		/// the style property &#8220;whiteSpace&#8221;</para>
		/// </summary>
		/// <param name="element">DOM element to modify</param>
		/// <param name="wrap">Whether to turn text wrap on or off.</param>
		[JsMethod(Name = "setWrap")]
		public static void SetWrap(qx.html.Element element, bool wrap) { throw new NotImplementedException(); }

		#endregion Methods
    }
}