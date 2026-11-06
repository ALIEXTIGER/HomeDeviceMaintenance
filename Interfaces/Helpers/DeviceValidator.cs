namespace HomeDeviceMaintenance.Helpers
{
    /// <summary>
    /// فئة ثابتة للتحقق من صحة البيانات المدخلة للنظام.
    /// </summary>
    public static class DeviceValidator
    {
        /// <summary>
        /// التحقق من الرقم التسلسلي.
        /// </summary>
        public static bool IsValidSerial(string serial)
        {
            return !string.IsNullOrWhiteSpace(serial);
        }

        /// <summary>
        /// التحقق من تكلفة الإصلاح.
        /// </summary>
        public static bool IsValidCost(double cost)
        {
            return cost >= 0;
        }
    }
}
