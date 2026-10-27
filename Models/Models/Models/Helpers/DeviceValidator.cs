using System;

namespace HomeDeviceMaintenance.Helpers
{
    // فئة ثابتة تحتوي على دوال مساعدة للتحقق من صحة البيانات
    public static class DeviceValidator
    {
        // التحقق من أن الرقم التسلسلي ليس فارغاً وطوله مناسب
        public static bool IsValidSerialNumber(string serial)
        {
            if (string.IsNullOrEmpty(serial) || serial.Length < 4)
            {
                return false;
            }
            return true;
        }

        // التحقق من أن النص المدخل غير فارغ (مثل اسم الشركة المصنعة)
        public static bool IsValidString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            return true;
        }
    }
}
