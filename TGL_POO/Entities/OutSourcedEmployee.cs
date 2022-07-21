
namespace TGL_POO.Entities
{
    internal class OutSourcedEmployee : Employee
    {

        public double AddiotinalCharge { get; set; }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double addiotinalCharge) : base(name, hours, valuePerHour)
        {
            AddiotinalCharge = addiotinalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AddiotinalCharge;
        }

    }
}
