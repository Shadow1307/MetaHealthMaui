using Com.Linktop.Infs;

namespace MetaHealthMaui.Platforms.Android.BleDev
{
    public class BleConnectListener : Java.Lang.Object, IOnBleConnectListener
    {
        private readonly BleDevService _bleDevService;

        public BleConnectListener(BleDevService bleDevService)
        {
            _bleDevService = bleDevService;
        }

        /// <summary>
        /// Device does not have Bluetooth supported
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnBLENoSupported()
        {
            _bleDevService.OnBleConnectListenerServiceNoSupport();
        }

        /// <summary>
        /// Bluetooth state change
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnBleState(int bleState)
        {
            _bleDevService.OnBleConnectListenerServiceOpenBle();
        }

        /// <summary>
        /// Request Bluetooth permission popup
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnOpenBLE()
        {
            _bleDevService.OnBleConnectListenerServiceOpenBle();
        }

        /// <summary>
        /// Update Dialog list for Bluetooth devices
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnUpdateDialogBleList()
        {
            _bleDevService.OnBleConnectListenerServiceUpdateDialogBleList();
        }
    }
}
