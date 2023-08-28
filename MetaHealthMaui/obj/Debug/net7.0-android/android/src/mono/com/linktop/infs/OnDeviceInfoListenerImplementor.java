package mono.com.linktop.infs;


public class OnDeviceInfoListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnDeviceInfoListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDeviceInfo:(Lcom/linktop/constant/DeviceInfo;)V:GetOnDeviceInfo_Lcom_linktop_constant_DeviceInfo_Handler:Com.Linktop.Infs.IOnDeviceInfoListenerInvoker, BleDev\n" +
			"n_onReadDeviceInfoFailed:()V:GetOnReadDeviceInfoFailedHandler:Com.Linktop.Infs.IOnDeviceInfoListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnDeviceInfoListenerImplementor, BleDev", OnDeviceInfoListenerImplementor.class, __md_methods);
	}


	public OnDeviceInfoListenerImplementor ()
	{
		super ();
		if (getClass () == OnDeviceInfoListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnDeviceInfoListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDeviceInfo (com.linktop.constant.DeviceInfo p0)
	{
		n_onDeviceInfo (p0);
	}

	private native void n_onDeviceInfo (com.linktop.constant.DeviceInfo p0);


	public void onReadDeviceInfoFailed ()
	{
		n_onReadDeviceInfoFailed ();
	}

	private native void n_onReadDeviceInfoFailed ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
