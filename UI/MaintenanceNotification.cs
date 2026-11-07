using System;

namespace HomeDeviceMaintenance.UI
{
    // 1. تعريف المفوض (Delegate) الذي يحدد شكل دالة التعامل مع الإشعار
    public delegate void MaintenanceStatusHandler(string deviceName, string oldStatus, string newStatus);

    public class MaintenanceNotification
    {
        // 2. بناءً على المفوض السابق (Event) تعريف الحدث
        public event MaintenanceStatusHandler OnStatusChanged;

        // 3. دالة تُستدعى لإطلاق الحدث وإرسال الإشعار
        public void NotifyStatusChange(string deviceName, string oldStatus, string newStatus)
        {
            Console.WriteLine($"\n[نظام التنبيهات]: تم رصد تغيير في الجهاز البرمجي...");

            // التحقق من وجود مشتركين في الحدث قبل إطلاقه
            if (OnStatusChanged != null)
            {
                OnStatusChanged(deviceName, oldStatus, newStatus);
            }
            else
            {
                // إذا لم يكن هناك مشتركين، نطبع الإشعار الافتراضي في الواجهة
                Console.WriteLine($" (UI) إشعار تلقائي للواجهة :الجهاز [{deviceName}] تحول من حالة ({oldStatus}) إلى ({newStatus})");
            }
        }
    }
}
