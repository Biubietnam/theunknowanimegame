using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D4 RID: 1492
	public static class GameAeonInfoReflection
	{
		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x000B5B69 File Offset: 0x000B3D69
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameAeonInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A80 RID: 6784
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJHYW1lQWVvbkluZm8ucHJvdG8iXAoMR2FtZUFlb25JbmZvEiEKGXVubG9j" + "a2VkX2Flb25fZW5oYW5jZV9udW0YCiABKA0SEwoLaXNfdW5sb2NrZWQYDSAB" + "KAgSFAoMZ2FtZV9hZW9uX2lkGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GameAeonInfo), GameAeonInfo.Parser, new string[]
			{
				"UnlockedAeonEnhanceNum",
				"IsUnlocked",
				"GameAeonId"
			}, null, null, null, null)
		}));
	}
}
