using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000876 RID: 2166
	public static class GoodsReflection
	{
		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x000FE9CB File Offset: 0x000FCBCB
		public static FileDescriptor Descriptor
		{
			get
			{
				return GoodsReflection.descriptor;
			}
		}

		// Token: 0x04002506 RID: 9478
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgtHb29kcy5wcm90byJfCgVHb29kcxIQCghCdXlUaW1lcxgBIAEoDRIRCglC" + "ZWdpblRpbWUYCyABKAMSDwoHaXRlbV9pZBgIIAEoDRIPCgdHb29kc0lkGAcg" + "ASgNEg8KB0VuZFRpbWUYAyABKANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Goods), Goods.Parser, new string[]
			{
				"BuyTimes",
				"BeginTime",
				"ItemId",
				"GoodsId",
				"EndTime"
			}, null, null, null, null)
		}));
	}
}
