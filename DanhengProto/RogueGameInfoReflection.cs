using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E90 RID: 3728
	public static class RogueGameInfoReflection
	{
		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x0600A68E RID: 42638 RVA: 0x001C0782 File Offset: 0x001BE982
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04004422 RID: 17442
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNSb2d1ZUdhbWVJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQnVmZkluZm8ucHJv",
			"dG8aGlJvZ3VlVG91cm5MaW5ldXBJbmZvLnByb3RvGhxDaGVzc1JvZ3VlR2Ft",
			"ZUFlb25JbmZvLnByb3RvGh5Sb2d1ZURpZmZpY3VsdHlMZXZlbEluZm8ucHJv",
			"dG8aGFJvZ3VlR2FtZUl0ZW1WYWx1ZS5wcm90bxobQ2hlc3NSb2d1ZU1pcmFj",
			"bGVJbmZvLnByb3RvGhtSb2d1ZVRvdXJuRm9ybXVsYUluZm8ucHJvdG8aGEtl",
			"eXdvcmRVbmxvY2tWYWx1ZS5wcm90byKTAwoNUm9ndWVHYW1lSW5mbxIsCg9y",
			"b2d1ZV9idWZmX2luZm8YCSABKAsyEy5DaGVzc1JvZ3VlQnVmZkluZm8SMQoR",
			"Z2FtZV9taXJhY2xlX2luZm8YDSABKAsyFi5DaGVzc1JvZ3VlTWlyYWNsZUlu",
			"Zm8SLAoPZ2FtZV9pdGVtX3ZhbHVlGAEgASgLMhMuUm9ndWVHYW1lSXRlbVZh",
			"bHVlEjAKD3JvZ3VlX2Flb25faW5mbxgEIAEoCzIXLkNoZXNzUm9ndWVHYW1l",
			"QWVvbkluZm8SOAoVcm9ndWVfZGlmZmljdWx0eV9pbmZvGA4gASgLMhkuUm9n",
			"dWVEaWZmaWN1bHR5TGV2ZWxJbmZvEisKC0NITUVMQURFTU1NGA8gASgLMhYu",
			"Um9ndWVUb3VybkZvcm11bGFJbmZvEigKC01PR0xMTUxFTUlQGAcgASgLMhMu",
			"S2V5d29yZFVubG9ja1ZhbHVlEjAKEXJvZ3VlX2xpbmV1cF9pbmZvGAggASgL",
			"MhUuUm9ndWVUb3VybkxpbmV1cEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueBuffInfoReflection.Descriptor,
			RogueTournLineupInfoReflection.Descriptor,
			ChessRogueGameAeonInfoReflection.Descriptor,
			RogueDifficultyLevelInfoReflection.Descriptor,
			RogueGameItemValueReflection.Descriptor,
			ChessRogueMiracleInfoReflection.Descriptor,
			RogueTournFormulaInfoReflection.Descriptor,
			KeywordUnlockValueReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueGameInfo), RogueGameInfo.Parser, new string[]
			{
				"RogueBuffInfo",
				"GameMiracleInfo",
				"GameItemValue",
				"RogueAeonInfo",
				"RogueDifficultyInfo",
				"CHMELADEMMM",
				"MOGLLMLEMIP",
				"RogueLineupInfo"
			}, null, null, null, null)
		}));
	}
}
