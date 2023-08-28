using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Linktop.WhealthService.Task {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='AckTask']"
	[global::Android.Runtime.Register ("com/linktop/whealthService/task/AckTask", DoNotGenerateAcw=true)]
	public sealed partial class AckTask : global::Com.Linktop.WhealthService.Task.ModuleTask {
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.linktop.whealthService.task']/interface[@name='AckTask.OnHistoricalDataCallback']"
		[Register ("com/linktop/whealthService/task/AckTask$OnHistoricalDataCallback", "", "Com.Linktop.WhealthService.Task.AckTask/IOnHistoricalDataCallbackInvoker")]
		public partial interface IOnHistoricalDataCallback : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/interface[@name='AckTask.OnHistoricalDataCallback']/method[@name='a' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Number...']]"
			[Register ("a", "(I[Ljava/lang/Number;)V", "GetA_IarrayLjava_lang_Number_Handler:Com.Linktop.WhealthService.Task.AckTask/IOnHistoricalDataCallbackInvoker, BleDev")]
			void A (int p0, params global::Java.Lang.Number[]? p1);

		}

		[global::Android.Runtime.Register ("com/linktop/whealthService/task/AckTask$OnHistoricalDataCallback", DoNotGenerateAcw=true)]
		internal partial class IOnHistoricalDataCallbackInvoker : global::Java.Lang.Object, IOnHistoricalDataCallback {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/AckTask$OnHistoricalDataCallback", typeof (IOnHistoricalDataCallbackInvoker));

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

			public static IOnHistoricalDataCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnHistoricalDataCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.linktop.whealthService.task.AckTask.OnHistoricalDataCallback'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnHistoricalDataCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate? cb_a_IarrayLjava_lang_Number_;
#pragma warning disable 0169
			static Delegate GetA_IarrayLjava_lang_Number_Handler ()
			{
				if (cb_a_IarrayLjava_lang_Number_ == null)
					cb_a_IarrayLjava_lang_Number_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_A_IarrayLjava_lang_Number_);
				return cb_a_IarrayLjava_lang_Number_;
			}

			static void n_A_IarrayLjava_lang_Number_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Linktop.WhealthService.Task.AckTask.IOnHistoricalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
				var p1 = (global::Java.Lang.Number[]?) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Number));
				__this.A (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_a_IarrayLjava_lang_Number_;
			public unsafe void A (int p0, params global::Java.Lang.Number[]? p1)
			{
				if (id_a_IarrayLjava_lang_Number_ == IntPtr.Zero)
					id_a_IarrayLjava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "a", "(I[Ljava/lang/Number;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_IarrayLjava_lang_Number_, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/linktop/whealthService/task/AckTask", typeof (AckTask));

		internal static new IntPtr class_ref {
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

		internal AckTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='AckTask']/constructor[@name='AckTask' and count(parameter)=1 and parameter[1][@type='com.linktop.whealthService.util.IBleDev']]"
		[Register (".ctor", "(Lcom/linktop/whealthService/util/IBleDev;)V", "")]
		public unsafe AckTask (global::Com.Linktop.WhealthService.Util.IBleDev? p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/linktop/whealthService/util/IBleDev;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='AckTask']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)V", "")]
		public unsafe void A (byte[]? p0)
		{
			const string __id = "a.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.linktop.whealthService.task']/class[@name='AckTask']/method[@name='dealData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("dealData", "([B)V", "")]
		public override unsafe void DealData (byte[]? p0)
		{
			const string __id = "dealData.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
