// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.window
{
    /// <summary>
	/// <para>The default window manager implementation</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.window.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object, qx.ui.window.IWindowManager
    {
		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Ask the manager to bring a window to the front.</para>
		/// </summary>
		/// <param name="win">window to bring to front</param>
		[JsMethod(Name = "bringToFront")]
		public void BringToFront(Window win) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Inform the window manager about a new active window</para>
		/// </summary>
		/// <param name="active">new active window</param>
		/// <param name="oldActive">old active window</param>
		[JsMethod(Name = "changeActiveWindow")]
		public void ChangeActiveWindow(Window active, Window oldActive) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the connected desktop</para>
		/// </summary>
		/// <returns>The desktop</returns>
		[JsMethod(Name = "getDesktop")]
		public qx.ui.window.IDesktop GetDesktop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Ask the manager to send a window to the back.</para>
		/// </summary>
		/// <param name="win">window to sent to back</param>
		[JsMethod(Name = "sendToBack")]
		public void SendToBack(Window win) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Connect the window manager to the window desktop</para>
		/// </summary>
		/// <param name="desktop">The connected desktop</param>
		[JsMethod(Name = "setDesktop")]
		public void SetDesktop(IDesktop desktop) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called during the flush of the
		/// <see cref="qx.ui.core.queue.Widget widget queue"/>.</para>
		/// </summary>
		[JsMethod(Name = "syncWidget")]
		public void SyncWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the window order and modality blocker</para>
		/// </summary>
		[JsMethod(Name = "updateStack")]
		public void UpdateStack() { throw new NotImplementedException(); }

		#endregion Methods
    }
}