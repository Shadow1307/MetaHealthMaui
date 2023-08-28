package mono.com.linktop.infs;


public class OnBpResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBpResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBpResult:(III)V:GetOnBpResult_IIIHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev\n" +
			"n_onBpResultError:()V:GetOnBpResultErrorHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev\n" +
			"n_onLeakError:(I)V:GetOnLeakError_IHandler:Com.Linktop.Infs.IOnBpResultListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBpResultListenerImplementor, BleDev", OnBpResultListenerImplementor.class, __md_methods);
	}


	public OnBpResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnBpResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBpResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBpResult (int p0, int p1, int p2)
	{
		n_onBpResult (p0, p1, p2);
	}

	private native void n_onBpResult (int p0, int p1, int p2);


	public void onBpResultError ()
	{
		n_onBpResultError ();
	}

	private native void n_onBpResultError ();


	public void onLeakError (int p0)
	{
		n_onLeakError (p0);
	}

	private native void n_onLeakError (int p0);

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
