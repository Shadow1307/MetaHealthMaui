﻿using MetaHealthMaui.BleDev;
using MetaHealthMaui.ViewModel;

namespace MetaHealthMaui
{
    public partial class MainPage : ContentPage
    {
        private readonly IBleDevService _bleDevService;

        public MainPage(MainPageViewModel vm)
        {
            _bleDevService = Application.Current.MainPage.Handler.MauiContext.Services.GetService<IBleDevService>();

            _bleDevService.MonitorDataTransmissionServiceBind += OnServiceBind;
            _bleDevService.MonitorDataTransmissionServiceUnbind += OnServiceUnbind;
            _bleDevService.MonitorDataTransmissionServiceException += OnServiceBindException;

            InitializeComponent();
            BindingContext = vm;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _bleDevService.BindDeviceService(BleDevice.Thermometer);
        }

        private void OnServiceBind(object sender, EventArgs e)
        {
            HandleBleStateChanged(_bleDevService.BleState);
        }

        private void OnServiceUnbind(object sender, EventArgs e)
        {

        }

        private void OnServiceBindException(object sender, EventArgs e)
        {

        }

        public void HandleBleStateChanged(BleState bleState)
        {
            switch (bleState)
            {
                case BleState.Closed:
                    // TODO stop scan temp
                    // TODO reset
                    ConnectClickAsync(bleState);
                    Application.Current.MainPage.DisplayAlert("Ble State Changed", "Closed", "OK");
                    break;
                case BleState.OpenedAndDisconnect:
                    // TODO check IsScanning and update UI
                    Application.Current.MainPage.DisplayAlert("Ble State Changed", "Opened And Disconnect", "OK");
                    break;
                case BleState.Connecting:
                    // TODO update UI with progress
                    Application.Current.MainPage.DisplayAlert("Ble State Changed", "Connecting", "OK");
                    break;
                case BleState.Connected:
                    // TODO update UI with connected
                    Application.Current.MainPage.DisplayAlert("Ble State Changed", "Connected", "OK");
                    break;
            }
        }

        public async Task ConnectClickAsync(BleState bleState)
        {
            switch(bleState)
            {
                case BleState.Closed:
                    _bleDevService.CheckOpen();
                    break;
                case BleState.OpenedAndDisconnect:
                    if (_bleDevService.IsScanning)
                    {
                        _bleDevService.AutoScan(false);
                        //Set text to scanning
                        //reset
                    }
                    else
                    {
                        //MainPageViewModel.RequestBluetooth();
                        //TODO get the bluetooth request to be called here instead of on button click

                        //Check permission manager for IsAllowBluetooth
                        _bleDevService.AutoScan(true);
                        //Set text to Scanning, click STOP
                    }
                    break;
                case BleState.Connecting:
                    //toast to connecting
                    break;
                case BleState.Connected:
                    _bleDevService.DisconnectBle();
                    break;
            }
        }
    }
}