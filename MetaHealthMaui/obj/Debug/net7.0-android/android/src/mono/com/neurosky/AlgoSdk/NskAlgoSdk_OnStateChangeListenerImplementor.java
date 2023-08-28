package mono.com.neurosky.AlgoSdk;


public class NskAlgoSdk_OnStateChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.neurosky.AlgoSdk.NskAlgoSdk.OnStateChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onStateChange:(II)V:GetOnStateChange_IIHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnStateChangeListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnStateChangeListenerImplementor, BleDev", NskAlgoSdk_OnStateChangeListenerImplementor.class, __md_methods);
	}


	public NskAlgoSdk_OnStateChangeListenerImplementor ()
	{
		super ();
		if (getClass () == NskAlgoSdk_OnStateChangeListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnStateChangeListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onStateChange (int p0, int p1)
	{
		n_onStateChange (p0, p1);
	}

	private native void n_onStateChange (int p0, int p1);

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
