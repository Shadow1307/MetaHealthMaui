package mono.com.linktop.infs;


public class OnSpO2ResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnSpO2ResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSpO2End:()V:GetOnSpO2EndHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev\n" +
			"n_onSpO2Result:(II)V:GetOnSpO2Result_IIHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev\n" +
			"n_onSpO2Wave:(I)V:GetOnSpO2Wave_IHandler:Com.Linktop.Infs.IOnSpO2ResultListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnSpO2ResultListenerImplementor, BleDev", OnSpO2ResultListenerImplementor.class, __md_methods);
	}


	public OnSpO2ResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnSpO2ResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnSpO2ResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onSpO2End ()
	{
		n_onSpO2End ();
	}

	private native void n_onSpO2End ();


	public void onSpO2Result (int p0, int p1)
	{
		n_onSpO2Result (p0, p1);
	}

	private native void n_onSpO2Result (int p0, int p1);


	public void onSpO2Wave (int p0)
	{
		n_onSpO2Wave (p0);
	}

	private native void n_onSpO2Wave (int p0);

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
