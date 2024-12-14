using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F0 RID: 4336
	public static class SetFriendMarkCsReqReflection
	{
		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600C158 RID: 49496 RVA: 0x00207B44 File Offset: 0x00205D44
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetFriendMarkCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004E4C RID: 20044
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRGcmllbmRNYXJrQ3NSZXEucHJvdG8iRgoSU2V0RnJpZW5kTWFya0Nz" + "UmVxEhMKC0xCSU9LTFBJQUNNGAwgASgIEg4KBnJlYXNvbhgFIAEoDRILCgN1" + "aWQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendMarkCsReq), SetFriendMarkCsReq.Parser, new string[]
			{
				"LBIOKLPIACM",
				"Reason",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
