using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraEjercicio13.Moldes
{
    internal class Billetera
    {
        public Billetera() { }
        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, 
                         int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10   = billetesDe10;
            BilletesDe20   = billetesDe20;
            BilletesDe50   = billetesDe50;
            BilletesDe100  = billetesDe100;
            BilletesDe200  = billetesDe200;
            BilletesDe500  = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        public int BilletesDe10   { get; set; }
        public int BilletesDe20   { get; set; }
        public int BilletesDe50   { get; set; }
        public int BilletesDe100  { get; set; }
        public int BilletesDe200  { get; set; }
        public int BilletesDe500  { get; set; }
        public int BilletesDe1000 { get; set; }

        public decimal Total()
        {
            return Convert.ToDecimal(BilletesDe10 * 10    + BilletesDe20 * 20   + BilletesDe50 * 50   + 
                                     BilletesDe100 * 100  + BilletesDe200 * 200 + BilletesDe500 * 500 + 
                                     BilletesDe1000 * 1000);
        }

        public Billetera Combinar(Billetera billetera)
        {
            Billetera NuevaBilletera      = new Billetera();
            NuevaBilletera.BilletesDe10   = this.BilletesDe10   + billetera.BilletesDe10;
            NuevaBilletera.BilletesDe20   = this.BilletesDe20   + billetera.BilletesDe20;
            NuevaBilletera.BilletesDe50   = this.BilletesDe50   + billetera.BilletesDe50;
            NuevaBilletera.BilletesDe100  = this.BilletesDe100  + billetera.BilletesDe100;
            NuevaBilletera.BilletesDe200  = this.BilletesDe200  + billetera.BilletesDe200;
            NuevaBilletera.BilletesDe500  = this.BilletesDe500  + billetera.BilletesDe500;
            NuevaBilletera.BilletesDe1000 = this.BilletesDe1000 + billetera.BilletesDe1000;

            BilleteraVacia(this);
            BilleteraVacia(billetera);

            return NuevaBilletera;

        }

        private void BilleteraVacia(Billetera billeteraVacia)
        {
            billeteraVacia.BilletesDe10   = 0;
            billeteraVacia.BilletesDe20   = 0;
            billeteraVacia.BilletesDe50   = 0;
            billeteraVacia.BilletesDe100  = 0;
            billeteraVacia.BilletesDe200  = 0;
            billeteraVacia.BilletesDe500  = 0;
            billeteraVacia.BilletesDe1000 = 0;
        }

    }
}

