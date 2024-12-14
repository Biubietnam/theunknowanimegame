using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E88 RID: 3720
	public static class RogueGambleInfoReflection
	{
		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600A624 RID: 42532 RVA: 0x001BF35B File Offset: 0x001BD55B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGambleInfoReflection.descriptor;
			}
		}

		// Token: 0x040043F4 RID: 17396
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZUdhbWJsZUluZm8ucHJvdG8aHlJvZ3VlR2FtYmxlTWF6ZUdyb3Vw",
			"SW5mby5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvItIBCg9Sb2d1ZUdhbWJs",
			"ZUluZm8SEQoJY3VyX3RpbWVzGAIgASgNEhYKDm1heF9nYW1lX3RpbWVzGAEg",
			"ASgNEhMKC0lIRUlPSktKSUVIGAggASgNEhMKC01PTUtGRUpNSk1JGAQgASgN",
			"EiQKDWN1cl9jb3N0X2l0ZW0YDCABKAsyDS5JdGVtQ29zdERhdGESEAoIY2Fu",
			"X3BsYXkYCSABKAgSMgoPbWF6ZV9ncm91cF9saXN0GA4gAygLMhkuUm9ndWVH",
			"YW1ibGVNYXplR3JvdXBJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueGambleMazeGroupInfoReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGambleInfo), RogueGambleInfo.Parser, new string[]
			{
				"CurTimes",
				"MaxGameTimes",
				"IHEIOJKJIEH",
				"MOMKFEJMJMI",
				"CurCostItem",
				"CanPlay",
				"MazeGroupList"
			}, null, null, null, null)
		}));
	}
}
