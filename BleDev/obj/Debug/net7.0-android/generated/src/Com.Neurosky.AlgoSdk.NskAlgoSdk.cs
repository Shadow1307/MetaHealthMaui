using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Neurosky.AlgoSdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']"
	[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk", DoNotGenerateAcw=true)]
	public partial class NskAlgoSdk : global::Java.Lang.Object {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGAlgoIndexListener']"
		[Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGAlgoIndexListener", "", "Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGAlgoIndexListenerInvoker")]
		public partial interface IOnECGAlgoIndexListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGAlgoIndexListener']/method[@name='onECGAlgoIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onECGAlgoIndex", "(II)V", "GetOnECGAlgoIndex_IIHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGAlgoIndexListenerInvoker, BleDev")]
			void OnECGAlgoIndex (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGAlgoIndexListener", DoNotGenerateAcw=true)]
		internal partial class IOnECGAlgoIndexListenerInvoker : global::Java.Lang.Object, IOnECGAlgoIndexListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGAlgoIndexListener", typeof (IOnECGAlgoIndexListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnECGAlgoIndexListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnECGAlgoIndexListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.neurosky.AlgoSdk.NskAlgoSdk.OnECGAlgoIndexListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnECGAlgoIndexListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onECGAlgoIndex_II;
#pragma warning disable 0169
			static Delegate GetOnECGAlgoIndex_IIHandler ()
			{
				if (cb_onECGAlgoIndex_II == null)
					cb_onECGAlgoIndex_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnECGAlgoIndex_II);
				return cb_onECGAlgoIndex_II;
			}

			static void n_OnECGAlgoIndex_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnECGAlgoIndex (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onECGAlgoIndex_II;
			public unsafe void OnECGAlgoIndex (int p0, int p1)
			{
				if (id_onECGAlgoIndex_II == IntPtr.Zero)
					id_onECGAlgoIndex_II = JNIEnv.GetMethodID (class_ref, "onECGAlgoIndex", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onECGAlgoIndex_II, __args);
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnECGAlgoIndexListener.onECGAlgoIndex
		public partial class ECGAlgoIndexEventArgs : global::System.EventArgs {
			public ECGAlgoIndexEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

			int p1;

			public int P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGAlgoIndexListenerImplementor")]
		internal sealed partial class IOnECGAlgoIndexListenerImplementor : global::Java.Lang.Object, IOnECGAlgoIndexListener {

			object sender;

			public IOnECGAlgoIndexListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGAlgoIndexListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<ECGAlgoIndexEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnECGAlgoIndex (int p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ECGAlgoIndexEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnECGAlgoIndexListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGHRVFDAlgoIndexListener']"
		[Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVFDAlgoIndexListener", "", "Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVFDAlgoIndexListenerInvoker")]
		public partial interface IOnECGHRVFDAlgoIndexListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGHRVFDAlgoIndexListener']/method[@name='onECGHRVFDAlgoIndexListener' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onECGHRVFDAlgoIndexListener", "(FFFF)V", "GetOnECGHRVFDAlgoIndexListener_FFFFHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVFDAlgoIndexListenerInvoker, BleDev")]
			void OnECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3);

		}

		[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVFDAlgoIndexListener", DoNotGenerateAcw=true)]
		internal partial class IOnECGHRVFDAlgoIndexListenerInvoker : global::Java.Lang.Object, IOnECGHRVFDAlgoIndexListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVFDAlgoIndexListener", typeof (IOnECGHRVFDAlgoIndexListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnECGHRVFDAlgoIndexListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnECGHRVFDAlgoIndexListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVFDAlgoIndexListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnECGHRVFDAlgoIndexListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onECGHRVFDAlgoIndexListener_FFFF;
#pragma warning disable 0169
			static Delegate GetOnECGHRVFDAlgoIndexListener_FFFFHandler ()
			{
				if (cb_onECGHRVFDAlgoIndexListener_FFFF == null)
					cb_onECGHRVFDAlgoIndexListener_FFFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFFF_V) n_OnECGHRVFDAlgoIndexListener_FFFF);
				return cb_onECGHRVFDAlgoIndexListener_FFFF;
			}

			static void n_OnECGHRVFDAlgoIndexListener_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnECGHRVFDAlgoIndexListener (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onECGHRVFDAlgoIndexListener_FFFF;
			public unsafe void OnECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3)
			{
				if (id_onECGHRVFDAlgoIndexListener_FFFF == IntPtr.Zero)
					id_onECGHRVFDAlgoIndexListener_FFFF = JNIEnv.GetMethodID (class_ref, "onECGHRVFDAlgoIndexListener", "(FFFF)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onECGHRVFDAlgoIndexListener_FFFF, __args);
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVFDAlgoIndexListener.onECGHRVFDAlgoIndexListener
		public partial class ECGHRVFDAlgoIndexEventArgs : global::System.EventArgs {
			public ECGHRVFDAlgoIndexEventArgs (float p0, float p1, float p2, float p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			float p0;

			public float P0 {
				get { return p0; }
			}

			float p1;

			public float P1 {
				get { return p1; }
			}

			float p2;

			public float P2 {
				get { return p2; }
			}

			float p3;

			public float P3 {
				get { return p3; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor")]
		internal sealed partial class IOnECGHRVFDAlgoIndexListenerImplementor : global::Java.Lang.Object, IOnECGHRVFDAlgoIndexListener {

			object sender;

			public IOnECGHRVFDAlgoIndexListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGHRVFDAlgoIndexListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<ECGHRVFDAlgoIndexEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ECGHRVFDAlgoIndexEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnECGHRVFDAlgoIndexListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGHRVTDAlgoIndexListener']"
		[Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVTDAlgoIndexListener", "", "Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVTDAlgoIndexListenerInvoker")]
		public partial interface IOnECGHRVTDAlgoIndexListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnECGHRVTDAlgoIndexListener']/method[@name='onECGHRVTDAlgoIndexListener' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
			[Register ("onECGHRVTDAlgoIndexListener", "(FFFFF)V", "GetOnECGHRVTDAlgoIndexListener_FFFFFHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnECGHRVTDAlgoIndexListenerInvoker, BleDev")]
			void OnECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4);

		}

		[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVTDAlgoIndexListener", DoNotGenerateAcw=true)]
		internal partial class IOnECGHRVTDAlgoIndexListenerInvoker : global::Java.Lang.Object, IOnECGHRVTDAlgoIndexListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVTDAlgoIndexListener", typeof (IOnECGHRVTDAlgoIndexListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnECGHRVTDAlgoIndexListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnECGHRVTDAlgoIndexListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVTDAlgoIndexListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnECGHRVTDAlgoIndexListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onECGHRVTDAlgoIndexListener_FFFFF;
#pragma warning disable 0169
			static Delegate GetOnECGHRVTDAlgoIndexListener_FFFFFHandler ()
			{
				if (cb_onECGHRVTDAlgoIndexListener_FFFFF == null)
					cb_onECGHRVTDAlgoIndexListener_FFFFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFFFF_V) n_OnECGHRVTDAlgoIndexListener_FFFFF);
				return cb_onECGHRVTDAlgoIndexListener_FFFFF;
			}

			static void n_OnECGHRVTDAlgoIndexListener_FFFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3, float p4)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnECGHRVTDAlgoIndexListener (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			IntPtr id_onECGHRVTDAlgoIndexListener_FFFFF;
			public unsafe void OnECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4)
			{
				if (id_onECGHRVTDAlgoIndexListener_FFFFF == IntPtr.Zero)
					id_onECGHRVTDAlgoIndexListener_FFFFF = JNIEnv.GetMethodID (class_ref, "onECGHRVTDAlgoIndexListener", "(FFFFF)V");
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onECGHRVTDAlgoIndexListener_FFFFF, __args);
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVTDAlgoIndexListener.onECGHRVTDAlgoIndexListener
		public partial class ECGHRVTDAlgoIndexEventArgs : global::System.EventArgs {
			public ECGHRVTDAlgoIndexEventArgs (float p0, float p1, float p2, float p3, float p4)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
				this.p4 = p4;
			}

			float p0;

			public float P0 {
				get { return p0; }
			}

			float p1;

			public float P1 {
				get { return p1; }
			}

			float p2;

			public float P2 {
				get { return p2; }
			}

			float p3;

			public float P3 {
				get { return p3; }
			}

			float p4;

			public float P4 {
				get { return p4; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor")]
		internal sealed partial class IOnECGHRVTDAlgoIndexListenerImplementor : global::Java.Lang.Object, IOnECGHRVTDAlgoIndexListener {

			object sender;

			public IOnECGHRVTDAlgoIndexListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnECGHRVTDAlgoIndexListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<ECGHRVTDAlgoIndexEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ECGHRVTDAlgoIndexEventArgs (p0, p1, p2, p3, p4));
			}

			internal static bool __IsEmpty (IOnECGHRVTDAlgoIndexListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnSignalQualityListener']"
		[Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnSignalQualityListener", "", "Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnSignalQualityListenerInvoker")]
		public partial interface IOnSignalQualityListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnSignalQualityListener']/method[@name='onOverallSignalQuality' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onOverallSignalQuality", "(I)V", "GetOnOverallSignalQuality_IHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnSignalQualityListenerInvoker, BleDev")]
			void OnOverallSignalQuality (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnSignalQualityListener']/method[@name='onSignalQuality' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onSignalQuality", "(I)V", "GetOnSignalQuality_IHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnSignalQualityListenerInvoker, BleDev")]
			void OnSignalQuality (int p0);

		}

		[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnSignalQualityListener", DoNotGenerateAcw=true)]
		internal partial class IOnSignalQualityListenerInvoker : global::Java.Lang.Object, IOnSignalQualityListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk$OnSignalQualityListener", typeof (IOnSignalQualityListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSignalQualityListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSignalQualityListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.neurosky.AlgoSdk.NskAlgoSdk.OnSignalQualityListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSignalQualityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onOverallSignalQuality_I;
#pragma warning disable 0169
			static Delegate GetOnOverallSignalQuality_IHandler ()
			{
				if (cb_onOverallSignalQuality_I == null)
					cb_onOverallSignalQuality_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnOverallSignalQuality_I);
				return cb_onOverallSignalQuality_I;
			}

			static void n_OnOverallSignalQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnOverallSignalQuality (p0);
			}
#pragma warning restore 0169

			IntPtr id_onOverallSignalQuality_I;
			public unsafe void OnOverallSignalQuality (int p0)
			{
				if (id_onOverallSignalQuality_I == IntPtr.Zero)
					id_onOverallSignalQuality_I = JNIEnv.GetMethodID (class_ref, "onOverallSignalQuality", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOverallSignalQuality_I, __args);
			}

			static Delegate? cb_onSignalQuality_I;
#pragma warning disable 0169
			static Delegate GetOnSignalQuality_IHandler ()
			{
				if (cb_onSignalQuality_I == null)
					cb_onSignalQuality_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnSignalQuality_I);
				return cb_onSignalQuality_I;
			}

			static void n_OnSignalQuality_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnSignalQuality (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSignalQuality_I;
			public unsafe void OnSignalQuality (int p0)
			{
				if (id_onSignalQuality_I == IntPtr.Zero)
					id_onSignalQuality_I = JNIEnv.GetMethodID (class_ref, "onSignalQuality", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSignalQuality_I, __args);
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnSignalQualityListener.onOverallSignalQuality
		public partial class OverallSignalQualityEventArgs : global::System.EventArgs {
			public OverallSignalQualityEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnSignalQualityListener.onSignalQuality
		public partial class SignalQualityEventArgs : global::System.EventArgs {
			public SignalQualityEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnSignalQualityListenerImplementor")]
		internal sealed partial class IOnSignalQualityListenerImplementor : global::Java.Lang.Object, IOnSignalQualityListener {

			object sender;

			public IOnSignalQualityListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnSignalQualityListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<OverallSignalQualityEventArgs>? OnOverallSignalQualityHandler;
			#pragma warning restore 0649

			public void OnOverallSignalQuality (int p0)
			{
				var __h = OnOverallSignalQualityHandler;
				if (__h != null)
					__h (sender, new OverallSignalQualityEventArgs (p0));
			}

			#pragma warning disable 0649
			public EventHandler<SignalQualityEventArgs>? OnSignalQualityHandler;
			#pragma warning restore 0649

			public void OnSignalQuality (int p0)
			{
				var __h = OnSignalQualityHandler;
				if (__h != null)
					__h (sender, new SignalQualityEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSignalQualityListenerImplementor value)
			{
				return value.OnOverallSignalQualityHandler == null && value.OnSignalQualityHandler == null;
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnStateChangeListener']"
		[Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnStateChangeListener", "", "Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnStateChangeListenerInvoker")]
		public partial interface IOnStateChangeListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/interface[@name='NskAlgoSdk.OnStateChangeListener']/method[@name='onStateChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onStateChange", "(II)V", "GetOnStateChange_IIHandler:Com.Neurosky.AlgoSdk.NskAlgoSdk/IOnStateChangeListenerInvoker, BleDev")]
			void OnStateChange (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/neurosky/AlgoSdk/NskAlgoSdk$OnStateChangeListener", DoNotGenerateAcw=true)]
		internal partial class IOnStateChangeListenerInvoker : global::Java.Lang.Object, IOnStateChangeListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk$OnStateChangeListener", typeof (IOnStateChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnStateChangeListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnStateChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.neurosky.AlgoSdk.NskAlgoSdk.OnStateChangeListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnStateChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_onStateChange_II;
#pragma warning disable 0169
			static Delegate GetOnStateChange_IIHandler ()
			{
				if (cb_onStateChange_II == null)
					cb_onStateChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnStateChange_II);
				return cb_onStateChange_II;
			}

			static void n_OnStateChange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				__this.OnStateChange (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onStateChange_II;
			public unsafe void OnStateChange (int p0, int p1)
			{
				if (id_onStateChange_II == IntPtr.Zero)
					id_onStateChange_II = JNIEnv.GetMethodID (class_ref, "onStateChange", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStateChange_II, __args);
			}

		}

		// event args for com.neurosky.AlgoSdk.NskAlgoSdk.OnStateChangeListener.onStateChange
		public partial class StateChangeEventArgs : global::System.EventArgs {
			public StateChangeEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;

			public int P0 {
				get { return p0; }
			}

			int p1;

			public int P1 {
				get { return p1; }
			}

		}

		[global::Android.Runtime.Register ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnStateChangeListenerImplementor")]
		internal sealed partial class IOnStateChangeListenerImplementor : global::Java.Lang.Object, IOnStateChangeListener {

			object sender;

			public IOnStateChangeListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/neurosky/AlgoSdk/NskAlgoSdk_OnStateChangeListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<StateChangeEventArgs>? Handler;
			#pragma warning restore 0649

			public void OnStateChange (int p0, int p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new StateChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnStateChangeListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/neurosky/AlgoSdk/NskAlgoSdk", typeof (NskAlgoSdk));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected NskAlgoSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/constructor[@name='NskAlgoSdk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NskAlgoSdk () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgECGHRVFDAlgoIndexListener' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("NskAlgECGHRVFDAlgoIndexListener", "(FFFF)V", "")]
		public static unsafe void NskAlgECGHRVFDAlgoIndexListener (float p0, float p1, float p2, float p3)
		{
			const string __id = "NskAlgECGHRVFDAlgoIndexListener.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgECGHRVTDAlgoIndexListener' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("NskAlgECGHRVTDAlgoIndexListener", "(FFFFF)V", "")]
		public static unsafe void NskAlgECGHRVTDAlgoIndexListener (float p0, float p1, float p2, float p3, float p4)
		{
			const string __id = "NskAlgECGHRVTDAlgoIndexListener.(FFFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoAlgoVersion' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoAlgoVersion", "(I)Ljava/lang/String;", "")]
		public static unsafe string? NskAlgoAlgoVersion (int p0)
		{
			const string __id = "NskAlgoAlgoVersion.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoDataStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='short[]'] and parameter[3][@type='int']]"
		[Register ("NskAlgoDataStream", "(I[SI)I", "")]
		public static unsafe int NskAlgoDataStream (int p0, short[]? p1, int p2)
		{
			const string __id = "NskAlgoDataStream.(I[SI)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoECGAlgoIndexListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoECGAlgoIndexListener", "(II)V", "")]
		public static unsafe void NskAlgoECGAlgoIndexListener (int p0, int p1)
		{
			const string __id = "NskAlgoECGAlgoIndexListener.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoInit' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("NskAlgoInit", "(ILjava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int NskAlgoInit (int p0, string? p1, string? p2)
		{
			const string __id = "NskAlgoInit.(ILjava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p1 = JNIEnv.NewString ((string?)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string?)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoOverallSignalQualityListener' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoOverallSignalQualityListener", "(I)V", "")]
		public static unsafe void NskAlgoOverallSignalQualityListener (int p0)
		{
			const string __id = "NskAlgoOverallSignalQualityListener.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoPause' and count(parameter)=0]"
		[Register ("NskAlgoPause", "()I", "")]
		public static unsafe int NskAlgoPause ()
		{
			const string __id = "NskAlgoPause.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfileActive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoProfileActive", "(I)Z", "")]
		public static unsafe bool NskAlgoProfileActive (int p0)
		{
			const string __id = "NskAlgoProfileActive.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfileDelete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoProfileDelete", "(I)Z", "")]
		public static unsafe bool NskAlgoProfileDelete (int p0)
		{
			const string __id = "NskAlgoProfileDelete.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfileGetBaseline' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoProfileGetBaseline", "(II)[B", "")]
		public static unsafe byte[]? NskAlgoProfileGetBaseline (int p0, int p1)
		{
			const string __id = "NskAlgoProfileGetBaseline.(II)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfileSetBaseline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("NskAlgoProfileSetBaseline", "(II[B)Z", "")]
		public static unsafe bool NskAlgoProfileSetBaseline (int p0, int p1, byte[]? p2)
		{
			const string __id = "NskAlgoProfileSetBaseline.(II[B)Z";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfileUpdate' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoProfile']]"
		[Register ("NskAlgoProfileUpdate", "(Lcom/neurosky/AlgoSdk/NskAlgoProfile;)Z", "")]
		public static unsafe bool NskAlgoProfileUpdate (global::Com.Neurosky.AlgoSdk.NskAlgoProfile? p0)
		{
			const string __id = "NskAlgoProfileUpdate.(Lcom/neurosky/AlgoSdk/NskAlgoProfile;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoProfiles' and count(parameter)=0]"
		[Register ("NskAlgoProfiles", "()[Lcom/neurosky/AlgoSdk/NskAlgoProfile;", "")]
		public static unsafe global::Com.Neurosky.AlgoSdk.NskAlgoProfile[]? NskAlgoProfiles ()
		{
			const string __id = "NskAlgoProfiles.()[Lcom/neurosky/AlgoSdk/NskAlgoProfile;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Neurosky.AlgoSdk.NskAlgoProfile[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Neurosky.AlgoSdk.NskAlgoProfile));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoQueryOverallQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoQueryOverallQuality", "(I)Z", "")]
		public static unsafe bool NskAlgoQueryOverallQuality (int p0)
		{
			const string __id = "NskAlgoQueryOverallQuality.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSdkStateChangeListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoSdkStateChangeListener", "(II)V", "")]
		public static unsafe void NskAlgoSdkStateChangeListener (int p0, int p1)
		{
			const string __id = "NskAlgoSdkStateChangeListener.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSdkVersion' and count(parameter)=0]"
		[Register ("NskAlgoSdkVersion", "()Ljava/lang/String;", "")]
		public static unsafe string? NskAlgoSdkVersion ()
		{
			const string __id = "NskAlgoSdkVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigAfib' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("NskAlgoSetECGConfigAfib", "(F)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigAfib (float p0)
		{
			const string __id = "NskAlgoSetECGConfigAfib.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigHRV' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoSetECGConfigHRV", "(I)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigHRV (int p0)
		{
			const string __id = "NskAlgoSetECGConfigHRV.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigHRVFD' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoSetECGConfigHRVFD", "(II)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigHRVFD (int p0, int p1)
		{
			const string __id = "NskAlgoSetECGConfigHRVFD.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigHRVTD' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoSetECGConfigHRVTD", "(II)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigHRVTD (int p0, int p1)
		{
			const string __id = "NskAlgoSetECGConfigHRVTD.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigHeartage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoSetECGConfigHeartage", "(I)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigHeartage (int p0)
		{
			const string __id = "NskAlgoSetECGConfigHeartage.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSetECGConfigStress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("NskAlgoSetECGConfigStress", "(II)Z", "")]
		public static unsafe bool NskAlgoSetECGConfigStress (int p0, int p1)
		{
			const string __id = "NskAlgoSetECGConfigStress.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoSignalQualityListener' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("NskAlgoSignalQualityListener", "(I)V", "")]
		public static unsafe void NskAlgoSignalQualityListener (int p0)
		{
			const string __id = "NskAlgoSignalQualityListener.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoStart' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("NskAlgoStart", "(Z)I", "")]
		public static unsafe int NskAlgoStart (bool p0)
		{
			const string __id = "NskAlgoStart.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoStop' and count(parameter)=0]"
		[Register ("NskAlgoStop", "()I", "")]
		public static unsafe int NskAlgoStop ()
		{
			const string __id = "NskAlgoStop.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='NskAlgoUninit' and count(parameter)=0]"
		[Register ("NskAlgoUninit", "()I", "")]
		public static unsafe int NskAlgoUninit ()
		{
			const string __id = "NskAlgoUninit.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='dateToStr' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("dateToStr", "(Ljava/util/Date;)Ljava/lang/String;", "")]
		public static unsafe string? DateToStr (global::Java.Util.Date? p0)
		{
			const string __id = "dateToStr.(Ljava/util/Date;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setBaudRate_II;
#pragma warning disable 0169
		static Delegate GetSetBaudRate_IIHandler ()
		{
			if (cb_setBaudRate_II == null)
				cb_setBaudRate_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_SetBaudRate_II);
			return cb_setBaudRate_II;
		}

		static bool n_SetBaudRate_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetBaudRate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setBaudRate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setBaudRate", "(II)Z", "GetSetBaudRate_IIHandler")]
		public virtual unsafe bool SetBaudRate (int p0, int p1)
		{
			const string __id = "setBaudRate.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate? cb_setOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_;
#pragma warning disable 0169
		static Delegate GetSetOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_Handler ()
		{
			if (cb_setOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_ == null)
				cb_setOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_);
			return cb_setOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_;
		}

		static void n_SetOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener?)global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnECGAlgoIndexListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setOnECGAlgoIndexListener' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoSdk.OnECGAlgoIndexListener']]"
		[Register ("setOnECGAlgoIndexListener", "(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGAlgoIndexListener;)V", "GetSetOnECGAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGAlgoIndexListener_Handler")]
		public virtual unsafe void SetOnECGAlgoIndexListener (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener? p0)
		{
			const string __id = "setOnECGAlgoIndexListener.(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGAlgoIndexListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_;
#pragma warning disable 0169
		static Delegate GetSetOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_Handler ()
		{
			if (cb_setOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_ == null)
				cb_setOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_);
			return cb_setOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_;
		}

		static void n_SetOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener?)global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnECGHRVFDAlgoIndexListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setOnECGHRVFDAlgoIndexListener' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVFDAlgoIndexListener']]"
		[Register ("setOnECGHRVFDAlgoIndexListener", "(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVFDAlgoIndexListener;)V", "GetSetOnECGHRVFDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVFDAlgoIndexListener_Handler")]
		public virtual unsafe void SetOnECGHRVFDAlgoIndexListener (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener? p0)
		{
			const string __id = "setOnECGHRVFDAlgoIndexListener.(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVFDAlgoIndexListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_;
#pragma warning disable 0169
		static Delegate GetSetOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_Handler ()
		{
			if (cb_setOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_ == null)
				cb_setOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_);
			return cb_setOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_;
		}

		static void n_SetOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener?)global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnECGHRVTDAlgoIndexListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setOnECGHRVTDAlgoIndexListener' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoSdk.OnECGHRVTDAlgoIndexListener']]"
		[Register ("setOnECGHRVTDAlgoIndexListener", "(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVTDAlgoIndexListener;)V", "GetSetOnECGHRVTDAlgoIndexListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnECGHRVTDAlgoIndexListener_Handler")]
		public virtual unsafe void SetOnECGHRVTDAlgoIndexListener (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener? p0)
		{
			const string __id = "setOnECGHRVTDAlgoIndexListener.(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnECGHRVTDAlgoIndexListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_Handler ()
		{
			if (cb_setOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_ == null)
				cb_setOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_);
			return cb_setOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_;
		}

		static void n_SetOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener?)global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnSignalQualityListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setOnSignalQualityListener' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoSdk.OnSignalQualityListener']]"
		[Register ("setOnSignalQualityListener", "(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnSignalQualityListener;)V", "GetSetOnSignalQualityListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnSignalQualityListener_Handler")]
		public virtual unsafe void SetOnSignalQualityListener (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener? p0)
		{
			const string __id = "setOnSignalQualityListener.(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnSignalQualityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_Handler ()
		{
			if (cb_setOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_ == null)
				cb_setOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_);
			return cb_setOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_;
		}

		static void n_SetOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener?)global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnStateChangeListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setOnStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.neurosky.AlgoSdk.NskAlgoSdk.OnStateChangeListener']]"
		[Register ("setOnStateChangeListener", "(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnStateChangeListener;)V", "GetSetOnStateChangeListener_Lcom_neurosky_AlgoSdk_NskAlgoSdk_OnStateChangeListener_Handler")]
		public virtual unsafe void SetOnStateChangeListener (global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener? p0)
		{
			const string __id = "setOnStateChangeListener.(Lcom/neurosky/AlgoSdk/NskAlgoSdk$OnStateChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate? cb_setSignalQualityWatchDog_SS;
#pragma warning disable 0169
		static Delegate GetSetSignalQualityWatchDog_SSHandler ()
		{
			if (cb_setSignalQualityWatchDog_SS == null)
				cb_setSignalQualityWatchDog_SS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPSS_Z) n_SetSignalQualityWatchDog_SS);
			return cb_setSignalQualityWatchDog_SS;
		}

		static bool n_SetSignalQualityWatchDog_SS (IntPtr jnienv, IntPtr native__this, short p0, short p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Neurosky.AlgoSdk.NskAlgoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.SetSignalQualityWatchDog (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='setSignalQualityWatchDog' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("setSignalQualityWatchDog", "(SS)Z", "GetSetSignalQualityWatchDog_SSHandler")]
		public virtual unsafe bool SetSignalQualityWatchDog (short p0, short p1)
		{
			const string __id = "setSignalQualityWatchDog.(SS)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.neurosky.AlgoSdk']/class[@name='NskAlgoSdk']/method[@name='strToDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("strToDate", "(Ljava/lang/String;)Ljava/util/Date;", "")]
		public static unsafe global::Java.Util.Date? StrToDate (string? p0)
		{
			const string __id = "strToDate.(Ljava/lang/String;)Ljava/util/Date;";
			IntPtr native_p0 = JNIEnv.NewString ((string?)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		#region "Event implementation for Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener"

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.ECGAlgoIndexEventArgs> ECGAlgoIndex {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGAlgoIndexListener,
				__CreateIOnECGAlgoIndexListenerImplementor,
				SetOnECGAlgoIndexListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGAlgoIndexListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListenerImplementor.__IsEmpty,
				__v => SetOnECGAlgoIndexListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnECGAlgoIndexListener;

		global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListenerImplementor __CreateIOnECGAlgoIndexListenerImplementor ()
		{
			return new global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGAlgoIndexListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener"

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.ECGHRVFDAlgoIndexEventArgs> ECGHRVFDAlgoIndex {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGHRVFDAlgoIndexListener,
				__CreateIOnECGHRVFDAlgoIndexListenerImplementor,
				SetOnECGHRVFDAlgoIndexListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGHRVFDAlgoIndexListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListenerImplementor.__IsEmpty,
				__v => SetOnECGHRVFDAlgoIndexListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnECGHRVFDAlgoIndexListener;

		global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListenerImplementor __CreateIOnECGHRVFDAlgoIndexListenerImplementor ()
		{
			return new global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVFDAlgoIndexListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener"

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.ECGHRVTDAlgoIndexEventArgs> ECGHRVTDAlgoIndex {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGHRVTDAlgoIndexListener,
				__CreateIOnECGHRVTDAlgoIndexListenerImplementor,
				SetOnECGHRVTDAlgoIndexListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListenerImplementor>(
				ref weak_implementor_SetOnECGHRVTDAlgoIndexListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListenerImplementor.__IsEmpty,
				__v => SetOnECGHRVTDAlgoIndexListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnECGHRVTDAlgoIndexListener;

		global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListenerImplementor __CreateIOnECGHRVTDAlgoIndexListenerImplementor ()
		{
			return new global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnECGHRVTDAlgoIndexListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener"

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.OverallSignalQualityEventArgs> OverallSignalQuality {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor>(
				ref weak_implementor_SetOnSignalQualityListener,
				__CreateIOnSignalQualityListenerImplementor,
				SetOnSignalQualityListener,
				__h => __h.OnOverallSignalQualityHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor>(
				ref weak_implementor_SetOnSignalQualityListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor.__IsEmpty,
				__v => SetOnSignalQualityListener (null),
				__h => __h.OnOverallSignalQualityHandler -= value);
			}
		}

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.SignalQualityEventArgs> SignalQuality {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor>(
				ref weak_implementor_SetOnSignalQualityListener,
				__CreateIOnSignalQualityListenerImplementor,
				SetOnSignalQualityListener,
				__h => __h.OnSignalQualityHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor>(
				ref weak_implementor_SetOnSignalQualityListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor.__IsEmpty,
				__v => SetOnSignalQualityListener (null),
				__h => __h.OnSignalQualityHandler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnSignalQualityListener;

		global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor __CreateIOnSignalQualityListenerImplementor ()
		{
			return new global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnSignalQualityListenerImplementor (this);
		}

		#endregion

		#region "Event implementation for Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener"

		public event EventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.StateChangeEventArgs> StateChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListenerImplementor>(
				ref weak_implementor_SetOnStateChangeListener,
				__CreateIOnStateChangeListenerImplementor,
				SetOnStateChangeListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListener, global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListenerImplementor>(
				ref weak_implementor_SetOnStateChangeListener,
				global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListenerImplementor.__IsEmpty,
				__v => SetOnStateChangeListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference? weak_implementor_SetOnStateChangeListener;

		global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListenerImplementor __CreateIOnStateChangeListenerImplementor ()
		{
			return new global::Com.Neurosky.AlgoSdk.NskAlgoSdk.IOnStateChangeListenerImplementor (this);
		}

		#endregion

	}
}
