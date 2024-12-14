using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002C8 RID: 712
	public static class CityShopInfoScNotifyReflection
	{
		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0005A1D0 File Offset: 0x000583D0
		public static FileDescriptor Descriptor
		{
			get
			{
				return CityShopInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000D19 RID: 3353
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDaXR5U2hvcEluZm9TY05vdGlmeS5wcm90byJcChRDaXR5U2hvcEluZm9T" + "Y05vdGlmeRIOCgZTaG9wSWQYBiABKA0SDQoFbGV2ZWwYCCABKA0SCwoDRXhw" + "GAIgASgNEhgKEFRha2VuTGV2ZWxSZXdhcmQYCyABKARCHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CityShopInfoScNotify), CityShopInfoScNotify.Parser, new string[]
			{
				"ShopId",
				"Level",
				"Exp",
				"TakenLevelReward"
			}, null, null, null, null)
		}));
	}
}
