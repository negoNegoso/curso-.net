using System;
using Aula190.Entitiess;

namespace Aula190.Services
{
    class RentalService 
    {
        public double  pricePerHour { get; set; }
        public double pricePerDay { get; set; }

        private ITaxService _taxService ;

        public RentalService(double pricePerHour, double pricePerDay,ITaxService taxService)
        {
            this.pricePerHour = pricePerHour;
            this.pricePerDay = pricePerDay;
            this._taxService = taxService;
        }

        public void processInvoce (CarRental carRental)
        {
            TimeSpan duration = carRental.finish.Subtract(carRental.start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = pricePerHour* Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = pricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.tax(basicPayment);

            carRental.invoice = new Invoice(basicPayment, tax);
        }
    }
}
