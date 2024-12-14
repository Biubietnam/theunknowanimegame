using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200021E RID: 542
	public static class ChessRogueGameInfoReflection
	{
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00046602 File Offset: 0x00044802
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04000A5B RID: 2651
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDaGVzc1JvZ3VlR2FtZUluZm8ucHJvdG8aGUNoZXNzUm9ndWVMZXZlbElu",
			"Zm8ucHJvdG8aGENoZXNzUm9ndWVCdWZmSW5mby5wcm90bxodQ2hlc3NSb2d1",
			"ZU5vdXNWYWx1ZUluZm8ucHJvdG8aGENoZXNzUm9ndWVBZW9uSW5mby5wcm90",
			"bxoZQ2hlc3NSb2d1ZVN0b3J5SW5mby5wcm90bxoeUm9ndWVDb21tb25QZW5k",
			"aW5nQWN0aW9uLnByb3RvGhpDaGVzc1JvZ3VlTGluZXVwSW5mby5wcm90bxob",
			"Q2hlc3NSb2d1ZU1pcmFjbGVJbmZvLnByb3RvGiVDaGVzc1JvZ3VlQ3VycmVu",
			"dERpZmZpY3VsdHlJbmZvLnByb3RvGhZSb2d1ZVZpcnR1YWxJdGVtLnByb3Rv",
			"GhhDaGVzc1JvZ3VlRGljZUluZm8ucHJvdG8aEU9JQ0VJQ0pLT0NNLnByb3Rv",
			"GhFKSUlPSE5ESUhBTS5wcm90bxoTUm9ndWVHYW1lSW5mby5wcm90byLNBQoS",
			"Q2hlc3NSb2d1ZUdhbWVJbmZvEjEKD25vdXNfdmFsdWVfaW5mbxgJIAEoCzIY",
			"LkNoZXNzUm9ndWVOb3VzVmFsdWVJbmZvEjAKEXJvZ3VlX2xpbmV1cF9pbmZv",
			"GAcgASgLMhUuQ2hlc3NSb2d1ZUxpbmV1cEluZm8SMQoOcGVuZGluZ19hY3Rp",
			"b24YAyABKAsyGS5Sb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb24SMQoRZ2FtZV9t",
			"aXJhY2xlX2luZm8YDCABKAsyFi5DaGVzc1JvZ3VlTWlyYWNsZUluZm8SLAoP",
			"cm9ndWVfYnVmZl9pbmZvGAsgASgLMhMuQ2hlc3NSb2d1ZUJ1ZmZJbmZvEiAK",
			"CnN0b3J5X2luZm8YBSABKAsyDC5KSUlPSE5ESUhBTRJAChVyb2d1ZV9kaWZm",
			"aWN1bHR5X2luZm8YmgQgASgLMiAuQ2hlc3NSb2d1ZUN1cnJlbnREaWZmaWN1",
			"bHR5SW5mbxItChdyb2d1ZV92aXJ0dWFsX2l0ZW1faW5mbxgGIAEoCzIMLk9J",
			"Q0VJQ0pLT0NNEhYKDnJvZ3VlX3N1Yl9tb2RlGAggASgNEigKCmxldmVsX2lu",
			"Zm8YBCABKAsyFC5DaGVzc1JvZ3VlTGV2ZWxJbmZvEiwKD3JvZ3VlX2Flb25f",
			"aW5mbxgBIAEoCzITLkNoZXNzUm9ndWVBZW9uSW5mbxIuChByb2d1ZV9zdG9y",
			"eV9pbmZvGAogASgLMhQuQ2hlc3NSb2d1ZVN0b3J5SW5mbxIsChF2aXJ0dWFs",
			"X2l0ZW1faW5mbxgOIAEoCzIRLlJvZ3VlVmlydHVhbEl0ZW0SLAoPcm9ndWVf",
			"ZGljZV9pbmZvGAIgASgLMhMuQ2hlc3NSb2d1ZURpY2VJbmZvEi8KF3JvZ3Vl",
			"X2N1cnJlbnRfZ2FtZV9pbmZvGA0gAygLMg4uUm9ndWVHYW1lSW5mb0IeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueLevelInfoReflection.Descriptor,
			ChessRogueBuffInfoReflection.Descriptor,
			ChessRogueNousValueInfoReflection.Descriptor,
			ChessRogueAeonInfoReflection.Descriptor,
			ChessRogueStoryInfoReflection.Descriptor,
			RogueCommonPendingActionReflection.Descriptor,
			ChessRogueLineupInfoReflection.Descriptor,
			ChessRogueMiracleInfoReflection.Descriptor,
			ChessRogueCurrentDifficultyInfoReflection.Descriptor,
			RogueVirtualItemReflection.Descriptor,
			ChessRogueDiceInfoReflection.Descriptor,
			OICEICJKOCMReflection.Descriptor,
			JIIOHNDIHAMReflection.Descriptor,
			RogueGameInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGameInfo), ChessRogueGameInfo.Parser, new string[]
			{
				"NousValueInfo",
				"RogueLineupInfo",
				"PendingAction",
				"GameMiracleInfo",
				"RogueBuffInfo",
				"StoryInfo",
				"RogueDifficultyInfo",
				"RogueVirtualItemInfo",
				"RogueSubMode",
				"LevelInfo",
				"RogueAeonInfo",
				"RogueStoryInfo",
				"VirtualItemInfo",
				"RogueDiceInfo",
				"RogueCurrentGameInfo"
			}, null, null, null, null)
		}));
	}
}
