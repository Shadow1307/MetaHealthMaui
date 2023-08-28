package mono.com.neurosky.AlgoSdk;


public class NskAlgoSdk_OnSignalQualityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.neurosky.AlgoSdk.NskAlgoSdk.OnSignalQualityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onOverallSignalQuality:(I)V:GetOnOverallSignalQuality_IHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnSignalQualityListenerInvoker, BleDev\n" +
			"n_onSignalQuality:(I)V:GetOnSignalQuality_IHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnSignalQualityListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnSignalQualityListenerImplementor, BleDev", NskAlgoSdk_OnSignalQualityListenerImplementor.class, __md_methods);
	}


	public NskAlgoSdk_OnSignalQualityListenerImplementor ()
	{
		super ();
		if (getClass () == NskAlgoSdk_OnSignalQualityListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Neurosky.AlgoSdk.NskAlgoSdk+IOnSignalQualityListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onOverallSignalQuality (int p0)
	{
		n_onOverallSignalQuality (p0);
	}

	private native void n_onOverallSignalQuality (int p0);


	public void onSignalQuality (int p0)
	{
		n_onSignalQuality (p0);
	}

	private native void n_onSignalQuality (int p0);

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
