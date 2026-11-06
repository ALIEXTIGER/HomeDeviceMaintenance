using System;
using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.Models
{
    // فئة الثلاجة ترث من الفئة الأساسية للجهاز
    public class Refrigerator : HomeDevice
    {
        // إضافة متغير خاص بالثلاجات مثل تكلفة شحن الغاز
        private double _gasRefillCost;

        public double GasRefillCost
        {
            get { return _gasRefillCost; }
            set { _gasRefillCost = value; }
        }

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
