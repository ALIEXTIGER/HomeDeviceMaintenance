using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    // فئة المكيف ترث من الفئة الأساسية للجهاز
    public class AirConditioner : HomeDevice
    {
        public AirConditioner(string serialNumber, string brand, double baseRepairCost) 
            : base(serialNumber, brand, baseRepairCost)
        {
        }

        // حساب التكلفة للمكيف مع إضافة ضريبة صيانة الأجهزة المعقدة 15%
        public override double CalculateTotalRepairCost()
        {
            return BaseRepairCost * 1.15;
        }
    }
}
