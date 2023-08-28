package mono.com.neurosky.AlgoSdk;


public class NskAlgoSdk_OnECGAlgoIndexListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.neurosky.AlgoSdk.NskAlgoSdk.OnECGAlgoIndexListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onECGAlgoIndex:(II)V:GetOnECGAlgoIndex_IIHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGAlgoIndexListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGAlgoIndexListenerImplementor, BleDev", NskAlgoSdk_OnECGAlgoIndexListenerImplementor.class, __md_methods);
	}


	public NskAlgoSdk_OnECGAlgoIndexListenerImplementor ()
	{
		super ();
		if (getClass () == NskAlgoSdk_OnECGAlgoIndexListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnECGAlgoIndexListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onECGAlgoIndex (int p0, int p1)
	{
		n_onECGAlgoIndex (p0, p1);
	}

	private native void n_onECGAlgoIndex (int p0, int p1);

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
