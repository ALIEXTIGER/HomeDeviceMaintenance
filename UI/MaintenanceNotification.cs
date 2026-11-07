using System;
using HomeDeviceMaintenance.Abstracts;

namespace HomeDeviceMaintenance.UI
{
    // تعريف Delegate لإرسال إشعار عند تغيير حالة الجهاز
    public delegate void StatusChangedHandler(
        HomeDevice device,
        string oldStatus,
        string newStatus
    );

    public class MaintenanceNotification
    {
        // الحدث الذي سيتم إطلاقه عند تغيير الحالة
        public event StatusChangedHandler OnStatusChanged;

        // تغيير حالة الجهاز وإطلاق الحدث
        public void TriggerStatusChange(HomeDevice device, string newStatus)
        {
            string oldStatus = device.Status;

            device.UpdateStatus(newStatus);

            // إطلاق الحدث للمشتركين
            OnStatusChanged?.Invoke(device, oldStatus, newStatus);
        }
    }
}
