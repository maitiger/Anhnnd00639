﻿#pragma checksum "D:\UWP\NguyenNgocAnh\CodeYami\CodeYami\Menu\Register.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B925354239CFD767D3B312AB30396923"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeYami.Menu
{
    partial class Register : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Menu\Register.xaml line 37
                {
                    this.BirthdayPicker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.BirthdayPicker).DateChanged += this.Birthday_DateChanged;
                }
                break;
            case 3: // Menu\Register.xaml line 38
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Do_Submit;
                }
                break;
            case 4: // Menu\Register.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Do_Reset;
                }
                break;
            case 5: // Menu\Register.xaml line 18
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Menu\Register.xaml line 19
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 7: // Menu\Register.xaml line 20
                {
                    this.FirtName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Menu\Register.xaml line 21
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Menu\Register.xaml line 22
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // Menu\Register.xaml line 23
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Menu\Register.xaml line 24
                {
                    this.AvatarUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // Menu\Register.xaml line 32
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element12 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element12).Checked += this.RadioButton_Checked;
                }
                break;
            case 13: // Menu\Register.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element13 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element13).Checked += this.RadioButton_Checked;
                }
                break;
            case 14: // Menu\Register.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element14 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element14).Checked += this.RadioButton_Checked;
                }
                break;
            case 15: // Menu\Register.xaml line 26
                {
                    this.Avatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // Menu\Register.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.Button element16 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element16).Click += this.Take_image;
                }
                break;
            case 17: // Menu\Register.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.Choose_Image;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
