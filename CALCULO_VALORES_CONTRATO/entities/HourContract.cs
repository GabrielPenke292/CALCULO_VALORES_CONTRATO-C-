using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULO_VALORES_CONTRATO.entities
{
    internal class HourContract
    {
        private DateTime date;
        private double valuePerHour;
        private int hours;

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double ValuePerHour
        {
            get { return valuePerHour; }
            set { valuePerHour = value; }
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public double totalValue()
        {
            return valuePerHour * valuePerHour;
        }

    }
}
