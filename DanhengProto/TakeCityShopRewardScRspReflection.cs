using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D0 RID: 4816
	public static class TakeCityShopRewardScRspReflection
	{
		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x0600D6DC RID: 55004 RVA: 0x0023CFE9 File Offset: 0x0023B1E9
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeCityShopRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040055C5 RID: 21957
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1UYWtlQ2l0eVNob3BSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv",
			"dG8iZAoXVGFrZUNpdHlTaG9wUmV3YXJkU2NSc3ASGQoGcmV3YXJkGAkgASgL",
			"MgkuSXRlbUxpc3QSDQoFbGV2ZWwYDyABKA0SDgoGU2hvcElkGAwgASgNEg8K",
			"B3JldGNvZGUYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeCityShopRewardScRsp), TakeCityShopRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Level",
				"ShopId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
