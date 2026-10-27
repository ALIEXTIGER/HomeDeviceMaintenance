namespace HomeDeviceMaintenance.Interfaces
{
    // العمليات الأساسية التي يجب أن يقدمها أي جهاز يدخل مركز الصيانة
    public interface IDeviceOperations
    {
        // طباعة تفاصيل ومعلومات الجهاز الحالية على الشاشة
        void DisplayDetails(); 
        
        // تعديل حالة الصيانة للجهاز عند انتقال العمل لمرحلة أخرى
        void UpdateStatus(string newStatus); 
    }
}
