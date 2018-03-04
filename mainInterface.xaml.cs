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

namespace Hotel_Management_System
{
    /// <summary>
    /// Interaction logic for mainInterface.xaml
    /// </summary>
    public partial class mainInterface : Window
    {
        public mainInterface()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFRice.Text = "0";
            txtcVinadaloo.Text = "0";
            txtrChiken.Text = "0";
            txtbRoulade.Text = "0";
            txtdApple.Text = "0";
            txtkBiryani.Text = "0";
            txtmBiryani.Text = "0";
            txtBurger.Text = "0";
            txtPizza.Text = "0";
            txtpKnuckle.Text = "0";
            txtSamusa.Text = "0";
            txtcLollypop.Text = "0";
            txtDrinks.Text = "0";
            txthDelivery.Text = "0";
            txtDrinks.Text = "0";
            txthDelivery.Text = "0";
            tbTotalCost.Text = String.Format("{0:C}", 0);
            tbDrinks.Text = String.Format("{0:C}", 0);
            tbCostDelivery.Text = String.Format("{0:C}", 0);
            tbSub.Text = String.Format("{0:C}", 0);
            tbtax.Text = String.Format("{0:C}", 0);
            tbTotal.Text = String.Format("{0:C}", 0);

            chkfRice.IsChecked = false;
            chkcVinadaloo.IsChecked = false;
            chkrChiken.IsChecked = false;
            chkbRoulade.IsChecked = false;
            chkdApple.IsChecked = false;
            chkkBiryani.IsChecked = false;
            chkmBiryani.IsChecked = false;
            chkBurger.IsChecked = false;
            chkPizza.IsChecked = false;
            chkpKnuckle.IsChecked = false;
            chkSamosa.IsChecked = false;
            chkcLollypop.IsChecked = false;
            chkDrinks.IsChecked = false;
            chkhDelivery.IsChecked = false;


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtFRice.Text = "0";
            txtcVinadaloo.Text = "0";
            txtrChiken.Text = "0";
            txtbRoulade.Text = "0";
            txtdApple.Text = "0";
            txtkBiryani.Text = "0";
            txtmBiryani.Text = "0";
            txtBurger.Text = "0";
            txtPizza.Text = "0";
            txtpKnuckle.Text = "0";
            txtSamusa.Text = "0";
            txtcLollypop.Text = "0";
            txtDrinks.Text = "0";
            txthDelivery.Text = "0";
            txtDrinks.Text = "0";
            txthDelivery.Text = "0";

            tbTotalCost.Text = String.Format("{0:C}",0);
            tbDrinks.Text = String.Format("{0:C}", 0);
            tbCostDelivery.Text = String.Format("{0:C}", 0);
            tbSub.Text = String.Format("{0:C}", 0);
            tbtax.Text = String.Format("{0:C}", 0);
            tbTotal.Text = String.Format("{0:C}", 0);

            txtFRice.IsEnabled = false;
            txtcVinadaloo.IsEnabled = false;
            txtrChiken.IsEnabled = false;
            txtbRoulade.IsEnabled = false;
            txtdApple.IsEnabled = false;
            txtkBiryani.IsEnabled = false;
            txtmBiryani.IsEnabled = false;
            txtBurger.IsEnabled = false;
            txtPizza.IsEnabled = false;
            txtpKnuckle.IsEnabled = false;
            txtSamusa.IsEnabled = false;
            txtcLollypop.IsEnabled = false;
            txtDrinks.IsEnabled = false;
            txthDelivery.IsEnabled = false;



            chkfRice.IsChecked = false;
            chkcVinadaloo.IsChecked = false;
            chkrChiken.IsChecked = false;
            chkbRoulade.IsChecked = false;
            chkdApple.IsChecked = false;
            chkkBiryani.IsChecked = false;
            chkmBiryani.IsChecked = false;
            chkBurger.IsChecked = false;
            chkPizza.IsChecked = false;
            chkpKnuckle.IsChecked = false;
            chkSamosa.IsChecked = false;
            chkcLollypop.IsChecked = false;
            chkDrinks.IsChecked = false;
            chkhDelivery.IsChecked = false;
        }

