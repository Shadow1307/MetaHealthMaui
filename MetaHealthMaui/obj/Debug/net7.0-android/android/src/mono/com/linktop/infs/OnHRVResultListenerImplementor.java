package mono.com.linktop.infs;


public class OnHRVResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnHRVResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onHRVResult:(ILjava/lang/Object;)V:GetOnHRVResult_ILjava_lang_Object_Handler:Com.Linktop.Infs.IOnHRVResultListenerInvoker, BleDev\n" +
			"n_onSignalData:(II)V:GetOnSignalData_IIHandler:Com.Linktop.Infs.IOnHRVResultListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnHRVResultListenerImplementor, BleDev", OnHRVResultListenerImplementor.class, __md_methods);
	}


	public OnHRVResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnHRVResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnHRVResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onHRVResult (int p0, java.lang.Object p1)
	{
		n_onHRVResult (p0, p1);
	}

	private native void n_onHRVResult (int p0, java.lang.Object p1);


	public void onSignalData (int p0, int p1)
	{
		n_onSignalData (p0, p1);
	}

	private native void n_onSignalData (int p0, int p1);

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
