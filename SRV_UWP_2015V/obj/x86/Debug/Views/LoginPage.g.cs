﻿#pragma checksum "C:\Chelsea\SRV_UWP_2015V\SRV_UWP_2015V\Views\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3F2D0E200B1198B9084300F5339C6705E2333480A1BBDC258AC50E8DE48D6B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRV_UWP_2015V.Views
{
    partial class LoginPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.txbFooter = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.txtId = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.txtPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4:
                {
                    this.btnLogin = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\Views\LoginPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnLogin).Click += this.btnLogin_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.txbWelcome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.logo_TAFESA = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
