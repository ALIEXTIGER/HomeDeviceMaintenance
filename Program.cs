using System;
using System.Collections.Generic;
using HomeDeviceMaintenance.Abstracts;
using HomeDeviceMaintenance.Models;
using HomeDeviceMaintenance.Helpers;
using HomeDeviceMaintenance.UI;

namespace HomeDeviceMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- نظام إدارة مركز صيانة الأجهزة المنزلية ---");

            // إنشاء قائمة لتجميع الأجهزة المختلفة وتطبيق تعدد الأشكال
            List<HomeDevice> deviceList = new List<HomeDevice>();

            // إضافة عينات تجريبية من الأجهزة لضمان عمل النظام
            deviceList.Add(new Refrigerator("REF123", "LG", 100.0, 30.0));
            deviceList.Add(new WashingMachine("WASH456", "Samsung", 120.0, true));
            deviceList.Add(new AirConditioner("AC789", "Gree", 150.0));

            // إعداد نظام الأحداث والإشعارات
            MaintenanceNotification notifier = new MaintenanceNotification();
            
            // ربط الحدث بدالة الطباعة البسيطة لكي يظهر للمستخدم الإشعار فوراً
            notifier.OnStatusChanged += (device, old, current) => {
                Console.WriteLine($"\n[إشعار نظام]: الجهاز ذو الرقم {device.SerialNumber} تغيرت حالته من ({old}) إلى ({current})");
            };

            // عرض تفاصيل الأجهزة وحساب التكلفة الإجمالية لكل جهاز
            double totalCenterIncome = 0;
            Console.WriteLine("\n📋 قائمة الأجهزة الحالية في المركز:");
            foreach (var device in deviceList)
            {
                device.DisplayDetails();
                double cost = device.CalculateTotalRepairCost();
                Console.WriteLine($"تكلفة الإصلاح المقدرة لهذا الجهاز: {cost}$");
                totalCenterIncome += cost;
                Console.WriteLine("-----------------------------------");
            }

            // تجربة تغيير حالة جهاز لإطلاق الحدث والإشعار
            Console.WriteLine("\n🛠️ جاري تحديث حالة أحد الأجهزة...");
            if (deviceList.Count > 0)
            {
                notifier.TriggerStatusChange(deviceList[0], "Repaired & Ready");
            }

            Console.WriteLine($"\n💰 إجمالي التكاليف المتوقعة لجميع الأجهزة في المركز: {totalCenterIncome}$");
            Console.WriteLine("\nاضغط على أي مفتاح للخروج من البرنامج...");
            Console.ReadKey();
        }
    }
}
