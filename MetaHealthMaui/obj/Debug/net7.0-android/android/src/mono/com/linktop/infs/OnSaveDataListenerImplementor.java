package mono.com.linktop.infs;


public class OnSaveDataListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnSaveDataListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnSaveDataListenerImplementor, BleDev", OnSaveDataListenerImplementor.class, __md_methods);
	}


	public OnSaveDataListenerImplementor ()
	{
		super ();
		if (getClass () == OnSaveDataListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnSaveDataListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
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
