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
using System.Windows.Shapes;
using ListClass.Classes;

namespace ListClass
{
    /// <summary>
    /// Логика взаимодействия для WindowAddPreparate.xaml
    /// </summary>
    public partial class WindowAddPreparate : Window
    {
        public WindowAddPreparate()
        {
            InitializeComponent();
        }

        private void BtnAddPreparate_Click(object sender, RoutedEventArgs e)
        {
            STUDENT student = new STUDENT()
            {
                Name = TxbName.Text,
                Group = TxbGroup.Text,
                Math = int.Parse(TxbMath.Text),
                History = int.Parse(TxbHistory.Text),
                Physics = int.Parse(TxbPhysics.Text),
                Obzh = int.Parse(TxbObzh.Text),
                French = int.Parse(TxbFrench.Text),
            };

                ConnectHelper.student.Add(student);
            this.Close();
        }
    }
}
