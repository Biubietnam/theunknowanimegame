using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E18 RID: 3608
	public static class RogueBuffEnhanceInfoReflection
	{
		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0600A12D RID: 41261 RVA: 0x001B025D File Offset: 0x001AE45D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfoReflection.descriptor;
			}
		}

		// Token: 0x040041FC RID: 16892
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZUJ1ZmZFbmhhbmNlSW5mby5wcm90bxoSSXRlbUNvc3REYXRhLnBy",
			"b3RvIl4KFFJvZ3VlQnVmZkVuaGFuY2VJbmZvEg8KB2J1ZmZfaWQYBSABKA0S",
			"IAoJY29zdF9kYXRhGAQgASgLMg0uSXRlbUNvc3REYXRhEhMKC01BQUhGS01L",
			"TU1JGAMgASgCQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBuffEnhanceInfo), RogueBuffEnhanceInfo.Parser, new string[]
			{
				"BuffId",
				"CostData",
				"MAAHFKMKMMI"
			}, null, null, null, null)
		}));
	}
}
