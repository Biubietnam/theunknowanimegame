using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D9A RID: 3482
	public static class RelicReflection
	{
		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0019DF81 File Offset: 0x0019C181
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicReflection.descriptor;
			}
		}

		// Token: 0x04003C5D RID: 15453
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CgtSZWxpYy5wcm90bxoQUmVsaWNBZmZpeC5wcm90byLEAQoFUmVsaWMSFwoP",
			"ZHJlc3NfYXZhdGFyX2lkGAggASgNEg0KBWxldmVsGAcgASgNEhUKDW1haW5f",
			"YWZmaXhfaWQYBiABKA0SEQoJdW5pcXVlX2lkGAsgASgNEgsKA3RpZBgBIAEo",
			"DRIjCg5zdWJfYWZmaXhfbGlzdBgFIAMoCzILLlJlbGljQWZmaXgSFAoMaXNf",
			"ZGlzY2FyZGVkGA0gASgIEgsKA2V4cBgOIAEoDRIUCgxpc19wcm90ZWN0ZWQY",
			"DyABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RelicAffixReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Relic), Relic.Parser, new string[]
			{
				"DressAvatarId",
				"Level",
				"MainAffixId",
				"UniqueId",
				"Tid",
				"SubAffixList",
				"IsDiscarded",
				"Exp",
				"IsProtected"
			}, null, null, null, null)
		}));
	}
}
