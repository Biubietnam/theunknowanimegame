using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000144 RID: 324
	public static class BuffInfoReflection
	{
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0002AD35 File Offset: 0x00028F35
		public static FileDescriptor Descriptor
		{
			get
			{
				return BuffInfoReflection.descriptor;
			}
		}

		// Token: 0x04000641 RID: 1601
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg5CdWZmSW5mby5wcm90byKEAgoIQnVmZkluZm8SNAoOZHluYW1pY192YWx1",
			"ZXMYAyADKAsyHC5CdWZmSW5mby5EeW5hbWljVmFsdWVzRW50cnkSDQoFY291",
			"bnQYDSABKA0SDQoFbGV2ZWwYBSABKA0SDwoHYnVmZl9pZBgHIAEoDRIdChVi",
			"dWZmX3N1bW1vbl9lbnRpdHlfaWQYBiABKA0SEwoLYWRkX3RpbWVfbXMYCSAB",
			"KAQSEQoJbGlmZV90aW1lGAEgASgCEhYKDmJhc2VfYXZhdGFyX2lkGA4gASgN",
			"GjQKEkR5bmFtaWNWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY",
			"AiABKAI6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BuffInfo), BuffInfo.Parser, new string[]
			{
				"DynamicValues",
				"Count",
				"Level",
				"BuffId",
				"BuffSummonEntityId",
				"AddTimeMs",
				"LifeTime",
				"BaseAvatarId"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
