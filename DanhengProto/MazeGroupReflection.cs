using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAE RID: 2734
	public static class MazeGroupReflection
	{
		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600793B RID: 31035 RVA: 0x00141418 File Offset: 0x0013F618
		public static FileDescriptor Descriptor
		{
			get
			{
				return MazeGroupReflection.descriptor;
			}
		}

		// Token: 0x04002E87 RID: 11911
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9NYXplR3JvdXAucHJvdG8iXAoJTWF6ZUdyb3VwEhAKCGdyb3VwX2lkGAUg" + "ASgNEhMKC0RQSUtEQlBLQU9LGAIgASgIEhMKC0xGRkhES0hCSE5OGA8gAygN" + "EhMKC21vZGlmeV90aW1lGA0gASgDQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MazeGroup), MazeGroup.Parser, new string[]
			{
				"GroupId",
				"DPIKDBPKAOK",
				"LFFHDKHBHNN",
				"ModifyTime"
			}, null, null, null, null)
		}));
	}
}
