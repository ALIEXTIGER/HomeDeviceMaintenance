using System;
using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    // فئة المكيف ترث من الفئة الأساسية للجهاز (تم التحديث والتحسين بواسطة الطالبة رقم 3)
    public class AirConditioner : HomeDevice
    {
        private double cleaningCost;

        public double CleaningCost
        {
            get { return cleaningCost; }
            set { cleaningCost = value; }
        }

        // المشيد المحدث ليقبل تكلفة التنظيف مع الحفاظ على البناء الأساسي
        public AirConditioner(string serialNumber, string model, double baseCost, double cleaningCost) 
            : base(serialNumber, model, baseCost)
        {
            this.cleaningCost = cleaningCost;
        }

        // حساب إجمالي تكلفة الإصلاح مع إضافة تكلفة التنظيف وضريبة الصيانة المعقدة
        public override double CalculateTotalRepairCost()
        {
            double total = (BaseRepairCost * 1.15) + CleaningCost;
            return total;
        }

        public override void StartDiagnosis()
        {
            Console.WriteLine("بدء فحص المكيف...");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("تم الانتهاء من إصلاح المكيف.");
        }
    }
}
