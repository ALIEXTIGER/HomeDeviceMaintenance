using System;
using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    public class AirConditioner : HomeDevice
    {
        // متغير بسيط لتكلفة التنظيف
        private double cleaningCost;

        // الخاصية الخاصة بتكلفة التنظيف
        public double CleaningCost
        {
            get { return cleaningCost; }
            set { cleaningCost = value; }
        }

        // المشيد العادي
        public AirConditioner(string serialNumber, string model, double baseCost, double cleaningCost) 
            : base(serialNumber, model, baseCost)
        {
            this.cleaningCost = cleaningCost;
        }

        // دالة حساب التكلفة بطريقة واضحة ومباشرة
        public override double CalculateTotalRepairCost()
        {
            double total = BaseRepairCost + cleaningCost;
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
