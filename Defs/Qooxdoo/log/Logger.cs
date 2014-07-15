// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.log
{
    /// <summary>
	/// <para>Main qooxdoo logging class.</para>
	/// <para>Used as central logging feature by qx.core.Object.</para>
	/// <para>Extremely modular and lightweight to support logging at bootstrap and
	/// at shutdown as well.</para>
	/// <list type="bullet">
	/// <item>Supports dynamic appenders to push the output to the user</item>
	/// <item>Supports buffering of the last 50 messages (configurable)</item>
	/// <item>Supports different debug levels (&#8220;debug&#8221;, &#8220;info&#8221;, &#8220;warn&#8221; or &#8220;error&#8221;)</item>
	/// <item>Simple data serialization for incoming messages</item>
	/// </list>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.log.Logger", OmitOptionalParameters = true, Export = false)]
    public partial class Logger 
    {
		#region Methods

		public Logger() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Deletes the current buffer. Does not influence message handling of the
		/// connected appenders.</para>
		/// </summary>
		[JsMethod(Name = "clear")]
		public static void Clear() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sending a message at level &#8220;debug&#8221; to the logger.</para>
		/// </summary>
		/// <param name="objectx">Contextual object (either instance or static class)</param>
		/// <param name="message">Any number of arguments supported. An argument may have any JavaScript data type. All data is serialized immediately and does not keep references to other objects.</param>
		[JsMethod(Name = "debug")]
		public static void Debug(object objectx, object message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints a class deprecation warning and a stack trace if the setting
		/// qx.debug is set to on.</para>
		/// </summary>
		/// <param name="clazz">reference to the deprecated class.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecatedClassWarning")]
		public static void DeprecatedClassWarning(Class clazz, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints a constant deprecation warning and a stacktrace if the setting
		/// qx.debug is set to on AND the browser supports
		/// defineGetter!</para>
		/// </summary>
		/// <param name="clazz">The class the constant is attached to.</param>
		/// <param name="constant">The name of the constant as string.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecatedConstantWarning")]
		public static void DeprecatedConstantWarning(Class clazz, string constant, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints an event deprecation warning and a stack trace if the setting
		/// qx.debug is set to on.</para>
		/// </summary>
		/// <param name="clazz">reference to the deprecated class.</param>
		/// <param name="eventx">deprecated event name.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecatedEventWarning")]
		public static void DeprecatedEventWarning(Class clazz, string eventx, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints a method deprecation warning and a stack trace if the setting
		/// qx.debug is set to on.</para>
		/// </summary>
		/// <param name="fcn">reference to the deprecated function. This is arguments.callee if the calling method is to be deprecated.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecatedMethodWarning")]
		public static void DeprecatedMethodWarning(Action<object> fcn, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints a mixin deprecation warning and a stack trace if the setting
		/// qx.debug is set to on.</para>
		/// </summary>
		/// <param name="clazz">reference to the deprecated mixin.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecatedMixinWarning")]
		public static void DeprecatedMixinWarning(Class clazz, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints a deprecation waring and a stacktrace when a subclass overrides
		/// the passed method name. The deprecation is only printed if the setting
		/// qx.debug is set to on.</para>
		/// </summary>
		/// <param name="objectx">Instance to check for overriding.</param>
		/// <param name="baseclass">The baseclass as starting point.</param>
		/// <param name="methodName">The method name which is deprecated for overriding.</param>
		/// <param name="msg">Optional message to be printed.</param>
		[JsMethod(Name = "deprecateMethodOverriding")]
		public static void DeprecateMethodOverriding(qx.core.Object objectx, Class baseclass, string methodName, string msg) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sending a message at level &#8220;error&#8221; to the logger.</para>
		/// </summary>
		/// <param name="objectx">Contextual object (either instance or static class)</param>
		/// <param name="message">Any number of arguments supported. An argument may have any JavaScript data type. All data is serialized immediately and does not keep references to other objects.</param>
		[JsMethod(Name = "error")]
		public static void Error(object objectx, object message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the currently configured minimum log level required for new
		/// messages.</para>
		/// </summary>
		/// <returns>Debug level</returns>
		[JsMethod(Name = "getLevel")]
		public static double GetLevel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the currently configured number of messages to be kept in the
		/// buffer.</para>
		/// </summary>
		/// <returns>Treshold value</returns>
		[JsMethod(Name = "getTreshold")]
		public static double GetTreshold() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sending a message at level &#8220;info&#8221; to the logger.</para>
		/// </summary>
		/// <param name="objectx">Contextual object (either instance or static class)</param>
		/// <param name="message">Any number of arguments supported. An argument may have any JavaScript data type. All data is serialized immediately and does not keep references to other objects.</param>
		[JsMethod(Name = "info")]
		public static void Info(object objectx, object message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Registers the given appender and inserts the last cached messages.</para>
		/// </summary>
		/// <param name="appender">A static appender class supporting at least a process() method to handle incoming messages.</param>
		[JsMethod(Name = "register")]
		public static void Register(Class appender) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Configures the minimum log level required for new messages.</para>
		/// </summary>
		/// <param name="value">One of &#8220;debug&#8221;, &#8220;info&#8221;, &#8220;warn&#8221; or &#8220;error&#8221;.</param>
		[JsMethod(Name = "setLevel")]
		public static void SetLevel(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Configures the number of messages to be kept in the buffer.</para>
		/// </summary>
		/// <param name="value">Any positive integer</param>
		[JsMethod(Name = "setTreshold")]
		public static void SetTreshold(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prints the current stack trace at level &#8220;info&#8221;</para>
		/// </summary>
		/// <param name="objectx">Contextual object (either instance or static class)</param>
		[JsMethod(Name = "trace")]
		public static void Trace(object objectx) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unregisters the given appender</para>
		/// </summary>
		/// <param name="appender">A static appender class</param>
		[JsMethod(Name = "unregister")]
		public static void Unregister(Class appender) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sending a message at level &#8220;warn&#8221; to the logger.</para>
		/// </summary>
		/// <param name="objectx">Contextual object (either instance or static class)</param>
		/// <param name="message">Any number of arguments supported. An argument may have any JavaScript data type. All data is serialized immediately and does not keep references to other objects.</param>
		[JsMethod(Name = "warn")]
		public static void Warn(object objectx, object message) { throw new NotImplementedException(); }

		#endregion Methods
    }
}