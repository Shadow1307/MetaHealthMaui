package mono.com.neurosky.AlgoSdk;


public class NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVFDAlgoIndexListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onECGHRVFDAlgoIndexListener:(FFFF)V:GetOnECGHRVFDAlgoIndexListener_FFFFHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVFDAlgoIndexListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGHRVFDAlgoIndexListenerImplementor, BleDev", NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor.class, __md_methods);
	}


	public NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor ()
	{
		super ();
		if (getClass () == NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGHRVFDAlgoIndexListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3)
	{
		n_onECGHRVFDAlgoIndexListener (p0, p1, p2, p3);
	}

	private native void n_onECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3);

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
