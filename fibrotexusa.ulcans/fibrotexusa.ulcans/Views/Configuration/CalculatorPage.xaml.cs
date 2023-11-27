using System;
using Xamarin.Forms;

namespace fibrotexusa.ulcans.Views.Configuration
{
    public partial class CalculatorPage : ContentPage
    {
        double height, length, width;

        public CalculatorPage()
        {
            InitializeComponent();
            ddmUnit.SelectedIndex = 0;
        }

        async void OnBackBtn_Clicked(object sender, EventArgs e)
        {
            TypicalConfigPage destination = new TypicalConfigPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        async void OnNextBtnClicked(object sender, EventArgs e)
        {
            ConfigListPage destination = new ConfigListPage();
            await Navigation.PushAsync(destination, false).ConfigureAwait(false);
        }

        public void UnitSelector()
        {

        }

        public void OnCalculateBtn_Clicked(object sender, EventArgs e)
        {
            if (CheckForInput(txtHeight, txtLength, txtWidth) == true)
            {
                // Reset Form Controls colors
                txtHeight.BackgroundColor = Color.White;
                txtWidth.BackgroundColor = Color.White;
                txtHeight.BackgroundColor = Color.White;

                if (ddmUnit.SelectedIndex == 1)
                {
                    // Convert measurements from meters back to feet
                    height = float.Parse(txtHeight.Text) * 3.2808;
                    width = double.Parse(txtWidth.Text) * 3.2808;
                    length = double.Parse(txtLength.Text) * 3.2808;
                }
                else
                {
                    height = float.Parse(txtHeight.Text);
                    width = double.Parse(txtWidth.Text);
                    length = double.Parse(txtLength.Text);
                }

                double formulaA = (2 * (height + 2)) + width + 5;
                double formulaB = (2 * (height + 2)) + length + 5;

                // Potential Logic using Formula A and B 
                if (formulaA > 0 && formulaA < 25 && formulaB > 0 && formulaB < 25)
                {
                    lblResult.Text = "Number of Modules Needed = 1 Rhombus.";
                }
                else if (formulaA > 25 && formulaA < 60 && formulaB > 25 && formulaB < 60)
                {
                    lblResult.Text = "Number of Modules Needed = 2.";
                }
                else if (formulaA > 60 && formulaA <= 90 && formulaB > 60 && formulaB <= 90)
                {
                    lblResult.Text = "Number of Modules Needed = 3.";
                }
                else if (formulaA > 90 && formulaA <= 120 && formulaB > 90 && formulaB <= 120)
                {
                    lblResult.Text = "Number of Modules Needed = 4.";
                }
                else if (formulaA > 120 && formulaA <= 150 && formulaB > 120 && formulaB <= 150)
                {
                    lblResult.Text = "Number of Modules Needed = 5.";
                }
                else if (formulaA > 150 && formulaA <= 180 && formulaB > 150 && formulaB <= 180)
                {
                    lblResult.Text = "Number of Modules Needed = 6.";
                }
                else if (formulaA > 180 && formulaB > 180)
                {
                    lblResult.Text = "Consult Table on Typical ULCANS Configurations.\nCustom configuration may be necessary.";
                }
            }
            else
            {
                if (txtHeight.Text == null)
                {
                    txtHeight.BackgroundColor = Color.Red;
                }
                else if (txtWidth.Text == null)
                {
                    txtWidth.BackgroundColor = Color.Red;
                }
                else if (txtLength.Text == null)
                {
                    txtLength.BackgroundColor = Color.Red;
                }
            }
        }

        public void OnClearBtn_Clicked(object sender, EventArgs e)
        {
            // Reset Textboxes
            txtHeight.Text = "";
            txtHeight.BackgroundColor = Color.White;
            txtWidth.Text = "";
            txtWidth.BackgroundColor = Color.White;
            txtLength.Text = "";
            txtLength.BackgroundColor = Color.White;

            // Reset Labels
            lblResult.Text = "";
        }

        public bool CheckForInput(Entry txt1, Entry txt2, Entry txt3)
        {
            if (txt1.Text != "" && txt1.Text != null &&
                txt2.Text != "" && txt2.Text != null &&
                txt3.Text != "" && txt3.Text != null)
            {
                // Reset Form Controls colors
                txtHeight.BackgroundColor = Color.White;
                txtWidth.BackgroundColor = Color.White;
                txtHeight.BackgroundColor = Color.White;

                return true;
            }
            else
            {
                lblResult.TextColor = Color.Red;
                lblResult.Text = "Make sure all three measurements are filled in.";

                return false;
            }
        }

        public double FindAreaSquare(double myLength, double myWidth)
        {
            return _ = myLength * myWidth;
        }

        public double FindAreaRhombus(double myLength, double myWidth)
        {
            return _ = (myLength * myWidth) / 2;
        }

        public double FindAreaHexagon(double mySide)
        {
            return _ = (3 * Math.Sqrt(3) / 2) * Math.Pow(mySide, 2);
        }
    }
}
