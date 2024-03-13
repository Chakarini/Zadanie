using ConsoleApp3.Model;
using ConsoleApp3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Controller
{
    public class TipCalculatorController
    {
        private Tip tip;
        private Display display;
        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.Percent = tip.CalculateTip();
            display.Total = tip.CalculateTip();
            display.ShowTipAndTotal();
        }
    }
}
