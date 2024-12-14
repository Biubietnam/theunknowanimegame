using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4C RID: 3660
	public static class RogueCommonDialogueOptionResultInfoReflection
	{
		// Token: 0x17002E22 RID: 11810
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x001B772B File Offset: 0x001B592B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionResultInfoReflection.descriptor;
			}
		}

		// Token: 0x040042E7 RID: 17127
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uUmVzdWx0SW5mby5wcm90bxoR",
			"S0tMR0ZNTEdISUcucHJvdG8aL1JvZ3VlQ29tbW9uRGlhbG9ndWVPcHRpb25C",
			"YXR0bGVSZXN1bHRJbmZvLnByb3RvIpABCiNSb2d1ZUNvbW1vbkRpYWxvZ3Vl",
			"T3B0aW9uUmVzdWx0SW5mbxJGChJiYXR0bGVfcmVzdWx0X2luZm8YDyABKAsy",
			"Ki5Sb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uQmF0dGxlUmVzdWx0SW5mbxIh",
			"CgtITk9LSEhPQUVEUBgJIAEoCzIMLktLTEdGTUxHSElHQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			KKLGFMLGHIGReflection.Descriptor,
			RogueCommonDialogueOptionBattleResultInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDialogueOptionResultInfo), RogueCommonDialogueOptionResultInfo.Parser, new string[]
			{
				"BattleResultInfo",
				"HNOKHHOAEDP"
			}, null, null, null, null)
		}));
	}
}
