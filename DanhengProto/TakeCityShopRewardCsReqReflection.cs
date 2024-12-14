using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012CE RID: 4814
	public static class TakeCityShopRewardCsReqReflection
	{
		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x0600D6C5 RID: 54981 RVA: 0x0023CCB4 File Offset: 0x0023AEB4
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeCityShopRewardCsReqReflection.descriptor;
			}
		}

		// Token: 0x040055BE RID: 21950
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlQ2l0eVNob3BSZXdhcmRDc1JlcS5wcm90byI5ChdUYWtlQ2l0eVNo" + "b3BSZXdhcmRDc1JlcRIPCgdzaG9wX2lkGA8gASgNEg0KBWxldmVsGAogASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeCityShopRewardCsReq), TakeCityShopRewardCsReq.Parser, new string[]
			{
				"ShopId",
				"Level"
			}, null, null, null, null)
		}));
	}
}
