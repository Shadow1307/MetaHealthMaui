package mono.com.linktop.infs;


public class OnBleConnectListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBleConnectListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBLENoSupported:()V:GetOnBLENoSupportedHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev\n" +
			"n_onBleState:(I)V:GetOnBleState_IHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev\n" +
			"n_onOpenBLE:()V:GetOnOpenBLEHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev\n" +
			"n_onUpdateDialogBleList:()V:GetOnUpdateDialogBleListHandler:Com.Linktop.Infs.IOnBleConnectListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBleConnectListenerImplementor, BleDev", OnBleConnectListenerImplementor.class, __md_methods);
	}


	public OnBleConnectListenerImplementor ()
	{
		super ();
		if (getClass () == OnBleConnectListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBleConnectListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBLENoSupported ()
	{
		n_onBLENoSupported ();
	}

	private native void n_onBLENoSupported ();


	public void onBleState (int p0)
	{
		n_onBleState (p0);
	}

	private native void n_onBleState (int p0);


	public void onOpenBLE ()
	{
		n_onOpenBLE ();
	}

	private native void n_onOpenBLE ();


	public void onUpdateDialogBleList ()
	{
		n_onUpdateDialogBleList ();
	}

	private native void n_onUpdateDialogBleList ();

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
