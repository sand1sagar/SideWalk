﻿#pragma checksum "..\..\..\Views\PermitView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84D0374191C3FDEEFE83F48C6D39DA43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Aviad.WPF.Controls;
using GalaSoft.MvvmLight.Command;
using SidewalkPermitWPF.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SidewalkPermitWPF.Views {
    
    
    /// <summary>
    /// PermitView
    /// </summary>
    public partial class PermitView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SidewalkPermitWPF.Views.PermitView mdiChild;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlTopMenu;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid affidavitGrid;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTopMenuHide;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTopMenuShow;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAffidavitCount;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoContractor;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoOwner;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoOther;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorSearch;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox suggestionList;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCCBNumber;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorName;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorContact;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorAddress;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorCity;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorState;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorZip;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtContractorPhone;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoAffidavit;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdoAddress;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAffidavitSearch;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox affidavitSuggestionList;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPropertySearch;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PropertySuggestionList;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInspector;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInspectionDate;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNoticeSent;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPropertyOwner;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPropertyDescription;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid affidavitFee;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtExpirationDate;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMinFee;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaxFee;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFee;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser browser;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkLegal;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\Views\PermitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SidewalkPermitWPF;component/views/permitview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PermitView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mdiChild = ((SidewalkPermitWPF.Views.PermitView)(target));
            return;
            case 2:
            this.pnlTopMenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.affidavitGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 43 "..\..\..\Views\PermitView.xaml"
            this.affidavitGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.affidavitGrid_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnTopMenuHide = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Views\PermitView.xaml"
            this.btnTopMenuHide.Click += new System.Windows.RoutedEventHandler(this.btnTopMenuHide_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnTopMenuShow = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Views\PermitView.xaml"
            this.btnTopMenuShow.Click += new System.Windows.RoutedEventHandler(this.btnTopMenuShow_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblAffidavitCount = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.rdoContractor = ((System.Windows.Controls.RadioButton)(target));
            
            #line 92 "..\..\..\Views\PermitView.xaml"
            this.rdoContractor.Checked += new System.Windows.RoutedEventHandler(this.rdoContractor_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rdoOwner = ((System.Windows.Controls.RadioButton)(target));
            
            #line 93 "..\..\..\Views\PermitView.xaml"
            this.rdoOwner.Checked += new System.Windows.RoutedEventHandler(this.rdoOwner_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rdoOther = ((System.Windows.Controls.RadioButton)(target));
            
            #line 94 "..\..\..\Views\PermitView.xaml"
            this.rdoOther.Checked += new System.Windows.RoutedEventHandler(this.rdoOther_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtContractorSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\..\Views\PermitView.xaml"
            this.txtContractorSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtContractorSearch_KeyUp);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\Views\PermitView.xaml"
            this.txtContractorSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtContractorSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.suggestionList = ((System.Windows.Controls.ListBox)(target));
            
            #line 101 "..\..\..\Views\PermitView.xaml"
            this.suggestionList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.suggestionList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.txtCCBNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.txtContractorName = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\..\Views\PermitView.xaml"
            this.txtContractorName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LettersAndNumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 15:
            this.txtContractorContact = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.txtContractorAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.txtContractorCity = ((System.Windows.Controls.TextBox)(target));
            
            #line 135 "..\..\..\Views\PermitView.xaml"
            this.txtContractorCity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LetterValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 18:
            this.txtContractorState = ((System.Windows.Controls.TextBox)(target));
            
            #line 137 "..\..\..\Views\PermitView.xaml"
            this.txtContractorState.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LetterValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 19:
            this.txtContractorZip = ((System.Windows.Controls.TextBox)(target));
            
            #line 139 "..\..\..\Views\PermitView.xaml"
            this.txtContractorZip.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 20:
            this.txtContractorPhone = ((System.Windows.Controls.TextBox)(target));
            
            #line 143 "..\..\..\Views\PermitView.xaml"
            this.txtContractorPhone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtContractorPhone_TextChanged);
            
            #line default
            #line hidden
            
            #line 143 "..\..\..\Views\PermitView.xaml"
            this.txtContractorPhone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PhoneNumberValidationTextBox);
            
            #line default
            #line hidden
            return;
            case 21:
            this.rdoAffidavit = ((System.Windows.Controls.RadioButton)(target));
            
            #line 165 "..\..\..\Views\PermitView.xaml"
            this.rdoAffidavit.Checked += new System.Windows.RoutedEventHandler(this.rdoAffidavit_Checked);
            
            #line default
            #line hidden
            return;
            case 22:
            this.rdoAddress = ((System.Windows.Controls.RadioButton)(target));
            
            #line 166 "..\..\..\Views\PermitView.xaml"
            this.rdoAddress.Checked += new System.Windows.RoutedEventHandler(this.rdoAddress_Checked);
            
            #line default
            #line hidden
            return;
            case 23:
            this.txtAffidavitSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\..\Views\PermitView.xaml"
            this.txtAffidavitSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtAffidavitSearch_TextChanged);
            
            #line default
            #line hidden
            
            #line 171 "..\..\..\Views\PermitView.xaml"
            this.txtAffidavitSearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtAffidavitSearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 24:
            this.affidavitSuggestionList = ((System.Windows.Controls.ListBox)(target));
            
            #line 172 "..\..\..\Views\PermitView.xaml"
            this.affidavitSuggestionList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.affidavitSuggestionList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 25:
            this.txtPropertySearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 178 "..\..\..\Views\PermitView.xaml"
            this.txtPropertySearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtPropertySearch_TextChanged);
            
            #line default
            #line hidden
            
            #line 178 "..\..\..\Views\PermitView.xaml"
            this.txtPropertySearch.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtPropertySearch_KeyUp);
            
            #line default
            #line hidden
            return;
            case 26:
            this.PropertySuggestionList = ((System.Windows.Controls.ListBox)(target));
            
            #line 179 "..\..\..\Views\PermitView.xaml"
            this.PropertySuggestionList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PropertySuggestionList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 27:
            this.txtInspector = ((System.Windows.Controls.TextBox)(target));
            return;
            case 28:
            this.txtInspectionDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 29:
            this.txtNoticeSent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.txtPropertyOwner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 31:
            this.txtPropertyDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 32:
            this.affidavitFee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 33:
            this.txtExpirationDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 34:
            this.txtMinFee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.txtMaxFee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 36:
            this.txtFee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 37:
            this.browser = ((System.Windows.Controls.WebBrowser)(target));
            return;
            case 38:
            this.chkLegal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 253 "..\..\..\Views\PermitView.xaml"
            this.chkLegal.Checked += new System.Windows.RoutedEventHandler(this.chkLegal_Checked);
            
            #line default
            #line hidden
            
            #line 253 "..\..\..\Views\PermitView.xaml"
            this.chkLegal.Unchecked += new System.Windows.RoutedEventHandler(this.chkLegal_Unchecked);
            
            #line default
            #line hidden
            return;
            case 39:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 259 "..\..\..\Views\PermitView.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Documents.Hyperlink.ClickEvent;
            
            #line 56 "..\..\..\Views\PermitView.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.OnHyperlinkClickRemoveAffidavit);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

