using Com.Linktop;
using Java.Lang;

namespace MetaHealthMaui.Platforms.Android.BleDev
{
    public class MonitorDataTransmissionServiceBindListener : Java.Lang.Object, MonitorDataTransmission.IOnServiceBindListener
    {
        private readonly BleDevService _bleDevService;

        public MonitorDataTransmissionServiceBindListener(BleDevService bleDevService)
        {
            _bleDevService = bleDevService;
        }

        /// <summary>
        /// The Bluetooth communication service has been bound
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnServiceBind()
        {
            _bleDevService.OnMonitorDataTransmissionServiceBind();
        }

        /// <summary>
        /// Health device Bluetooth communication service unbind
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void OnServiceUnbind()
        {
            _bleDevService.OnMonitorDataTransmissionServiceUnbind();
        }

        /// <summary>
        /// Call back when some exception occurs inside the SDK
        /// </summary>
        /// <param name="throwable"></param>
        public void OnSDKThrowable(Throwable throwable)
        {
            _bleDevService.OnMonitorDataTransmissionServiceException();
        }
    }
}