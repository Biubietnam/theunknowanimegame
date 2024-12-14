using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086C RID: 2156
	public static class GmTalkScRspReflection
	{
		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06005FD6 RID: 24534 RVA: 0x000FD5CE File Offset: 0x000FB7CE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GmTalkScRspReflection.descriptor;
			}
		}

		// Token: 0x040024D7 RID: 9431
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHbVRhbGtTY1JzcC5wcm90byIzCgtHbVRhbGtTY1JzcBIPCgdyZXRjb2Rl" + "GAYgASgNEhMKC0FJT0NPTE5KTEdFGA4gASgJQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GmTalkScRsp), GmTalkScRsp.Parser, new string[]
			{
				"Retcode",
				"AIOCOLNJLGE"
			}, null, null, null, null)
		}));
	}
}
