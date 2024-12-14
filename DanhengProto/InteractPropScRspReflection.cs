using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000938 RID: 2360
	public static class InteractPropScRspReflection
	{
		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x001192D5 File Offset: 0x001174D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return InteractPropScRspReflection.descriptor;
			}
		}

		// Token: 0x0400285E RID: 10334
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdJbnRlcmFjdFByb3BTY1JzcC5wcm90byJQChFJbnRlcmFjdFByb3BTY1Jz" + "cBIPCgdyZXRjb2RlGA8gASgNEhIKCnByb3Bfc3RhdGUYDiABKA0SFgoOcHJv" + "cF9lbnRpdHlfaWQYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InteractPropScRsp), InteractPropScRsp.Parser, new string[]
			{
				"Retcode",
				"PropState",
				"PropEntityId"
			}, null, null, null, null)
		}));
	}
}
