package mono.com.linktop.infs;


public class OnTestPaperResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnTestPaperResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTestPaperEvent:(ILjava/lang/Object;)V:GetOnTestPaperEvent_ILjava_lang_Object_Handler:Com.Linktop.Infs.IOnTestPaperResultListenerInvoker, BleDev\n" +
			"n_onTestPaperException:(I)V:GetOnTestPaperException_IHandler:Com.Linktop.Infs.IOnTestPaperResultListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnTestPaperResultListenerImplementor, BleDev", OnTestPaperResultListenerImplementor.class, __md_methods);
	}


	public OnTestPaperResultListenerImplementor ()
	{
		super ();
		if (getClass () == OnTestPaperResultListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnTestPaperResultListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onTestPaperEvent (int p0, java.lang.Object p1)
	{
		n_onTestPaperEvent (p0, p1);
	}

	private native void n_onTestPaperEvent (int p0, java.lang.Object p1);


	public void onTestPaperException (int p0)
	{
		n_onTestPaperException (p0);
	}

	private native void n_onTestPaperException (int p0);

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
