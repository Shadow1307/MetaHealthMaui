using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop", Managed="Com.Linktop")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.constant", Managed="Com.Linktop.Constant")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.infs", Managed="Com.Linktop.Infs")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.receiver", Managed="Com.Linktop.Receiver")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.utils", Managed="Com.Linktop.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.whealthService", Managed="Com.Linktop.WhealthService")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.whealthService.task", Managed="Com.Linktop.WhealthService.Task")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.linktop.whealthService.util", Managed="Com.Linktop.WhealthService.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.neurosky.AlgoSdk", Managed="Com.Neurosky.AlgoSdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "lib.lt.ox", Managed="Lib.LT.OX")]

delegate sbyte _JniMarshal_PP_B (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPBB_V (IntPtr jnienv, IntPtr klass, sbyte p0, sbyte p1);
delegate void _JniMarshal_PPBL_V (IntPtr jnienv, IntPtr klass, sbyte p0, IntPtr p1);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate void _JniMarshal_PPDD_V (IntPtr jnienv, IntPtr klass, double p0, double p1);
delegate void _JniMarshal_PPFFFF_V (IntPtr jnienv, IntPtr klass, float p0, float p1, float p2, float p3);
delegate void _JniMarshal_PPFFFFF_V (IntPtr jnienv, IntPtr klass, float p0, float p1, float p2, float p3, float p4);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate bool _JniMarshal_PPII_Z (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLDI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, double p1, int p2);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPSS_Z (IntPtr jnienv, IntPtr klass, short p0, short p1);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZI_V (IntPtr jnienv, IntPtr klass, bool p0, int p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

