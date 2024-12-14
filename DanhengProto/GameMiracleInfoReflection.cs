using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D6 RID: 1494
	public static class GameMiracleInfoReflection
	{
		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x000B5F4C File Offset: 0x000B414C
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameMiracleInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A89 RID: 6793
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHYW1lTWlyYWNsZUluZm8ucHJvdG8aFlJvZ3VlTWlyYWNsZUluZm8ucHJv" + "dG8iPwoPR2FtZU1pcmFjbGVJbmZvEiwKEWdhbWVfbWlyYWNsZV9pbmZvGAQg" + "ASgLMhEuUm9ndWVNaXJhY2xlSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2Vy" + "dmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueMiracleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GameMiracleInfo), GameMiracleInfo.Parser, new string[]
			{
				"GameMiracleInfo_"
			}, null, null, null, null)
		}));
	}
}
