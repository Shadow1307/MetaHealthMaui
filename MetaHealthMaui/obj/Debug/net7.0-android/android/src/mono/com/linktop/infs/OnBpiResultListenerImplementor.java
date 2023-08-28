package mono.com.linktop.infs;


public class OnBpiResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBpiResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBpiResultListenerImplementor, BleDev", OnBpiResultListenerImplementor.class, __md_methods);
	}


	public OnBpiResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnBpiResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBpiResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}

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
