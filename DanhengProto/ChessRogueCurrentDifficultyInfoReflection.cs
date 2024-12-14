using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001FE RID: 510
	public static class ChessRogueCurrentDifficultyInfoReflection
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x000413F8 File Offset: 0x0003F5F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueCurrentDifficultyInfoReflection.descriptor;
			}
		}

		// Token: 0x0400099A RID: 2458
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDaGVzc1JvZ3VlQ3VycmVudERpZmZpY3VsdHlJbmZvLnByb3RvIj0KH0No" + "ZXNzUm9ndWVDdXJyZW50RGlmZmljdWx0eUluZm8SGgoSZGlmZmljdWx0eV9p" + "ZF9saXN0GA8gAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCurrentDifficultyInfo), ChessRogueCurrentDifficultyInfo.Parser, new string[]
			{
				"DifficultyIdList"
			}, null, null, null, null)
		}));
	}
}
