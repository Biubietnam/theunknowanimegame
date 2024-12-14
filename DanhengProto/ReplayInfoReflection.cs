using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DBC RID: 3516
	public static class ReplayInfoReflection
	{
		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x06009D44 RID: 40260 RVA: 0x001A2ED2 File Offset: 0x001A10D2
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReplayInfoReflection.descriptor;
			}
		}

		// Token: 0x04003D23 RID: 15651
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBSZXBsYXlJbmZvLnByb3RvGhBSZXBsYXlUeXBlLnByb3RvItsBCgpSZXBs",
			"YXlJbmZvEhMKC0lBSkVESUZQRUlLGAEgASgEEiAKC3JlcGxheV90eXBlGAIg",
			"ASgOMgsuUmVwbGF5VHlwZRIQCghzdGFnZV9pZBgDIAEoDRILCgN1aWQYBCAB",
			"KA0SEAoIbmlja25hbWUYBSABKAkSEQoJaGVhZF9pY29uGAYgASgNEhMKC3Jl",
			"cGxheV9uYW1lGAcgASgJEhMKC2NyZWF0ZV90aW1lGAggASgEEhMKC0xERUFC",
			"R0xMRUVLGAkgASgNEhMKC0VIT0FPQUJFTkxBGAogASgNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ReplayTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReplayInfo), ReplayInfo.Parser, new string[]
			{
				"IAJEDIFPEIK",
				"ReplayType",
				"StageId",
				"Uid",
				"Nickname",
				"HeadIcon",
				"ReplayName",
				"CreateTime",
				"LDEABGLLEEK",
				"EHOAOABENLA"
			}, null, null, null, null)
		}));
	}
}
