using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B84 RID: 2948
	public static class MonopolyTakeRaffleTicketRewardScRspReflection
	{
		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x0600827E RID: 33406 RVA: 0x001579CD File Offset: 0x00155BCD
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyTakeRaffleTicketRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040031C0 RID: 12736
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRTY1JzcC5wcm90bxoO",
			"SXRlbUxpc3QucHJvdG8ifAojTW9ub3BvbHlUYWtlUmFmZmxlVGlja2V0UmV3",
			"YXJkU2NSc3ASHgoLcmV3YXJkX2xpc3QYASABKAsyCS5JdGVtTGlzdBIPCgdy",
			"ZXRjb2RlGAUgASgNEhMKC0NGQUFCQ0xHS0dCGAogASgNEg8KB3Bvb2xfaWQY",
			"CyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakeRaffleTicketRewardScRsp), MonopolyTakeRaffleTicketRewardScRsp.Parser, new string[]
			{
				"RewardList",
				"Retcode",
				"CFAABCLGKGB",
				"PoolId"
			}, null, null, null, null)
		}));
	}
}
