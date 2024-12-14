using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D9C RID: 3484
	public static class RelicAffixReflection
	{
		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06009BB4 RID: 39860 RVA: 0x0019E7AE File Offset: 0x0019C9AE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RelicAffixReflection.descriptor;
			}
		}

		// Token: 0x04003C73 RID: 15475
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBSZWxpY0FmZml4LnByb3RvIjkKClJlbGljQWZmaXgSEAoIYWZmaXhfaWQY" + "ASABKA0SCwoDY250GAIgASgNEgwKBHN0ZXAYAyABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RelicAffix), RelicAffix.Parser, new string[]
			{
				"AffixId",
				"Cnt",
				"Step"
			}, null, null, null, null)
		}));
	}
}
