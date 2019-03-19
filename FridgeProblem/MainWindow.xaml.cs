using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FridgeProblem
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public void ClearAll()
        {
            //textBoxWindowDiameter.Clear();
            //textBoxDoorwayHeight.Clear();
            //textBoxDoorwayWidth.Clear();
            labelResult.Content = string.Empty;
        }

        private void buttonCheck_Click(object sender, RoutedEventArgs e)
        {
            // declaring Messages and Titles of the Message Boxes
            var allParametersMessage = "Please enter all parameters";
            var zeroMessage = "Size can't be 0!";
            var errorTitle = "Error!";
            var resultTitle = "Result";
            var positiveMessage = "Positive";
            var negativeMessage = "Negative";
            // check if all parameters of the fridge were entered
            if (textBoxFridgeHeight.Text == string.Empty ||
                textBoxFridgeLength.Text == string.Empty ||
                textBoxFridgeWidth.Text == string.Empty)
            {
                MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // check if user entered zero as size
            if (double.Parse(textBoxFridgeHeight.Text) == 0 ||
                double.Parse(textBoxFridgeLength.Text) == 0 ||
                double.Parse(textBoxFridgeWidth.Text) == 0)
            {
                MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var checkingFridge = new Cuboid(double.Parse(textBoxFridgeHeight.Text),
                    double.Parse(textBoxFridgeLength.Text),
                    double.Parse(textBoxFridgeWidth.Text));
                var check = false;
                if (comboBoxDoorway.SelectedItem == comboBoxDoorway.Items[0])
                {
                    // check if all parameters of the doorway were entered
                    if (textBoxDoorwayHeight.Text == string.Empty ||
                        textBoxDoorwayWidth.Text == string.Empty)
                    {
                        MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    // check if user entered zero as size

                    if (double.Parse(textBoxDoorwayHeight.Text) == 0 ||
                        double.Parse(textBoxDoorwayWidth.Text) == 0)
                    {
                        MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    var checkingDoorway = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                        double.Parse(textBoxDoorwayWidth.Text));
                    var solution = new FridgePushIn();
                    check = solution.PushInCheck(checkingFridge,checkingDoorway);
                }

                if (comboBoxDoorway.SelectedItem == comboBoxDoorway.Items[1])
                {
                    // check if all parameters of the window were entered
                    if (textBoxDoorwayHeight.Text == string.Empty ||
                        textBoxDoorwayWidth.Text == string.Empty)
                    {
                        MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    // check if user entered zero as size

                    if (double.Parse(textBoxDoorwayHeight.Text) == 0 ||
                        double.Parse(textBoxDoorwayWidth.Text) == 0)
                    {
                        MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    var checkingWindow = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                        double.Parse(textBoxDoorwayWidth.Text));
                    var solution = new FridgePushIn();
                    check = solution.PushInCheck(checkingFridge, checkingWindow);
                }

                if (comboBoxDoorway.SelectedItem == comboBoxDoorway.Items[2])
                {
                    // check if all parameters of the window were entered
                    if (textBoxWindowDiameter.Text == string.Empty)
                    {
                        MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    // check if user entered zero as size

                    if (double.Parse(textBoxWindowDiameter.Text) == 0)
                    {
                        MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    var checkingWindow = new Circle(double.Parse(textBoxWindowDiameter.Text));
                    var solution = new FridgePushIn();
                    check = solution.PushInCheck(checkingFridge, checkingWindow);
                }

                //output results
                if (check)
                    //labelResult.Content = "Positive";
                    MessageBox.Show(positiveMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Asterisk);

                else
                    //labelResult.Content = "Negative";
                    MessageBox.Show(negativeMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Stop);
            }
        }

        private void ComboBoxRectangle_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (labelWindow == null ||
                labelDw == null ||
                textBoxWindowDiameter == null ||
                textBoxDoorwayHeight == null ||
                textBoxDoorwayWidth == null ||
                labelDwHeight == null)
                return;
            //make visible components for doorway
            labelWindow.Visibility = Visibility.Hidden;
            labelDw.Visibility = Visibility.Visible;
            labelDwHeight.Visibility = Visibility.Visible;
            labelWindowDiameter.Visibility = Visibility.Hidden;
            textBoxWindowDiameter.Visibility = Visibility.Hidden;
            textBoxDoorwayHeight.Visibility = Visibility.Visible;
            textBoxDoorwayWidth.Visibility = Visibility.Visible;
            ClearAll();
        }

        private void ComboBoxRectangleWindow_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (labelWindow == null ||
                labelDw == null ||
                textBoxWindowDiameter == null ||
                textBoxDoorwayHeight == null ||
                textBoxDoorwayWidth == null)
                return;
            //make visible components for rectangle window
            labelDw.Visibility = Visibility.Hidden;
            labelWindow.Visibility = Visibility.Visible;
            labelDwHeight.Visibility = Visibility.Visible;
            labelDwWidth.Visibility = Visibility.Visible;
            labelWindowDiameter.Visibility = Visibility.Hidden;
            textBoxWindowDiameter.Visibility = Visibility.Hidden;
            textBoxDoorwayHeight.Visibility = Visibility.Visible;
            textBoxDoorwayWidth.Visibility = Visibility.Visible;
            ClearAll();
        }

        private void ComboBoxRoundWindow_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (labelWindow == null ||
                labelDw == null ||
                textBoxWindowDiameter == null ||
                textBoxDoorwayHeight == null ||
                textBoxDoorwayWidth == null)
                return;
            //make visible components for round window
            labelDw.Visibility = Visibility.Hidden;
            labelWindow.Visibility = Visibility.Visible;
            labelDwHeight.Visibility = Visibility.Hidden;
            labelDwWidth.Visibility = Visibility.Hidden;
            labelWindowDiameter.Visibility = Visibility.Visible;
            textBoxWindowDiameter.Visibility = Visibility.Visible;
            textBoxDoorwayHeight.Visibility = Visibility.Hidden;
            textBoxDoorwayWidth.Visibility = Visibility.Hidden;
            ClearAll();
        }

        protected void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // check if not number => not accept
            if (e.Text != "," && IsNumber(e.Text) == false)
            {
                e.Handled = true;
            }
            else if (e.Text == ",")
            {
                // check if dot in the beginning of number => not accept
                if (((TextBox)sender).Text.Length == 0)
                {
                    e.Handled = true;
                }
                // check if dot occurs ore than once in number => not accept
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private bool IsNumber(string inputText)
        {
            return int.TryParse(inputText, out var output);
        }

        private void ComboBoxCuboid_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void ComboBoxCylinder_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void ComboBoxSphere_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}