using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED0 RID: 3792
	public static class RogueMagicGameDifficultyInfoReflection
	{
		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0600A984 RID: 43396 RVA: 0x001C890B File Offset: 0x001C6B0B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameDifficultyInfoReflection.descriptor;
			}
		}

		// Token: 0x04004530 RID: 17712
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZU1hZ2ljR2FtZURpZmZpY3VsdHlJbmZvLnByb3RvIjoKHFJvZ3Vl" + "TWFnaWNHYW1lRGlmZmljdWx0eUluZm8SGgoSZGlmZmljdWx0eV9pZF9saXN0" + "GA4gAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameDifficultyInfo), RogueMagicGameDifficultyInfo.Parser, new string[]
			{
				"DifficultyIdList"
			}, null, null, null, null)
		}));
	}
}
