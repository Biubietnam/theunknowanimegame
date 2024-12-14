using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F72 RID: 3954
	public static class RogueSeasonInfoReflection
	{
		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x001D98D0 File Offset: 0x001D7AD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueSeasonInfoReflection.descriptor;
			}
		}

		// Token: 0x040047B3 RID: 18355
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVSb2d1ZVNlYXNvbkluZm8ucHJvdG8iRwoPUm9ndWVTZWFzb25JbmZvEhIK" + "CmJlZ2luX3RpbWUYAiABKAMSEAoIZW5kX3RpbWUYDCABKAMSDgoGc2Vhc29u" + "GAQgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueSeasonInfo), RogueSeasonInfo.Parser, new string[]
			{
				"BeginTime",
				"EndTime",
				"Season"
			}, null, null, null, null)
		}));
	}
}
