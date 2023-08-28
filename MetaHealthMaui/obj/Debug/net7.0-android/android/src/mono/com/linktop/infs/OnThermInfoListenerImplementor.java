package mono.com.linktop.infs;


public class OnThermInfoListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnThermInfoListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onThermQRCode:(Ljava/lang/String;)V:GetOnThermQRCode_Ljava_lang_String_Handler:Com.Linktop.Infs.IOnThermInfoListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnThermInfoListenerImplementor, BleDev", OnThermInfoListenerImplementor.class, __md_methods);
	}


	public OnThermInfoListenerImplementor ()
	{
		super ();
		if (getClass () == OnThermInfoListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnThermInfoListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onThermQRCode (java.lang.String p0)
	{
		n_onThermQRCode (p0);
	}

	private native void n_onThermQRCode (java.lang.String p0);

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
