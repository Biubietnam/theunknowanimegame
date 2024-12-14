using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000948 RID: 2376
	public static class ItemReflection
	{
		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06006A1B RID: 27163 RVA: 0x0011B29D File Offset: 0x0011949D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemReflection.descriptor;
			}
		}

		// Token: 0x040028A4 RID: 10404
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgpJdGVtLnByb3RvIn4KBEl0ZW0SEQoJcHJvbW90aW9uGAQgASgNEg0KBWxl" + "dmVsGA4gASgNEgsKA251bRgLIAEoDRIMCgRyYW5rGA0gASgNEhEKCXVuaXF1" + "ZV9pZBgHIAEoDRIVCg1tYWluX2FmZml4X2lkGAkgASgNEg8KB2l0ZW1faWQY" + "CiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Item), Item.Parser, new string[]
			{
				"Promotion",
				"Level",
				"Num",
				"Rank",
				"UniqueId",
				"MainAffixId",
				"ItemId"
			}, null, null, null, null)
		}));
	}
}
