using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D0 RID: 5072
	public static class UnlockTutorialGuideScRspReflection
	{
		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x0600E21F RID: 57887 RVA: 0x002596F2 File Offset: 0x002578F2
		public static FileDescriptor Descriptor
		{
			get
			{
				return UnlockTutorialGuideScRspReflection.descriptor;
			}
		}

		// Token: 0x040059F2 RID: 23026
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aE1R1dG9yaWFsR3Vp" + "ZGUucHJvdG8iUgoYVW5sb2NrVHV0b3JpYWxHdWlkZVNjUnNwEg8KB3JldGNv" + "ZGUYAyABKA0SJQoNVHV0b3JpYWxHdWlkZRgJIAEoCzIOLlR1dG9yaWFsR3Vp" + "ZGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			TutorialGuideReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UnlockTutorialGuideScRsp), UnlockTutorialGuideScRsp.Parser, new string[]
			{
				"Retcode",
				"TutorialGuide"
			}, null, null, null, null)
		}));
	}
}
