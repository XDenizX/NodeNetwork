using NodeNetwork.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NodeNetwork.Views
{
    public class CommentBoxView : Control, IViewFor<CommentBoxViewModel>
    {
        #region ViewModel
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(nameof(ViewModel),
            typeof(CommentBoxViewModel), typeof(CommentBoxView), new PropertyMetadata(null));

        public CommentBoxViewModel ViewModel
        {
            get => (CommentBoxViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (CommentBoxViewModel)value;
        }
        #endregion

        #region Properties
        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(nameof(Content), typeof(string), typeof(CommentBoxView));
        public string Content
        {
            get => (string)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        public static readonly DependencyProperty ContentFontFamilyProperty = DependencyProperty.Register(nameof(ContentFontFamily), typeof(FontFamily), typeof(CommentBoxView));
        public FontFamily ContentFontFamily
        {
            get => (FontFamily)GetValue(ContentFontFamilyProperty);
            set => SetValue(ContentFontFamilyProperty, value);
        }

        public static readonly DependencyProperty ContentFontSizeProperty = DependencyProperty.Register(nameof(ContentFontSize), typeof(double), typeof(CommentBoxView));
        public double ContentFontSize
        {
            get => (double)GetValue(ContentFontFamilyProperty);
            set => SetValue(ContentFontFamilyProperty, value);
        }
        #endregion
    }
}
