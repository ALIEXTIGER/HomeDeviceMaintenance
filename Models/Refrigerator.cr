using System;

namespace HomeApplianceRepairCenter.Models
{
    // فئة الثلاجة (الطالب الثالث)
    public class Refrigerator : HomeDevice
    {
        // خاصية بسيطة خاصة بتكلفة غاز الثلاجة
        public double GasCost { get; set; }

        public Refrigerator(string serialNumber, string model, double baseCost, double gasCost) 
            : base(serialNumber, model, baseCost)
        {
            GasCost = gasCost;
        }

        // حساب تكلفة الإصلاح الخاصة بالثلاجة
        public override double CalculateTotalRepairCost()
        {
            return BaseCost + GasCost;
        }

        public override void StartDiagnosis()
        {
            Console.WriteLine("جاري فحص الثلاجة...");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("تم إصلاح الثلاجة بنجاح.");
        }
    }
}
