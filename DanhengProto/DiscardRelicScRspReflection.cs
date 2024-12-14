using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A6 RID: 934
	public static class DiscardRelicScRspReflection
	{
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x000734C5 File Offset: 0x000716C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return DiscardRelicScRspReflection.descriptor;
			}
		}

		// Token: 0x040010BB RID: 4283
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEaXNjYXJkUmVsaWNTY1JzcC5wcm90byI4ChFEaXNjYXJkUmVsaWNTY1Jz" + "cBIPCgdyZXRjb2RlGA8gASgNEhIKCmlzX2Rpc2NhcmQYAiABKAhCHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DiscardRelicScRsp), DiscardRelicScRsp.Parser, new string[]
			{
				"Retcode",
				"IsDiscard"
			}, null, null, null, null)
		}));
	}
}
