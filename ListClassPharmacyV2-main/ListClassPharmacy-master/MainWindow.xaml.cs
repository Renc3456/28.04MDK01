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
using ListClass.Classes;

namespace ListClass
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
       // List<Pharmacy> pharmacies = new List<Pharmacy>();
        public MainWindow()
        {
            InitializeComponent();
            ConnectHelper.student.Add(new STUDENT("Кислов Дмитрий Алексеевич","ИСП.19А" ,5, 4, 4, 5, 4));
            ConnectHelper.student.Add(new STUDENT("Панфилов Семен Натанович", "CCA.19А", 5, 3, 4, 4, 5));
            ConnectHelper.student.Add(new STUDENT("Русаков Альфред Натанович", "ИСП.21А", 4, 5, 5, 3, 5));
            ConnectHelper.student.Add(new STUDENT("Филатов Роман Федотович", "ТМ.20А", 5, 3, 4, 5, 4));
            ConnectHelper.student.Add(new STUDENT("Тихонов Антон Степанович", "ИСП.20", 5, 5, 4, 5, 3));
            ConnectHelper.student.Add(new STUDENT("Кириллов Платон Проклович", "ИСП.19А", 5, 5, 5, 5, 5));
            ConnectHelper.student.Add(new STUDENT("Фёдоров Никифор Антонович", "ТМ.21А", 5, 4, 3, 4, 5));
            ConnectHelper.student.Add(new STUDENT("Потапов Вячеслав Сергеевич", "ИСП.20А", 5, 4, 4, 5, 4));

            DtgListSTUDENT.ItemsSource = ConnectHelper.student;
            //pharmacies.Add(new Pharmacy("Цитрамон", 100, 199.90, 36));
            //pharmacies.Add(new Pharmacy("Парацетамол", 200, 279.90, 24));
            //pharmacies.Add(new Pharmacy("Нурофен", 255, 356.90, 24));
            //pharmacies.Add(new Pharmacy("Спазган", 99, 555.01, 36));
            //pharmacies.Add(new Pharmacy("Витамин C", 1000, 50.00, 12));
            //pharmacies.Add(new Pharmacy("Зодак", 5, 356.90, 24));
            //pharmacies.Add(new Pharmacy("Ибупрофен", 35, 555.01, 36));
            //pharmacies.Add(new Pharmacy("Пенталгин", 8, 50.00, 12));
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            DtgListSTUDENT.ItemsSource = ConnectHelper.student.ToList();
            DtgListSTUDENT.SelectedIndex = -1;
           
        }
        /// <summary>
        /// сортировка по алфавиту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbUp_Checked(object sender, RoutedEventArgs e)
        {
            DtgListSTUDENT.ItemsSource = ConnectHelper.student.OrderBy(x=>x.Name).ToList();
        }
        /// <summary>
        /// сортировка в обратном порядке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbDown_Checked(object sender, RoutedEventArgs e)
        {
            DtgListSTUDENT.ItemsSource = ConnectHelper.student.OrderByDescending(x => x.Name).ToList();
        }
        /// <summary>
        /// поиск по названию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DtgListSTUDENT.ItemsSource = ConnectHelper.student.Where(x => 
                x.Name.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();
        }

        /// <summary>
        /// фильтр по количеству
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    if (CmbFiltr.SelectedIndex == 0)
        //    {
        //        DtgListSTUDENT.ItemsSource = ConnectHelper.student.Where(x =>
        //            x.CountStudent >= 0 && x.CountStudent <= 10).ToList();
        //        MessageBox.Show("Недостаточное количество препаратов на складе!",
        //            "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //        if (CmbFiltr.SelectedIndex == 1)
        //    {
        //        DtgListPreparate.ItemsSource = ConnectHelper.pharmacies.Where(x =>
        //            x.CountPreparate >= 11 && x.CountPreparate <= 50).ToList();
        //        MessageBox.Show("Необходимо пополнить запасы препаратов в ближайшее время",
        //            "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
        //    }
        //    else
        //    {
        //        DtgListPreparate.ItemsSource = ConnectHelper.pharmacies.Where(x =>
        //           x.CountPreparate >= 51).ToList();
        //        MessageBox.Show("Достаточное количество препаратов на складе!",
        //            "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //}

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPreparate windowAdd = new WindowAddPreparate();
            windowAdd.ShowDialog();
        }

       

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            DtgListSTUDENT.ItemsSource = null;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
