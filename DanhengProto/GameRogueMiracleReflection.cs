using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E4 RID: 1508
	public static class GameRogueMiracleReflection
	{
		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x000B7208 File Offset: 0x000B5408
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameRogueMiracleReflection.descriptor;
			}
		}

		// Token: 0x04001AB5 RID: 6837
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZHYW1lUm9ndWVNaXJhY2xlLnByb3RvIroBChBHYW1lUm9ndWVNaXJhY2xl",
			"EjcKC09FT0lKQkhBSU5CGAggAygLMiIuR2FtZVJvZ3VlTWlyYWNsZS5PRU9J",
			"SkJIQUlOQkVudHJ5EhEKCWN1cl90aW1lcxgCIAEoDRISCgptaXJhY2xlX2lk",
			"GAogASgNEhIKCmR1cmFiaWxpdHkYASABKA0aMgoQT0VPSUpCSEFJTkJFbnRy",
			"eRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GameRogueMiracle), GameRogueMiracle.Parser, new string[]
			{
				"OEOIJBHAINB",
				"CurTimes",
				"MiracleId",
				"Durability"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
