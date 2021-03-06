//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// ScrollView provides a scrollable widget, supporting flick gestures, across both touch and mouse based devices.
    /// </summary>
    public partial class ScrollView : Widget
    {
        /// <summary>
        /// After listener for the height or width attribute
        /// </summary>
        protected void _afterDimChange(object e){}
        /// <summary>
        /// After listener for changes to the disabled attribute
        /// </summary>
        protected void _afterDisabledChange(object e){}
        /// <summary>
        /// After listener for changes to the drag attribute
        /// </summary>
        protected void _afterDragChange(object e){}
        /// <summary>
        /// After listener for changes to the flick attribute
        /// </summary>
        protected void _afterFlickChange(object e){}
        /// <summary>
        /// After listener for changes to the scrollX or scrollY attribute
        /// </summary>
        protected void _afterScrollChange(object e){}
        [JsMethod(JsonInitializers=true)]
        public ScrollView(){}
        /// <summary>
        /// Execute a flick at the end of a scroll action
        /// </summary>
        protected void _flick(Y_.DataType_.Number distance, Y_.DataType_.Number time){}
        /// <summary>
        /// Execute a single frame in the flick animation
        /// </summary>
        protected void _flickFrame(){}
        /// <summary>
        /// Stop the animation timer
        /// </summary>
        protected void _killTimer(object fireEvent){}
        /// <summary>
        /// Setter for the scrollX attribute
        /// </summary>
        protected Y_.DataType_.Number _setScrollX(Y_.DataType_.Number val){return null;}
        /// <summary>
        /// Setter for the scrollY ATTR
        /// </summary>
        protected Y_.DataType_.Number _setScrollY(Y_.DataType_.Number val){return null;}
        /// <summary>
        /// This method gets invoked whenever the height or width attributes change,
        /// allowing us to determine which scrolling axes need to be enabled.
        /// </summary>
        protected void _uiDimensionsChange(){}
        /// <summary>
        /// Used to move the ScrollView content
        /// </summary>
        protected void _uiScrollTo(Y_.DataType_.Number x, Y_.DataType_.Number y, Y_.DataType_.Number duration, object easing){}
        /// <summary>
        /// Override the contentBox sizing method, since the contentBox height
        /// should not be that of the boundingBox.
        /// </summary>
        protected void _uiSizeCB(){}
        /// <summary>
        /// bindUI implementation
        /// Hooks up events for the widget
        /// </summary>
        public void bindUI(){}
        /// <summary>
        /// Designated initializer
        /// </summary>
        public void initializer(){}
        /// <summary>
        /// Scroll the element to a given xy coordinate
        /// </summary>
        public void scrollTo(Y_.DataType_.Number x, Y_.DataType_.Number y, Y_.DataType_.Number duration, object easing){}
        /// <summary>
        /// syncUI implementation.
        /// Update the scroll position, based on the current value of scrollX/scrollY.
        /// </summary>
        public void syncUI(){}
        /// <summary>
        /// <p>Used to control whether or not ScrollView's internal
        /// gesturemovestart, gesturemove and gesturemoveend
        /// event listeners should preventDefault. The value is an
        /// object, with "start", "move" and "end" properties used to
        /// specify which events should preventDefault and which shouldn't:</p>
        /// <pre>
        /// {
        /// start : false,
        /// move : true,
        /// end : false
        /// }
        /// </pre>
        /// <p>The default values are set up in order to prevent panning,
        /// on touch devices, while allowing click listeners on elements inside
        /// the ScrollView to be notified as expected.</p>
        /// </summary>
        protected object _prevent{get;set;}
        /// <summary>
        /// Drag coefficient for intertial scrolling at the upper
        /// and lower boundaries of the scrollview. Set to 0 to
        /// disable "rubber-banding".
        /// </summary>
        public Y_.DataType_.Number bounce{get;set;}
        /// <summary>
        /// The default bounce distance in pixels
        /// </summary>
        public Y_.DataType_.Number BOUNCE_RANGE{get;set;}
        /// <summary>
        /// List of class names used in the scrollview's DOM
        /// </summary>
        public object CLASS_NAMES{get;set;}
        /// <summary>
        /// Drag coefficent for inertial scrolling. The closer to 1 this
        /// value is, the less friction during scrolling.
        /// </summary>
        public object deceleration{get;set;}
        /// <summary>
        /// The minimum distance and/or velocity which define a flick. Can be set to false,
        /// to disable flick support (note: drag support is enabled/disabled separately)
        /// </summary>
        public object flick{get;set;}
        /// <summary>
        /// The interval used when animating the flick
        /// </summary>
        public Y_.DataType_.Number FRAME_STEP{get;set;}
        /// <summary>
        /// Contains the distance (postive or negative) in pixels by which the scrollview was last scrolled. This is useful when
        /// setting up click listeners on the scrollview content, which on mouse based devices are always fired, even after a
        /// drag/flick.
        /// <p>Touch based devices don't currently fire a click event, if the finger has been moved (beyond a threshold) so this check isn't required,
        /// if working in a purely touch based environment</p>
        /// </summary>
        public Y_.DataType_.Number lastScrolledAmt{get;set;}
        /// <summary>
        /// The scroll position in the x-axis
        /// </summary>
        public Y_.DataType_.Number scrollX{get;set;}
        /// <summary>
        /// The scroll position in the y-axis
        /// </summary>
        public Y_.DataType_.Number scrollY{get;set;}
    }
}
