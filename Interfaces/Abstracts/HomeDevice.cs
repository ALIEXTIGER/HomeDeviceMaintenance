using HomeDeviceMaintenance.Interfaces;
using System;

namespace HomeDeviceMaintenance.Abstracts
{
    // فئة أساسية عامة تجمع الخصائص والوظائف المشتركة لجميع الأجهزة المنزلية
    public abstract class HomeDevice : IDeviceOperations
    {
        // حقول البيانات الأساسية للجهاز - مخفية لحماية البيانات من التعديل العشوائي
        private readonly string _serialNumber; // ثابت لا يتغير بعد تسجيل الجهاز
        private string _brand;
        private string _status;
        private double _baseRepairCost;

        // خصائص الوصول إلى البيانات مع تطبيق شروط التحقق
        public string SerialNumber => _serialNumber; 
        
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }

        public double BaseRepairCost
        {
            get => _baseRepairCost;
            set => _baseRepairCost = value >= 0 ? value : 0; // منع تسجيل تكلفة سالبة
        }

        // منشئ الكائن لتحديد قيم الجهاز عند تسجيله أول مرة في المركز
        protected HomeDevice(string serialNumber, string brand, double baseRepairCost)
        {
            _serialNumber = serialNumber;
            _brand = brand;
            _baseRepairCost = baseRepairCost;
            _status = "Under Maintenance"; // الحالة الافتراضية للجهاز الجديد
        }

        // حساب تكلفة الإصلاح الإجمالية - تُحدد طريقة الحساب لاحقاً حسب نوع كل جهاز
        public abstract double CalculateTotalRepairCost();

        // عرض بيانات الجهاز وحالته الحالية في نظام المركز
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"[Device] Serial: {SerialNumber} | Brand: {Brand} | Status: {Status} | Base Cost: {BaseRepairCost}$");
        }

        // تحديث حالة الصيانة للجهاز
        public virtual void UpdateStatus(string newStatus)
        {
            _status = newStatus;
        }
    }
}
