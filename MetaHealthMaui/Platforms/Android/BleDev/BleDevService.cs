using Com.Linktop;
using MetaHealthMaui.BleDev;

namespace MetaHealthMaui.Platforms.Android.BleDev
{
    public class BleDevService : IBleDevService
    {
        private MonitorDataTransmissionManager _manager => MonitorDataTransmissionManager.Instance;

        //Monitor Data Transmission Methods
        public event EventHandler MonitorDataTransmissionServiceBind;
        public event EventHandler MonitorDataTransmissionServiceUnbind;
        public event EventHandler MonitorDataTransmissionServiceException;

        //Blueooth Listeners Methods
        public event EventHandler BleConnectListenerServiceNoSupport;
        public event EventHandler BleConnectListenerServiceBleState;
        public event EventHandler BleConnectListenerServiceOpenBle;
        public event EventHandler BleConnectListenerServiceUpdateDialogBleList;

        public BleState BleState => (BleState)_manager.BleState;
        public bool IsScanning => _manager.IsScanning;

        public BleDevService()
        {
            IsDebug(true);
        }

        public void IsDebug(bool isDebug)
        {
            MonitorDataTransmissionManager.IsDebug(isDebug);
        }

        public void BindDeviceService(BleDevice deviceType)
        {
            _manager.Bind(deviceType.ToString(), Platform.CurrentActivity, new MonitorDataTransmissionServiceBindListener(this));
        }

        #region Monitor Data Transmission Methods

        public void OnMonitorDataTransmissionServiceBind()
        {
            MonitorDataTransmissionServiceBind?.Invoke(this, EventArgs.Empty);
            _manager.SetOnBleConnectListener(new BleConnectListener(this));
        }

        public void OnMonitorDataTransmissionServiceUnbind()
        {
            MonitorDataTransmissionServiceUnbind?.Invoke(this, EventArgs.Empty);
        }

        public void OnMonitorDataTransmissionServiceException()
        {
            MonitorDataTransmissionServiceException?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Bluetooth Listeners Methods

        public void OnBleConnectListenerServiceNoSupport()
        {
            BleConnectListenerServiceNoSupport?.Invoke(this, EventArgs.Empty);
        }

        public void OnBleConnectListenerServiceBleState()
        {
            BleConnectListenerServiceBleState?.Invoke(this, EventArgs.Empty);
        }

        public void OnBleConnectListenerServiceOpenBle()
        {
            BleConnectListenerServiceOpenBle?.Invoke(this, EventArgs.Empty);
        }

        public void OnBleConnectListenerServiceUpdateDialogBleList()
        {
            BleConnectListenerServiceUpdateDialogBleList?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        public void CheckOpen()
        {
            _manager.BleCheckOpen();
        }

        public void AutoScan(bool autoScan)
        {
            _manager.AutoScan(autoScan);
        }

        public void DisconnectBle()
        {
            _manager.DisConnectBle();
        }
    }
}