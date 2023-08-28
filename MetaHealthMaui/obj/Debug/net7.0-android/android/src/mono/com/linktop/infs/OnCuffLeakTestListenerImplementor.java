package mono.com.linktop.infs;


public class OnCuffLeakTestListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnCuffLeakTestListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_a:(I)V:GetA_IHandler:Com.Linktop.Infs.IOnCuffLeakTestListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnCuffLeakTestListenerImplementor, BleDev", OnCuffLeakTestListenerImplementor.class, __md_methods);
	}


	public OnCuffLeakTestListenerImplementor ()
	{
		super ();
		if (getClass () == OnCuffLeakTestListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnCuffLeakTestListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void a (int p0)
	{
		n_a (p0);
	}

	private native void n_a (int p0);

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
