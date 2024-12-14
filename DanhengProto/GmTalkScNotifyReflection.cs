using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086A RID: 2154
	public static class GmTalkScNotifyReflection
	{
		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x000FD332 File Offset: 0x000FB532
		public static FileDescriptor Descriptor
		{
			get
			{
				return GmTalkScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040024D2 RID: 9426
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRHbVRhbGtTY05vdGlmeS5wcm90byIdCg5HbVRhbGtTY05vdGlmeRILCgNt" + "c2cYByABKAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GmTalkScNotify), GmTalkScNotify.Parser, new string[]
			{
				"Msg"
			}, null, null, null, null)
		}));
	}
}
