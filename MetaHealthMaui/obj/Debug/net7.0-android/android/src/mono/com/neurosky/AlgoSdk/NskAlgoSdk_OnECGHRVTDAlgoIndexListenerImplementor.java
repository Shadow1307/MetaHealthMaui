package mono.com.neurosky.AlgoSdk;


public class NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVTDAlgoIndexListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onECGHRVTDAlgoIndexListener:(FFFFF)V:GetOnECGHRVTDAlgoIndexListener_FFFFFHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVTDAlgoIndexListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGHRVTDAlgoIndexListenerImplementor, BleDev", NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor.class, __md_methods);
	}


	public NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor ()
	{
		super ();
		if (getClass () == NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGHRVTDAlgoIndexListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4)
	{
		n_onECGHRVTDAlgoIndexListener (p0, p1, p2, p3, p4);
	}

	private native void n_onECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4);

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
