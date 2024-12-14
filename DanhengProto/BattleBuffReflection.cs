using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000DA RID: 218
	public static class BattleBuffReflection
	{
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0001D14E File Offset: 0x0001B34E
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleBuffReflection.descriptor;
			}
		}

		// Token: 0x0400040F RID: 1039
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBCYXR0bGVCdWZmLnByb3RvItgBCgpCYXR0bGVCdWZmEgoKAmlkGAEgASgN",
			"Eg0KBWxldmVsGAIgASgNEhMKC293bmVyX2luZGV4GAMgASgNEhEKCXdhdmVf",
			"ZmxhZxgEIAEoDRIZChF0YXJnZXRfaW5kZXhfbGlzdBgFIAMoDRI2Cg5keW5h",
			"bWljX3ZhbHVlcxgGIAMoCzIeLkJhdHRsZUJ1ZmYuRHluYW1pY1ZhbHVlc0Vu",
			"dHJ5GjQKEkR5bmFtaWNWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs",
			"dWUYAiABKAI6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleBuff), BattleBuff.Parser, new string[]
			{
				"Id",
				"Level",
				"OwnerIndex",
				"WaveFlag",
				"TargetIndexList",
				"DynamicValues"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
