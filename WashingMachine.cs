using System;

namespace HomeApplianceRepairCenter.Models
{
    public class WashingMachine : HomeDevice
    {
        // متغير بسيط لمعرفة إذا كانت الغسالة تحتاج موتور جديد
        private bool needNewMotor;

        // الخاصية الخاصة بالموتور
        public bool NeedNewMotor
        {
            get { return needNewMotor; }
            set { needNewMotor = value; }
        }

        // المشيد العادي
        public WashingMachine(string serialNumber, string model, double baseCost, bool needNewMotor) 
            : base(serialNumber, model, baseCost)
        {
            this.needNewMotor = needNewMotor;
        }

        // دالة حساب التكلفة بطريقة IF العادية والكلاسيكية
        public override double CalculateTotalRepairCost()
        {
            double total = BaseCost;
            
            if (needNewMotor == true)
            {
                total = total + 200.0; // تكلفة إضافة موتور جديد
            }
            
            return total;
        }

        public override void StartDiagnosis()
        {
            Console.WriteLine("بدء فحص الغسالة...");
        }

        public override void CompleteRepair()
        {
            Console.WriteLine("تم الانتهاء من إصلاح الغسالة.");
        }
    }
}
