// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.store
{
    /// <summary>
	/// <para>The JSON data store is responsible for fetching data from an url. The type
	/// of the data has to be json.</para>
	/// <para>The loaded data will be parsed and saved in qooxdoo objects. Every value
	/// of the loaded data will be stored in a qooxdoo property. The model classes
	/// for the data will be created automatically.</para>
	/// <para>For the fetching itself it uses the <see cref="qx.io.request.Xhr"/> class and
	/// for parsing the loaded javascript objects into qooxdoo objects, the
	/// <see cref="qx.data.marshal.Json"/> class will be used.</para>
	/// <para>Please note that if you</para>
	/// <list type="bullet">
	/// <item>upgrade from qooxdoo 1.4 or lower</item>
	/// <item>choose not to force the old transport</item>
	/// <item>use a delegate with qx.data.store.IStoreDelegate#configureRequest</item>
	/// </list>
	/// <para>you probably need to change the implementation of your delegate to configure
	/// the <see cref="qx.io.request.Xhr"/> request.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.data.store.Json", OmitOptionalParameters = true, Export = false)]
    public partial class Json : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		/// <summary>
		/// Fired on change of the property <see cref="State"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeState;

		/// <summary>
		/// Fired on change of the property <see cref="Url"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeUrl;

		/// <summary>
		/// <para>Fired when an error (aborted, timeout or failed) occurred
		/// during the load. The data contains the respons of the request.
		/// If you want more details, use the <see cref="ChangeState"/> event.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnError;

		/// <summary>
		/// <para>Data event fired after the model has been created. The data will be the
		/// created model.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnLoaded;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Property for holding the loaded model instance.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		/// <summary>
		/// <para>The state of the request as an url. If you want to check if the request
		/// did it&#8217;s job, use, the <see cref="ChangeState"/> event and check for one of the
		/// listed values.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "configured","queued","sending","receiving","completed","aborted","timeout","failed"
		/// </remarks>
		[JsProperty(Name = "state", NativeField = true)]
		public object State { get; set; }

		/// <summary>
		/// <para>The url where the request should go to.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "url", NativeField = true)]
		public string Url { get; set; }

		#endregion Properties

		#region Methods

		public Json() { throw new NotImplementedException(); }

		/// <param name="url">The url where to find the data. The store starts loading as soon as the URL is give. If you want to change some details concerning the request, add null here and set the URL as soon as everything is set up.</param>
		/// <param name="delegatex">The delegate containing one of the methods specified in qx.data.store.IStoreDelegate.</param>
		public Json(string url, object delegatex = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property state.</para>
		/// </summary>
		[JsMethod(Name = "getState")]
		public object GetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property url.</para>
		/// </summary>
		[JsMethod(Name = "getUrl")]
		public string GetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property state
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property state.</param>
		[JsMethod(Name = "initState")]
		public void InitState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property url
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property url.</param>
		[JsMethod(Name = "initUrl")]
		public void InitUrl(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reloads the data with the url set in the <see cref="Url"/> property.</para>
		/// </summary>
		[JsMethod(Name = "reload")]
		public void Reload() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property state.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetState")]
		public void ResetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property url.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUrl")]
		public void ResetUrl() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property state.</para>
		/// </summary>
		/// <param name="value">New value for property state.</param>
		[JsMethod(Name = "setState")]
		public void SetState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property url.</para>
		/// </summary>
		/// <param name="value">New value for property url.</param>
		[JsMethod(Name = "setUrl")]
		public void SetUrl(string value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}