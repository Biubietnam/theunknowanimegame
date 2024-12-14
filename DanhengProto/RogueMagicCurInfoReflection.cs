using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB6 RID: 3766
	public static class RogueMagicCurInfoReflection
	{
		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600A849 RID: 43081 RVA: 0x001C529B File Offset: 0x001C349B
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicCurInfoReflection.descriptor;
			}
		}

		// Token: 0x040044C5 RID: 17605
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdSb2d1ZU1hZ2ljQ3VySW5mby5wcm90bxoRTEtKTURPQUhHSU4ucHJvdG8a",
			"GlJvZ3VlVG91cm5MaW5ldXBJbmZvLnByb3RvGh1Sb2d1ZU1hZ2ljR2FtZUxl",
			"dmVsSW5mby5wcm90bxoiUm9ndWVNYWdpY0dhbWVEaWZmaWN1bHR5SW5mby5w",
			"cm90bxobUm9ndWVUb3VybkN1ckFyZWFJbmZvLnByb3RvGhhSb2d1ZUdhbWVJ",
			"dGVtVmFsdWUucHJvdG8aG0NoZXNzUm9ndWVNaXJhY2xlSW5mby5wcm90bxoc",
			"Um9ndWVNYWdpY0dhbWVJdGVtSW5mby5wcm90byLzAgoRUm9ndWVNYWdpY0N1",
			"ckluZm8SJQoGbGluZXVwGAEgASgLMhUuUm9ndWVUb3VybkxpbmV1cEluZm8S",
			"JwoKaXRlbV92YWx1ZRgFIAEoCzITLlJvZ3VlR2FtZUl0ZW1WYWx1ZRIsCgxt",
			"aXJhY2xlX2luZm8YDCABKAsyFi5DaGVzc1JvZ3VlTWlyYWNsZUluZm8SJwoF",
			"bGV2ZWwYCSABKAsyGC5Sb2d1ZU1hZ2ljR2FtZUxldmVsSW5mbxI7ChRnYW1l",
			"X2RpZmZpY3VsdHlfaW5mbxgHIAEoCzIdLlJvZ3VlTWFnaWNHYW1lRGlmZmlj",
			"dWx0eUluZm8SIQoLSkRNR0pEQk1IRUoYDSABKAsyDC5MS0pNRE9BSEdJThIr",
			"CgptYWdpY19pdGVtGAogASgLMhcuUm9ndWVNYWdpY0dhbWVJdGVtSW5mbxIq",
			"CgpiYXNpY19pbmZvGA4gASgLMhYuUm9ndWVUb3VybkN1ckFyZWFJbmZvQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			LKJMDOAHGINReflection.Descriptor,
			RogueTournLineupInfoReflection.Descriptor,
			RogueMagicGameLevelInfoReflection.Descriptor,
			RogueMagicGameDifficultyInfoReflection.Descriptor,
			RogueTournCurAreaInfoReflection.Descriptor,
			RogueGameItemValueReflection.Descriptor,
			ChessRogueMiracleInfoReflection.Descriptor,
			RogueMagicGameItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicCurInfo), RogueMagicCurInfo.Parser, new string[]
			{
				"Lineup",
				"ItemValue",
				"MiracleInfo",
				"Level",
				"GameDifficultyInfo",
				"JDMGJDBMHEJ",
				"MagicItem",
				"BasicInfo"
			}, null, null, null, null)
		}));
	}
}
