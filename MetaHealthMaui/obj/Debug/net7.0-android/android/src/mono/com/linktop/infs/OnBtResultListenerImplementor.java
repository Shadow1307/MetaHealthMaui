package mono.com.linktop.infs;


public class OnBtResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBtResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBtResult:(D)V:GetOnBtResult_DHandler:Com.Linktop.Infs.IOnBtResultListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBtResultListenerImplementor, BleDev", OnBtResultListenerImplementor.class, __md_methods);
	}


	public OnBtResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnBtResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBtResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBtResult (double p0)
	{
		n_onBtResult (p0);
	}

	private native void n_onBtResult (double p0);

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
