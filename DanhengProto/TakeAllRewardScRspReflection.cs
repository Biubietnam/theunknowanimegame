using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B4 RID: 4788
	public static class TakeAllRewardScRspReflection
	{
		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600D59A RID: 54682 RVA: 0x0023A034 File Offset: 0x00238234
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeAllRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400555F RID: 21855
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUYWtlQWxsUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIkAK" + "ElRha2VBbGxSZXdhcmRTY1JzcBIZCgZyZXdhcmQYCyABKAsyCS5JdGVtTGlz" + "dBIPCgdyZXRjb2RlGA0gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeAllRewardScRsp), TakeAllRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
