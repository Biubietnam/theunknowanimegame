using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200114C RID: 4428
	public static class ShopReflection
	{
		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600C592 RID: 50578 RVA: 0x002122FA File Offset: 0x002104FA
		public static FileDescriptor Descriptor
		{
			get
			{
				return ShopReflection.descriptor;
			}
		}

		// Token: 0x04004FC6 RID: 20422
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CgpTaG9wLnByb3RvGgtHb29kcy5wcm90byKYAQoEU2hvcBIOCgZTaG9wSWQY",
			"ByABKA0SEQoJQ2l0eUxldmVsGA8gASgNEhEKCUJlZ2luVGltZRgEIAEoAxIP",
			"CgdDaXR5RXhwGAYgASgNEg8KB0VuZFRpbWUYCiABKAMSGgoKZ29vZHNfbGlz",
			"dBgNIAMoCzIGLkdvb2RzEhwKFENpdHlUYWtlbkxldmVsUmV3YXJkGAUgASgE",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			GoodsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Shop), Shop.Parser, new string[]
			{
				"ShopId",
				"CityLevel",
				"BeginTime",
				"CityExp",
				"EndTime",
				"GoodsList",
				"CityTakenLevelReward"
			}, null, null, null, null)
		}));
	}
}
