using Curso2.Entities.Entities_Model12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso2.Entities.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxService;
        }
        public void ProcessInvoice(CarRental carRental) 
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayments = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayments = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayments = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayments);

            carRental.Invoice = new Invoice(basicPayments, tax);
        }
    }
}
