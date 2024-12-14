using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000200 RID: 512
	public static class ChessRogueCurrentInfoReflection
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x0004166C File Offset: 0x0003F86C
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueCurrentInfoReflection.descriptor;
			}
		}

		// Token: 0x040009A0 RID: 2464
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtDaGVzc1JvZ3VlQ3VycmVudEluZm8ucHJvdG8aE1JvZ3VlR2FtZUluZm8u",
			"cHJvdG8iYAoVQ2hlc3NSb2d1ZUN1cnJlbnRJbmZvEhYKDnJvZ3VlX3N1Yl9t",
			"b2RlGA4gASgNEi8KF3JvZ3VlX2N1cnJlbnRfZ2FtZV9pbmZvGAwgAygLMg4u",
			"Um9ndWVHYW1lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueCurrentInfo), ChessRogueCurrentInfo.Parser, new string[]
			{
				"RogueSubMode",
				"RogueCurrentGameInfo"
			}, null, null, null, null)
		}));
	}
}
