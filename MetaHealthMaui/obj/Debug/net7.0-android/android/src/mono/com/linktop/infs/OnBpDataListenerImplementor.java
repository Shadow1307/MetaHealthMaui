package mono.com.linktop.infs;


public class OnBpDataListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnBpDataListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFIRAvgFilter:(Lcom/linktop/constant/ResultData;Z)V:GetOnFIRAvgFilter_Lcom_linktop_constant_ResultData_ZHandler:Com.Linktop.Infs.IOnBpDataListenerInvoker, BleDev\n" +
			"n_onRcvPressure:(I)V:GetOnRcvPressure_IHandler:Com.Linktop.Infs.IOnBpDataListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnBpDataListenerImplementor, BleDev", OnBpDataListenerImplementor.class, __md_methods);
	}


	public OnBpDataListenerImplementor ()
	{
		super ();
		if (getClass () == OnBpDataListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnBpDataListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onFIRAvgFilter (com.linktop.constant.ResultData p0, boolean p1)
	{
		n_onFIRAvgFilter (p0, p1);
	}

	private native void n_onFIRAvgFilter (com.linktop.constant.ResultData p0, boolean p1);


	public void onRcvPressure (int p0)
	{
		n_onRcvPressure (p0);
	}

	private native void n_onRcvPressure (int p0);

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
