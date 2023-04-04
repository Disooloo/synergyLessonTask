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

namespace FirtwindowsAppTask3.assets.view.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        private int MAX_VALUE_LENGTH = 10;
        private string _ValueToConvert = string.Empty;
        private readonly char comma = ',';
        public Task3Page()
        {
            InitializeComponent();
        }

        #region Button
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => AssingNum(Btn1);
        private void Button_Click(object sender, RoutedEventArgs e) => AssingNum(Btn2);
        private void Btn3_Click(object sender, RoutedEventArgs e) => AssingNum(Btn3);
        private void Btn4_Click(object sender, RoutedEventArgs e) => AssingNum(Btn4);
        private void Btn5_Click(object sender, RoutedEventArgs e) => AssingNum(Btn5);
        private void Btn6_Click(object sender, RoutedEventArgs e) => AssingNum(Btn6);
        private void Btn7_Click(object sender, RoutedEventArgs e) => AssingNum(Btn7);
        private void Btn8_Click(object sender, RoutedEventArgs e) => AssingNum(Btn8);
        private void Btn9_Click(object sender, RoutedEventArgs e) => AssingNum(Btn9);
        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (_ValueToConvert.Contains(comma))
                return;
            AssingNum(Comma);
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (_ValueToConvert.Length < 1)
                return;
            AssingNum(Btn0);
        }
        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (DegressLabal1.Text == "0")
                return;

            var _value = Convert.ToDouble(_ValueToConvert) * -1;
            _ValueToConvert = _value.ToString();
            UpdateDegressLabal();
            UpdateRadiansLabel();
        }

        private void ClearFull_Click(object sender, RoutedEventArgs e) => AssingZeroValues();
        private void RemoveLastChar_Click(object sender, RoutedEventArgs e)
        {
            if (_ValueToConvert.Length <= 1)
            {
                AssingZeroValues();
                return;
            }
            _ValueToConvert = _ValueToConvert.Remove(_ValueToConvert.Length - 1, 1);
            UpdateDegressLabal();
            UpdateRadiansLabel();
        }

        #endregion


        private void AssingNum(Button button)
        {
            if (_ValueToConvert.Length >= MAX_VALUE_LENGTH)
                return;

            _ValueToConvert += button.Content;
            UpdateDegressLabal();
            UpdateRadiansLabel();
        }

        private void UpdateDegressLabal()
        {
            DegressLabal1.Text = _ValueToConvert;
        }

        private void UpdateRadiansLabel()
        {
            var valueToConvert = Convert.ToDouble(_ValueToConvert);
            var radians = valueToConvert * Math.PI / 180.0d;

            var readText = radians.ToString().Substring(0, MAX_VALUE_LENGTH);

            if (readText[readText.Length - 1] == comma)
                readText = readText.Remove(readText.Length - 1, 1);

            RadiansLabel.Text = readText;
        }

        private void AssingZeroValues()
        {
            _ValueToConvert = string.Empty;
            RadiansLabel.Text = "0";
            DegressLabal1.Text = "0";
        }



}
}
