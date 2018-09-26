using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System;

namespace TextBoxStyle.Components
{
    public enum Location { Top = 0, Right, Bottom, Left }

    public class TextBoxExtended : TextBox
    {
        #region DependencyPropertys

        #region Header

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.RegisterAttached
        (
            "Header", typeof(string), typeof(TextBoxExtended),
            new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.Inherits)
        );
        public static string GetHeader(DependencyObject obj) => (string)obj.GetValue(HeaderProperty);
        public static void SetHeader(DependencyObject obj, string value) => obj.SetValue(HeaderProperty, value);

        #endregion Header

        #region Image

        public static readonly DependencyProperty ImageProperty = DependencyProperty.RegisterAttached
        (
            "Image", typeof(Geometry), typeof(TextBoxExtended),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits)
        );
        public static Geometry GetImage(DependencyObject obj) => (Geometry)obj.GetValue(ImageProperty);
        public static void SetImage(DependencyObject obj, Geometry value) => obj.SetValue(ImageProperty, value);

        #endregion Image

        #region PlaceHolder

        public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.RegisterAttached
        (
            "PlaceHolder", typeof(string), typeof(TextBoxExtended),
            new FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.Inherits)
        );
        public static string GetPlaceHolder(DependencyObject obj) => (string)obj.GetValue(PlaceHolderProperty);
        public static void SetPlaceHolder(DependencyObject obj, string value) => obj.SetValue(PlaceHolderProperty, value);

        #endregion PlaceHolder

        #region IsInPlaceEditor

        public static readonly DependencyProperty IsInPlaceEditorProperty = DependencyProperty.RegisterAttached
        (
            "IsInPlaceEditor", typeof(bool), typeof(TextBoxExtended),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.Inherits)
        );
        public static bool GetIsInPlaceEditor(DependencyObject obj) => (bool)obj.GetValue(IsInPlaceEditorProperty);
        public static void SetIsInPlaceEditor(DependencyObject obj, bool value) => obj.SetValue(IsInPlaceEditorProperty, value);

        #endregion IsInPlaceEditor

        #endregion DependencyPropertys

        #region Constructor

        public TextBoxExtended() { }

        #endregion Constructor

        #region Events

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

        #endregion Events
    }
}