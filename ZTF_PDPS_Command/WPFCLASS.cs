
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Tecnomatix.Engineering.Ui.WPF;
using Tecnomatix.Engineering;

namespace ZTF_PDPS_Command
{
    public class WPFCLASS : TxButtonCommand
    {
        public override string Category =>"";

        public override string Name => "aa";

        public override void Execute(object cmdParams)
        {
            Wind wind= new Wind();
            wind.Show();
        }
    }
    public class Wind : TxWindow, IComponentConnector, IStyleConnector
    {
        private bool _contentLoaded;
        public void Connect(int connectionId, object target)
        {
            throw new NotImplementedException();
        }

        public void InitializeComponent()
        {
            if (this._contentLoaded)
                return;
            this._contentLoaded = true;
            System.Windows.Application.LoadComponent((object)this, new Uri("UserControl1.xaml", UriKind.Relative));
        }
    }
}
