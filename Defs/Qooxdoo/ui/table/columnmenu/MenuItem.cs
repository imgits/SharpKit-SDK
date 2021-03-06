// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.columnmenu
{
    /// <summary>
	/// <para>A menu item.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.columnmenu.MenuItem", OmitOptionalParameters = true, Export = false)]
    public partial class MenuItem : qx.ui.menu.CheckBox, qx.ui.table.IColumnMenuItem
    {
		#region Events

		/// <summary>
		/// <para>Dispatched when a column changes visibility state. The event data is a
		/// boolean indicating whether the table column associated with this menu
		/// item is now visible.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeVisible;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the table column associated with this menu item is visible</para>
		/// </summary>
		[JsProperty(Name = "visible", NativeField = true)]
		public object Visible { get; set; }

		#endregion Properties

		#region Methods

		public MenuItem() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property visible.</para>
		/// </summary>
		[JsMethod(Name = "getVisible")]
		public object GetVisible() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property visible
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property visible.</param>
		[JsMethod(Name = "initVisible")]
		public void InitVisible(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property visible equals true.</para>
		/// </summary>
		[JsMethod(Name = "isVisible")]
		public void IsVisible() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property visible.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetVisible")]
		public void ResetVisible() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property visible.</para>
		/// </summary>
		/// <param name="value">New value for property visible.</param>
		[JsMethod(Name = "setVisible")]
		public void SetVisible(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property visible.</para>
		/// </summary>
		[JsMethod(Name = "toggleVisible")]
		public void ToggleVisible() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a new instance of an item for insertion into the table column
		/// visibility menu.</para>
		/// </summary>
		/// <param name="text">Text for the menu item, most typically the name of the column in the table.</param>
		public MenuItem(string text) { throw new NotImplementedException(); }

		#endregion Methods
    }
}