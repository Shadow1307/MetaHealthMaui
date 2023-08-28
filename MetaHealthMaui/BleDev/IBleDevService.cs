namespace MetaHealthMaui.BleDev
{
    public interface IBleDevService
    {
        event EventHandler MonitorDataTransmissionServiceBind;
        event EventHandler MonitorDataTransmissionServiceUnbind;
        event EventHandler MonitorDataTransmissionServiceException;

        event EventHandler BleConnectListenerServiceNoSupport;
        event EventHandler BleConnectListenerServiceBleState;
        event EventHandler BleConnectListenerServiceOpenBle;
        event EventHandler BleConnectListenerServiceUpdateDialogBleList;

        BleState BleState { get; }
        bool IsScanning { get; }

        void IsDebug(bool isDebug);
        void BindDeviceService(BleDevice deviceType);
        void CheckOpen();
        void AutoScan(bool autoScan);
        void DisconnectBle();
    }
}
