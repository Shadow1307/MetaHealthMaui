package crc643f27c6b1a5840623;


public class MonitorDataTransmissionServiceBindListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.MonitorDataTransmission.OnServiceBindListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSDKThrowable:(Ljava/lang/Throwable;)V:GetOnSDKThrowable_Ljava_lang_Throwable_Handler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev\n" +
			"n_onServiceBind:()V:GetOnServiceBindHandler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev\n" +
			"n_onServiceUnbind:()V:GetOnServiceUnbindHandler:Com.Linktop.MonitorDataTransmission/IOnServiceBindListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("MetaHealthMaui.Platforms.Android.BleDev.MonitorDataTransmissionServiceBindListener, MetaHealthMaui", MonitorDataTransmissionServiceBindListener.class, __md_methods);
	}


	public MonitorDataTransmissionServiceBindListener ()
	{
		super ();
		if (getClass () == MonitorDataTransmissionServiceBindListener.class) {
			mono.android.TypeManager.Activate ("MetaHealthMaui.Platforms.Android.BleDev.MonitorDataTransmissionServiceBindListener, MetaHealthMaui", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSDKThrowable (java.lang.Throwable p0)
	{
		n_onSDKThrowable (p0);
	}

	private native void n_onSDKThrowable (java.lang.Throwable p0);


	public void onServiceBind ()
	{
		n_onServiceBind ();
	}

	private native void n_onServiceBind ();


	public void onServiceUnbind ()
	{
		n_onServiceUnbind ();
	}

	private native void n_onServiceUnbind ();

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
