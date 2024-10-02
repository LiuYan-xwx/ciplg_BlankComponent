using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ciplg_BlankComponent
{
    /// <summary>
    /// BlankComponent.xaml 的交互逻辑
    /// </summary>
    [ComponentInfo(
        "546CCD02-DCB4-59D8-DF74-5770EF2AD91C",
        "空白",
        PackIconKind.CheckboxBlankOutline,
        "显示一片空白。"
    )]
    public partial class BlankComponent : ComponentBase<BlankComponentSettings>
    {
        public BlankComponent()
        {
            InitializeComponent();
        }
    }
}
