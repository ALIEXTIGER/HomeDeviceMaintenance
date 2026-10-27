using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    // فئة الغسالة ترث من الفئة الأساسية للجهاز
    public class WashingMachine : HomeDevice
    {
        private bool _needsNewMotor;

        public WashingMachine(string serialNumber, string brand, double baseRepairCost, bool needsNewMotor) 
            : base(serialNumber, brand, baseRepairCost)
        {
            _needsNewMotor = needsNewMotor;
        }

        // حساب التكلفة: إذا كانت تحتاج موتور جديد نضيف تكلفة إضافية ثابتة
        public override double CalculateTotalRepairCost()
        {
            if (_needsNewMotor)
            {
                return BaseRepairCost + 150.0; // 150 هي تكلفة الموتور الافتراضية
            }
            return BaseRepairCost;
        }
    }
}
