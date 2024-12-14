using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8C RID: 3980
	public static class RogueTournCurGameInfoReflection
	{
		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600B150 RID: 45392 RVA: 0x001DC661 File Offset: 0x001DA861
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournCurGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04004822 RID: 18466
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZVRvdXJuQ3VyR2FtZUluZm8ucHJvdG8aGlJvZ3VlVG91cm5MaW5l",
			"dXBJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQnVmZkluZm8ucHJvdG8aIlJvZ3Vl",
			"VG91cm5HYW1lRGlmZmljdWx0eUluZm8ucHJvdG8aGVJvZ3VlVG91cm5MZXZl",
			"bEluZm8ucHJvdG8aGlJvZ3VlVG91cm5Nb2R1bGVJbmZvLnByb3RvGhhSb2d1",
			"ZUdhbWVJdGVtVmFsdWUucHJvdG8aG1JvZ3VlVG91cm5Gb3JtdWxhSW5mby5w",
			"cm90bxobQ2hlc3NSb2d1ZU1pcmFjbGVJbmZvLnByb3RvGhhLZXl3b3JkVW5s",
			"b2NrVmFsdWUucHJvdG8aHFJvZ3VlVG91cm5HYW1lQXJlYUluZm8ucHJvdG8i",
			"6AMKFVJvZ3VlVG91cm5DdXJHYW1lSW5mbxIjCgVsZXZlbBgCIAEoCzIULlJv",
			"Z3VlVG91cm5MZXZlbEluZm8SKQoMdW5sb2NrX3ZhbHVlGAEgASgLMhMuS2V5",
			"d29yZFVubG9ja1ZhbHVlEicKCml0ZW1fdmFsdWUYCSABKAsyEy5Sb2d1ZUdh",
			"bWVJdGVtVmFsdWUSOwoacm9ndWVfdG91cm5fZ2FtZV9hcmVhX2luZm8YBiAB",
			"KAsyFy5Sb2d1ZVRvdXJuR2FtZUFyZWFJbmZvEjsKFGdhbWVfZGlmZmljdWx0",
			"eV9pbmZvGAogASgLMh0uUm9ndWVUb3VybkdhbWVEaWZmaWN1bHR5SW5mbxIy",
			"ChJ0b3Vybl9mb3JtdWxhX2luZm8YCCABKAsyFi5Sb2d1ZVRvdXJuRm9ybXVs",
			"YUluZm8SJQoGbGluZXVwGAsgASgLMhUuUm9ndWVUb3VybkxpbmV1cEluZm8S",
			"LAoMbWlyYWNsZV9pbmZvGAcgASgLMhYuQ2hlc3NSb2d1ZU1pcmFjbGVJbmZv",
			"EjAKEXRvdXJuX21vZHVsZV9pbmZvGA4gASgLMhUuUm9ndWVUb3Vybk1vZHVs",
			"ZUluZm8SIQoEYnVmZhgPIAEoCzITLkNoZXNzUm9ndWVCdWZmSW5mb0IeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournLineupInfoReflection.Descriptor,
			ChessRogueBuffInfoReflection.Descriptor,
			RogueTournGameDifficultyInfoReflection.Descriptor,
			RogueTournLevelInfoReflection.Descriptor,
			RogueTournModuleInfoReflection.Descriptor,
			RogueGameItemValueReflection.Descriptor,
			RogueTournFormulaInfoReflection.Descriptor,
			ChessRogueMiracleInfoReflection.Descriptor,
			KeywordUnlockValueReflection.Descriptor,
			RogueTournGameAreaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournCurGameInfo), RogueTournCurGameInfo.Parser, new string[]
			{
				"Level",
				"UnlockValue",
				"ItemValue",
				"RogueTournGameAreaInfo",
				"GameDifficultyInfo",
				"TournFormulaInfo",
				"Lineup",
				"MiracleInfo",
				"TournModuleInfo",
				"Buff"
			}, null, null, null, null)
		}));
	}
}
