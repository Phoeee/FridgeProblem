using System;
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
        // declaring Messages and Titles of the Message Boxes
        private const string allParametersMessage = "Please enter all parameters";
        private const string zeroMessage = "Size can't be 0!";
        private const string errorTitle = "Error!";
        private const string resultTitle = "Result";
        private const string positiveMessage = "Positive";
        private const string negativeMessage = "Negative";


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
            //labelResult.Content = string.Empty;
        }
        
        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            var solution = new FridgePushIn();
            try
            {
                switch (comboBoxFridgeShape.SelectedIndex)
                {
                    case 0:
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Circle(double.Parse(textBoxWindowDiameter.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
                            }

                            //output results
                            if (check)
                            {
                                MessageBox.Show(positiveMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show(negativeMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Stop);
                            }
                        }
                        break;
                    case 1:
                        if (textBoxFridgeHeight.Text == string.Empty ||
                    textBoxFridgeDiameter.Text == string.Empty)
                        {
                            MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        // check if user entered zero as size
                        if (double.Parse(textBoxFridgeHeight.Text) == 0 ||
                            double.Parse(textBoxFridgeDiameter.Text) == 0)
                        {
                            MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            var checkingFridge = new Cylinder(double.Parse(textBoxFridgeHeight.Text),
                                double.Parse(textBoxFridgeDiameter.Text));
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                //var solution = new FridgePushIn();
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Circle(double.Parse(textBoxWindowDiameter.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
                            }
                            //output results
                            if (check)
                            {
                                MessageBox.Show(positiveMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show(negativeMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Stop);
                            }
                        }
                        break;
                    case 2:
                        if (textBoxFridgeDiameter.Text == string.Empty)
                        {
                            MessageBox.Show(allParametersMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        // check if user entered zero as size
                        if (double.Parse(textBoxFridgeDiameter.Text) == 0)
                        {
                            MessageBox.Show(zeroMessage, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            var checkingFridge = new Sphere(double.Parse(textBoxFridgeDiameter.Text));
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Rectangle(double.Parse(textBoxDoorwayHeight.Text),
                                    double.Parse(textBoxDoorwayWidth.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
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
                                var checkingHole = new Circle(double.Parse(textBoxWindowDiameter.Text));
                                check = solution.PushInCheck(checkingFridge, checkingHole);
                            }
                            //output results
                            if (check)
                            {
                                MessageBox.Show(positiveMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show(negativeMessage, resultTitle, MessageBoxButton.OK, MessageBoxImage.Stop);
                            }
                        }
                        break;

                }
            }
            //exception if input numbers are to big
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, errorTitle, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ComboBoxRectangle_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (ComponentsInNullCheck())
            {
                return;
            }
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
            if (ComponentsInNullCheck())
            {
                return;
            }
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
            if (ComponentsInNullCheck())
            {
                return;
            }
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

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private bool ComponentsInNullCheck()
        {
            bool check = false;
            if (labelWindow == null ||
                labelDw == null ||
                textBoxWindowDiameter == null ||
                textBoxDoorwayHeight == null ||
                textBoxDoorwayWidth == null)
            {
                check = true;
            }
            return check;
        }

        private bool IsNumber(string inputText)
        {
            return int.TryParse(inputText, out var output);
        }

        private void ComboBoxCuboid_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (ComponentsInNullCheck())
            {
                return;
            }
            //make visible components for cuboid fridge
            labelFrHeight.Visibility = Visibility.Visible;
            labelFrLength.Visibility = Visibility.Visible;
            labelFrWidth.Visibility = Visibility.Visible;
            labelFridgeDiameter.Visibility = Visibility.Hidden;
            textBoxFridgeHeight.Visibility = Visibility.Visible;
            textBoxFridgeLength.Visibility = Visibility.Visible;
            textBoxFridgeWidth.Visibility = Visibility.Visible;
            textBoxFridgeDiameter.Visibility = Visibility.Hidden;
        }

        private void ComboBoxCylinder_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (ComponentsInNullCheck())
            {
                return;
            }
            //make visible components for cylinder fridge
            labelFrHeight.Visibility = Visibility.Visible;
            labelFrLength.Visibility = Visibility.Hidden;
            labelFrWidth.Visibility = Visibility.Hidden;
            labelFridgeDiameter.Visibility = Visibility.Visible;
            textBoxFridgeHeight.Visibility = Visibility.Visible;
            textBoxFridgeLength.Visibility = Visibility.Hidden;
            textBoxFridgeWidth.Visibility = Visibility.Hidden;
            textBoxFridgeDiameter.Visibility = Visibility.Visible;
        }

        private void ComboBoxSphere_Selected(object sender, RoutedEventArgs e)
        {
            //check if components were initialized
            if (ComponentsInNullCheck())
            {
                return;
            }
            //make visible components for sphere fridge
            labelFrHeight.Visibility = Visibility.Hidden;
            labelFrLength.Visibility = Visibility.Hidden;
            labelFrWidth.Visibility = Visibility.Hidden;
            labelFridgeDiameter.Visibility = Visibility.Visible;
            textBoxFridgeHeight.Visibility = Visibility.Hidden;
            textBoxFridgeLength.Visibility = Visibility.Hidden;
            textBoxFridgeWidth.Visibility = Visibility.Hidden;
            textBoxFridgeDiameter.Visibility = Visibility.Visible;
        }
    }
}