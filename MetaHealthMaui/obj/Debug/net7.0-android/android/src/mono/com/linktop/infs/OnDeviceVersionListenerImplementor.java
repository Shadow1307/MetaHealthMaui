package mono.com.linktop.infs;


public class OnDeviceVersionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.linktop.infs.OnDeviceVersionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDeviceVersion:(ILjava/lang/String;)V:GetOnDeviceVersion_ILjava_lang_String_Handler:Com.Linktop.Infs.IOnDeviceVersionListenerInvoker, BleDev\n" +
			"";
		mono.android.Runtime.register ("Com.Linktop.Infs.IOnDeviceVersionListenerImplementor, BleDev", OnDeviceVersionListenerImplementor.class, __md_methods);
	}


	public OnDeviceVersionListenerImplementor ()
	{
		super ();
		if (getClass () == OnDeviceVersionListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Linktop.Infs.IOnDeviceVersionListenerImplementor, BleDev", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDeviceVersion (int p0, java.lang.String p1)
	{
		n_onDeviceVersion (p0, p1);
	}

	private native void n_onDeviceVersion (int p0, java.lang.String p1);

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
