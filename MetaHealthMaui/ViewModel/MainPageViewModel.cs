using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppDI.Helpers;

namespace MetaHealthMaui.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {

        [RelayCommand]
        async Task RequestBluetooth()
        {
            if (DeviceInfo.Platform != DevicePlatform.Android)
                return;

            var status = PermissionStatus.Unknown;

            if (DeviceInfo.Version.Major >= 12)
            {
                status = await Permissions.CheckStatusAsync<BluetoothPermission>();

                if (status == PermissionStatus.Granted)
                    return;

                if (Permissions.ShouldShowRationale<BluetoothPermission>())
                {
                    await Shell.Current.DisplayAlert("Device permissions request", "Bluetooth permissions required", "OK");
                }

                status = await Permissions.RequestAsync<BluetoothPermission>();

            }
            else
            {
                status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

                if (status == PermissionStatus.Granted)
                    return;

                if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
                {
                    await Shell.Current.DisplayAlert("Device permissions request", "Device location required for bluetooth", "OK");
                }

                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }


            if (status != PermissionStatus.Granted)
                await Shell.Current.DisplayAlert("Permission required",
                    "Location permission is required for bluetooth scanning. " +
                    "We do not store or use your location at all.", "OK");
        }

    }
}
