using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E06 RID: 3590
	public static class RogueAreaReflection
	{
		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600A08E RID: 41102 RVA: 0x001AEC4A File Offset: 0x001ACE4A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAreaReflection.descriptor;
			}
		}

		// Token: 0x040041C2 RID: 16834
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9Sb2d1ZUFyZWEucHJvdG8aEVJvZ3VlU3RhdHVzLnByb3RvGhVSb2d1ZUFy",
			"ZWFTdGF0dXMucHJvdG8ipgEKCVJvZ3VlQXJlYRIPCgdhcmVhX2lkGA4gASgN",
			"EhgKEGhhc190YWtlbl9yZXdhcmQYDyABKAgSDgoGbWFwX2lkGAcgASgNEiUK",
			"C2FyZWFfc3RhdHVzGAUgASgOMhAuUm9ndWVBcmVhU3RhdHVzEiIKDHJvZ3Vl",
			"X3N0YXR1cxgNIAEoDjIMLlJvZ3VlU3RhdHVzEhMKC0JHSktPTE5DT1BOGAog",
			"ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueStatusReflection.Descriptor,
			RogueAreaStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArea), RogueArea.Parser, new string[]
			{
				"AreaId",
				"HasTakenReward",
				"MapId",
				"AreaStatus",
				"RogueStatus",
				"BGJKOLNCOPN"
			}, null, null, null, null)
		}));
	}
}
