using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009FC RID: 2556
	public static class LeaveRaidScRspReflection
	{
		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x0012E09D File Offset: 0x0012C29D
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveRaidScRspReflection.descriptor;
			}
		}

		// Token: 0x04002BA6 RID: 11174
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMZWF2ZVJhaWRTY1JzcC5wcm90byIhCg5MZWF2ZVJhaWRTY1JzcBIPCgdy" + "ZXRjb2RlGAEgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRaidScRsp), LeaveRaidScRsp.Parser, new string[]
			{
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
