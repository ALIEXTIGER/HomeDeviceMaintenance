using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    // فئة الثلاجة ترث من الفئة الأساسية للجهاز
    public class Refrigerator : HomeDevice
    {
        // إضافة متغير خاص بالثلاجات مثل تكلفة شحن الغاز
        private double _gasRefillCost;

        public Refrigerator(string serialNumber, string brand, double baseRepairCost, double gasRefillCost) 
            : base(serialNumber, brand, baseRepairCost)
        {
            _gasRefillCost = gasRefillCost;
        }

        // حساب التكلفة الكلية للثلاجة: التكلفة الأساسية مضافاً إليها تكلفة الغاز
        public override double CalculateTotalRepairCost()
        {
            return BaseRepairCost + _gasRefillCost;
        }
    }
}
