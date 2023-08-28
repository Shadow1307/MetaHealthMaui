package mono.com.linktop.infs;


public class OnBatteryListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBatteryListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBatteryCharging:()V:GetOnBatteryChargingHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev\n" +
			"n_onBatteryFull:()V:GetOnBatteryFullHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev\n" +
			"n_onBatteryQuery:(I)V:GetOnBatteryQuery_IHandler:Com.Linktop.Infs.IOnBatteryListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBatteryListenerImplementor, BleDev", OnBatteryListenerImplementor.class, __md_methods);
	}


	public OnBatteryListenerImplementor ()
	{
		super ();
		if (getClass () == OnBatteryListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBatteryListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBatteryCharging ()
	{
		n_onBatteryCharging ();
	}

	private native void n_onBatteryCharging ();


	public void onBatteryFull ()
	{
		n_onBatteryFull ();
	}

	private native void n_onBatteryFull ();


	public void onBatteryQuery (int p0)
	{
		n_onBatteryQuery (p0);
	}

	private native void n_onBatteryQuery (int p0);

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
