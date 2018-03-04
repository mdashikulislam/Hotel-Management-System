using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Restaurant
    {
        public Restaurant()
        {
            newF_Rice = 0.0;
            newc_Vinadaloo = 0.0;
            newr_Chiken = 0.0;
            newb_Roulade = 0.0;
            newd_Apple = 0.0;
            newk_Biryani = 0.0;
            newm_Biryani = 0.0;

            newBurger_S = 0.0;
            newPizza_S = 0.0;
            newpKnuckle_S = 0.0;
            newSamusa_S = 0.0;
            newcLollypop_S = 0.0;
            newDrinks_S = 0.0;
            newhDelivery_S = 0.0;
        }

        //Overload Constroctor
        public Restaurant(double F_Rice,double c_Vinadaloo,double r_Chiken,double b_Roulade,double d_Apple,double k_Biryani,double m_Biryani,
         double Burger_S,double Pizza_S,double pKnuckle_S,double Samusa_S,double cLollypop_S,double Drinks_S,double hDelivery_S)
        {
            newF_Rice = F_Rice;
            newc_Vinadaloo = c_Vinadaloo;
            newr_Chiken = r_Chiken;
            newb_Roulade = b_Roulade;
            newd_Apple = d_Apple;
            newk_Biryani = k_Biryani;
            newm_Biryani = m_Biryani;

            newBurger_S = Burger_S;
            newPizza_S = Pizza_S;
            newpKnuckle_S = pKnuckle_S;
            newSamusa_S = Samusa_S;
            newcLollypop_S = cLollypop_S;
            newDrinks_S = Drinks_S;
            newhDelivery_S = hDelivery_S;

        }
        //Accessor Function

        //First Accessor Function 
        public double getF_Rice()
        {
            return newF_Rice;
        }
        public double getc_Vinadaloo()
        {
            return newc_Vinadaloo;
        }
        public double getr_Chiken()
        {
            return newr_Chiken;
        }
        public double getb_Roulade()
        {
            return newb_Roulade;
        }
        public double getd_Apple()
        {
            return newd_Apple;
        }
        public double getk_Biryani()
        {
            return newk_Biryani;
        }
        public double getm_Biryani()
        {
            return newm_Biryani;
        }

        //Second Accessor Function
        public double getBurger_S()
        {
            return newBurger_S;
        }
        public double getPizza_S()
        {
            return newPizza_S;
        }
        public double getpKnuckle_S()
        {
            return newpKnuckle_S;
        }
        public double getSamusa_S()
        {
            return newSamusa_S;
        }
        public double getcLollypop_S()
        {
            return newcLollypop_S;
        }
        public double getDrinks_S()
        {
            return newDrinks_S;
        }
        public double gethDelivery_S()
        {
            return newhDelivery_S;
        }
        //member variable Declaration

        //member variable Declaration For First Section
        private double newF_Rice;
        private double newc_Vinadaloo;
        private double newr_Chiken;
        private double newb_Roulade;
        private double newd_Apple;
        private double newk_Biryani;
        private double newm_Biryani;

        //member variable Declaration For Second Section 
        private double newBurger_S;
        private double newPizza_S;
        private double newpKnuckle_S;
        private double newSamusa_S;
        private double newcLollypop_S;
        private double newDrinks_S;
        private double newhDelivery_S;
    }
}
