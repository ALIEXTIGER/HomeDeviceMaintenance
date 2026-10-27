using HomeDeviceMaintenance.Abstracts;
using System;

namespace HomeDeviceMaintenance.UI
{
    // تعريف التفويض المسؤول عن إرسال الإشعارات
    public delegate void StatusChangedHandler(HomeDevice device, string oldStatus, string newStatus);

    public class MaintenanceNotification
    {
        // الحدث الذي يتم إطلاقه داخل النظام
        public event StatusChangedHandler OnStatusChanged;

        // دالة تقوم بتغيير حالة الجهاز وإطلاق الإشعار إذا كانت هناك دالة مشتركة بالحدث
        public void TriggerStatusChange(HomeDevice device, string newStatus)
        {
            string oldStatus = device.Status;
            device.UpdateStatus(newStatus);

            // إذا كان هناك من يستمع للحدث، نقوم بإطلاقه فوراً
            if (OnStatusChanged != null)
            {
                OnStatusChanged(device, oldStatus, newStatus);
            }
        }
    }
}
