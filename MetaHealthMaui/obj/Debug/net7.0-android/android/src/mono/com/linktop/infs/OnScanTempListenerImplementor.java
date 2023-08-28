package mono.com.linktop.infs;


public class OnScanTempListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnScanTempListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNoTemp:()V:GetOnNoTempHandler:Com.Linktop.Infs.IOnScanTempListenerInvoker, BleDev\n" +
			"n_onScanTempResult:(Ljava/lang/String;DI)V:GetOnScanTempResult_Ljava_lang_String_DIHandler:Com.Linktop.Infs.IOnScanTempListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnScanTempListenerImplementor, BleDev", OnScanTempListenerImplementor.class, __md_methods);
	}


	public OnScanTempListenerImplementor ()
	{
		super ();
		if (getClass () == OnScanTempListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnScanTempListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onNoTemp ()
	{
		n_onNoTemp ();
	}

	private native void n_onNoTemp ();


	public void onScanTempResult (java.lang.String p0, double p1, int p2)
	{
		n_onScanTempResult (p0, p1, p2);
	}

	private native void n_onScanTempResult (java.lang.String p0, double p1, int p2);

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
