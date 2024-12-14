using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FBE RID: 4030
	public static class RogueTournGameDifficultyInfoReflection
	{
		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x001E260D File Offset: 0x001E080D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournGameDifficultyInfoReflection.descriptor;
			}
		}

		// Token: 0x040048E5 RID: 18661
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuR2FtZURpZmZpY3VsdHlJbmZvLnByb3RvIjoKHFJvZ3Vl" + "VG91cm5HYW1lRGlmZmljdWx0eUluZm8SGgoSZGlmZmljdWx0eV9pZF9saXN0" + "GAYgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGameDifficultyInfo), RogueTournGameDifficultyInfo.Parser, new string[]
			{
				"DifficultyIdList"
			}, null, null, null, null)
		}));
	}
}
