﻿#pragma checksum "..\..\..\Windows\ItemWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75897662DFFE879B04AB5F28A7FC59C67ACB92D3DCC9F2CE3DD3610E5BD3188E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MuseumApp.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
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


namespace MuseumApp.Windows {
    
    
    /// <summary>
    /// ItemWindow
    /// </summary>
    public partial class ItemWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button item_add;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button item_upd;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button item_del;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Item_table;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button upd_table;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_tb;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancel_b;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label id_l;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\ItemWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button item_dell;
        
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
            System.Uri resourceLocater = new System.Uri("/MuseumApp;component/windows/itemwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\ItemWindow.xaml"
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
            this.item_add = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Windows\ItemWindow.xaml"
            this.item_add.Click += new System.Windows.RoutedEventHandler(this.item_add_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.item_upd = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Windows\ItemWindow.xaml"
            this.item_upd.Click += new System.Windows.RoutedEventHandler(this.item_upd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.item_del = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Windows\ItemWindow.xaml"
            this.item_del.Click += new System.Windows.RoutedEventHandler(this.item_del_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Item_table = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.upd_table = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Windows\ItemWindow.xaml"
            this.upd_table.Click += new System.Windows.RoutedEventHandler(this.upd_table_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.id_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cancel_b = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\ItemWindow.xaml"
            this.cancel_b.Click += new System.Windows.RoutedEventHandler(this.cancel_b_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.id_l = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.item_dell = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Windows\ItemWindow.xaml"
            this.item_dell.Click += new System.Windows.RoutedEventHandler(this.item_dell_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

