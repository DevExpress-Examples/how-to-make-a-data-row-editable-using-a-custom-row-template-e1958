using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Utils.Themes;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core;
using System.Collections;
using System.Windows.Threading;

namespace DXGridTest {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for(int i = 0; i < 100; i++)
                list.Add(new TestData() { Text = "Row" + i, Number = i, Group = i % 3 });
            grid.ItemsSource = list;
        }
    }

    public class MyTableView : TableView {
        protected override void OnKeyUp(KeyEventArgs e) {
        }
        protected override void OnKeyDown(KeyEventArgs e) {
            if(e.Key == Key.Tab)
                return;
            base.OnKeyDown(e);
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
        public int Group { get; set; }
    }
}
