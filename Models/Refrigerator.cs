using System;
using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    public class Refrigerator : HomeDevice
    {
        // متغير بسيط لتكلفة الغاز
        private double gasCost;

        // الخاصية الخاصة بتكلفة الغاز
        public double GasCost
        {
            get { return gasCost; }
            set { gasCost = value; }
        }

        // المشيد العادي
        public Refrigerator(string serialNumber, string model, double baseCost, double gasCost) 
            : base(serialNumber, model, baseCost)
        {
            this.gasCost = gasCost;
        }

        // دالة حساب التكلفة بطريقة واضحة ومباشرة
        public override double CalculateTotalRepairCost()
        {
            double total = BaseRepairCost + gasCost;
            return total;
        }

        public override void StartDiagnosis()
        {
            Console.WriteLine("بدء فحص الثلاجة...");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("تم الانتهاء من إصلاح الثلاجة.");
        }
    }
}
