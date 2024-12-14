using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AA RID: 170
	public static class ApplyFriendScRspReflection
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00014DC9 File Offset: 0x00012FC9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ApplyFriendScRspReflection.descriptor;
			}
		}

		// Token: 0x040002BD RID: 701
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBcHBseUZyaWVuZFNjUnNwLnByb3RvIjAKEEFwcGx5RnJpZW5kU2NSc3AS" + "CwoDdWlkGAggASgNEg8KB3JldGNvZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ApplyFriendScRsp), ApplyFriendScRsp.Parser, new string[]
			{
				"Uid",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