        private void chkfRice_Checked(object sender, RoutedEventArgs e)
        {
            if(chkfRice.IsChecked == true)
            {
                txtFRice.IsEnabled = true;
            }
        }

        private void chkfRice_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkfRice.IsChecked == false)
            {
                txtFRice.IsEnabled = false;
                txtFRice.Text = "0";
            }
        }

        private void txtFRice_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFRice.Text = "";
            txtFRice.Focus();

        }

        private void chkcVinadaloo_Checked(object sender, RoutedEventArgs e)
        {
            if (chkcVinadaloo.IsChecked == true)
            {
                txtcVinadaloo.IsEnabled = true;
            }
        }

        private void chkcVinadaloo_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkcVinadaloo.IsChecked == false)
            {
                txtcVinadaloo.IsEnabled = false;
                txtcVinadaloo.Text = "0";
            }
        }

        private void txtcVinadaloo_GotFocus(object sender, RoutedEventArgs e)
        {
            txtcVinadaloo.Text = "";
            txtcVinadaloo.Focus();
        }

        private void chkrChiken_Checked(object sender, RoutedEventArgs e)
        {
            if (chkrChiken.IsChecked == true)
            {
                txtrChiken.IsEnabled = true;
            }
        }

        private void chkrChiken_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkrChiken.IsChecked == false)
            {
                txtrChiken.IsEnabled = false;
                txtrChiken.Text = "0";
            }
        }

        private void txtrChiken_GotFocus(object sender, RoutedEventArgs e)
        {
            txtrChiken.Text = "";
            txtrChiken.Focus();
        }

        private void chkbRoulade_Checked(object sender, RoutedEventArgs e)
        {
            if (chkbRoulade.IsChecked == true)
            {
                txtbRoulade.IsEnabled = true;
            }
        }

        private void chkbRoulade_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkbRoulade.IsChecked == false)
            {
                txtbRoulade.IsEnabled = false;
                txtbRoulade.Text = "0";
            }
        }

        private void txtbRoulade_GotFocus(object sender, RoutedEventArgs e)
        {
            txtbRoulade.Text = "";
            txtbRoulade.Focus();
        }

        private void chkdApple_Checked(object sender, RoutedEventArgs e)
        {
            if (chkdApple.IsChecked == true)
            {
                txtdApple.IsEnabled = true;
            }
        }

        private void chkdApple_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkdApple.IsChecked == false)
            {
                txtdApple.IsEnabled = false;
                txtdApple.Text = "0";
            }
        }

        private void txtdApple_GotFocus(object sender, RoutedEventArgs e)
        {
            txtdApple.Text = "";
            txtdApple.Focus();
        }

        private void chkkBiryani_Checked(object sender, RoutedEventArgs e)
        {
            if (chkkBiryani.IsChecked == true)
            {
                txtkBiryani.IsEnabled = true;
            }
        }

        private void chkkBiryani_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkkBiryani.IsChecked == false)
            {
                txtkBiryani.IsEnabled = false;
                txtkBiryani.Text = "0";
            }

        }

        private void txtkBiryani_GotFocus(object sender, RoutedEventArgs e)
        {
            txtkBiryani.Text = "";
            txtkBiryani.Focus();

        }

        private void chkmBiryani_Checked(object sender, RoutedEventArgs e)
        {
            if (chkmBiryani.IsChecked == true)
            {
                txtmBiryani.IsEnabled = true;
            }
        }

        private void txtmBiryani_GotFocus(object sender, RoutedEventArgs e)
        {
            txtmBiryani.Text = "";
            txtmBiryani.Focus();

        }

        private void chkBurger_Checked(object sender, RoutedEventArgs e)
        {
            if (chkBurger.IsChecked == true)
            {
                txtBurger.IsEnabled = true;
            }

        }

        private void chkBurger_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkBurger.IsChecked == false)
            {
                txtBurger.IsEnabled = false;
                txtBurger.Text = "0";
            }
        }

        private void txtBurger_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBurger.Text = "";
            txtBurger.Focus();

        }

        private void chkPizza_Checked(object sender, RoutedEventArgs e)
        {
            if (chkPizza.IsChecked == true)
            {
                txtPizza.IsEnabled = true;
            }
        }

        private void chkPizza_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkPizza.IsChecked == false)
            {
                txtPizza.IsEnabled = false;
                txtPizza.Text = "0";
            }
        }

        private void txtPizza_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPizza.Text = "";
            txtPizza.Focus();
        }

        private void chkpKnuckle_Checked(object sender, RoutedEventArgs e)
        {
            if (chkpKnuckle.IsChecked == true)
            {
                txtpKnuckle.IsEnabled = true;
            }
        }

        private void chkpKnuckle_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkpKnuckle.IsChecked == false)
            {
                txtpKnuckle.IsEnabled = false;
                txtpKnuckle.Text = "0";
            }
        }

        private void txtpKnuckle_GotFocus(object sender, RoutedEventArgs e)
        {
            txtpKnuckle.Text = "";
            txtpKnuckle.Focus();

        }

        private void chkSamosa_Checked(object sender, RoutedEventArgs e)
        {
            if (chkSamosa.IsChecked == true)
            {
                txtSamusa.IsEnabled = true;
            }

        }

        private void chkSamosa_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkSamosa.IsChecked == false)
            {
                txtSamusa.IsEnabled = false;
                txtSamusa.Text = "0";
            }
        }

        private void txtSamusa_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSamusa.Text = "";
            txtSamusa.Focus();

        }

        private void chkcLollypop_Checked(object sender, RoutedEventArgs e)
        {
            if (chkcLollypop.IsChecked == true)
            {
                txtcLollypop.IsEnabled = true;
            }
        }

        private void chkcLollypop_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkcLollypop.IsChecked == false)
            {
                txtcLollypop.IsEnabled = false;
                txtcLollypop.Text = "0";
            }
        }

        private void txtcLollypop_GotFocus(object sender, RoutedEventArgs e)
        {
            txtcLollypop.Text = "";
            txtcLollypop.Focus();

        }

        private void chkDrinks_Checked(object sender, RoutedEventArgs e)
        {
            if (chkDrinks.IsChecked == true)
            {
                txtDrinks.IsEnabled = true;
            }
        }

        private void chkDrinks_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkDrinks.IsChecked == false)
            {
                txtDrinks.IsEnabled = false;
                txtDrinks.Text = "0";
            }
        }

        private void txtDrinks_GotFocus(object sender, RoutedEventArgs e)
        {
            txtDrinks.Text = "";
            txtDrinks.Focus();
        }

        private void chkhDelivery_Checked(object sender, RoutedEventArgs e)
        {
            if (chkhDelivery.IsChecked == true)
            {
                txthDelivery.IsEnabled = true;
            }
        }

        private void chkhDelivery_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chkhDelivery.IsChecked == false)
            {
                txthDelivery.IsEnabled = false;
                txthDelivery.Text = "0";
            }

        }

        private void txthDelivery_GotFocus(object sender, RoutedEventArgs e)
        {
            txthDelivery.Text = "";
            txthDelivery.Focus();
        }

        private void btnReceipt_Click(object sender, RoutedEventArgs e)
        {
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Just Do Restaurant" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "_________________________________________" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Fride Rice \t\t\t\t" + txtFRice.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Chiken Vinadaloo \t\t\t" + txtcVinadaloo.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Rosted Chiken \t\t\t" + txtrChiken.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Beef Roulade \t\t\t" + txtbRoulade.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Duck With Apple \t\t\t" + txtdApple.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Kozhi(Chiken) Biryani \t\t" + txtkBiryani.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Muttai(Egg) Biryani \t\t\t" + txtmBiryani.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Burger \t\t\t\t" + txtBurger.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Pizza \t\t\t\t" + txtPizza.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Pork Knuckle  \t\t\t" + txtpKnuckle.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Samosa  \t\t\t\t" + txtSamusa.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Chiken Lollypop \t\t\t" + txtcLollypop.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Drinks \t\t\t\t" + txtDrinks.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Home Delivery pakage \t\t" + txthDelivery.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "_________________________________________" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Tax \t\t\t" + tbtax.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Sub Total \t\t\t" + tbSub.Text + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "_________________________________________" + Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Total \t\t\t" + tbTotal.Text + Environment.NewLine);


        }

        private void btnCostMeal_Click(object sender, RoutedEventArgs e)
        {
            double tax;
            tax = .45;

            double FRice, cVinadaloo,rChiken,bRoulade,dApple,kBiryani,mBiryani;
            double Burger, Pizza, pKnuckle, Samusa, cLollypop, Drinks, hDelivery;

            //First Panel
            FRice = 5.00; cVinadaloo = 8.00; rChiken=10.00; bRoulade =12.00; dApple = 6.00;kBiryani = 18.00;mBiryani = 20.00;

            double F_Rice = Convert.ToDouble(txtFRice.Text);
            double c_Vinadaloo = Convert.ToDouble(txtcVinadaloo.Text);
            double r_Chiken = Convert.ToDouble(txtrChiken.Text);
            double b_Roulade = Convert.ToDouble(txtbRoulade.Text);
            double d_Apple = Convert.ToDouble(txtdApple.Text);
            double k_Biryani = Convert.ToDouble(txtkBiryani.Text);
            double m_Biryani = Convert.ToDouble(txtmBiryani.Text);

            //Second panel

            Burger = 6.20; Pizza = 7.20; pKnuckle = 10.40; Samusa = 8.60; cLollypop =6.60; Drinks = 4.00; hDelivery =60.00;
            double Burger_S = Convert.ToDouble(txtBurger.Text);
            double Pizza_S = Convert.ToDouble(txtPizza.Text);
            double pKnuckle_S = Convert.ToDouble(txtpKnuckle.Text);
            double Samusa_S = Convert.ToDouble(txtSamusa.Text);
            double cLollypop_S = Convert.ToDouble(txtcLollypop.Text);
            double Drinks_S = Convert.ToDouble(txtDrinks.Text);
            double hDelivery_S = Convert.ToDouble(txthDelivery.Text);


            Restaurant eat_In = new Restaurant(F_Rice, c_Vinadaloo, r_Chiken, b_Roulade, d_Apple, k_Biryani, m_Biryani,
                Burger_S, Pizza_S, pKnuckle_S, Samusa_S, cLollypop_S, Drinks_S, hDelivery_S);

            double eat_in_meal = (F_Rice * FRice) + (c_Vinadaloo * cVinadaloo) + (rChiken * r_Chiken) + (bRoulade * b_Roulade) + (d_Apple * dApple) + (k_Biryani * kBiryani) + (m_Biryani * mBiryani) +
                (Burger_S * Burger) + (Pizza_S * Pizza) + (pKnuckle_S * pKnuckle) + (Samusa_S * Samusa) + (cLollypop_S * cLollypop);

            tbTotalCost.Text = Convert.ToString(eat_in_meal);
            double drinks = (Drinks_S * Drinks);

            tbDrinks.Text = Convert.ToString(drinks);

            double delivery = (hDelivery_S * hDelivery);
            tbCostDelivery.Text = Convert.ToString(delivery);

            tbSub.Text = Convert.ToString(eat_in_meal+ drinks+ delivery);
            tbtax.Text = Convert.ToString(((eat_in_meal + drinks+ delivery)*tax)/100);
            double iTax = Convert.ToDouble(tbtax.Text);

            tbTotal.Text = Convert.ToString(eat_in_meal+ drinks+ delivery+ iTax);

            tbTotalCost.Text = String.Format("{0:C}", eat_in_meal);
            tbDrinks.Text = String.Format("{0:C}", drinks);
            tbCostDelivery.Text = String.Format("{0:C}", delivery);
            tbSub.Text = String.Format("{0:C}", (eat_in_meal + drinks + delivery));
            tbtax.Text = String.Format("{0:C}", iTax);
            tbTotal.Text = String.Format("{0:C}", (eat_in_meal + drinks + delivery + iTax));

        }
    }
}
