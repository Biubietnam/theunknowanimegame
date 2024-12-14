using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000220 RID: 544
	public static class ChessRogueGetInfoReflection
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000476E1 File Offset: 0x000458E1
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueGetInfoReflection.descriptor;
			}
		}

		// Token: 0x04000A7D RID: 2685
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdDaGVzc1JvZ3VlR2V0SW5mby5wcm90bxodQ2hlc3NSb2d1ZVF1ZXJ5QWVv",
			"bkluZm8ucHJvdG8aHUNoZXNzUm9ndWVRdWVyeURpY2VJbmZvLnByb3RvGiJD",
			"aGVzc1JvZ3VlUXVlcnlEaWZmY3VsdHlJbmZvLnByb3RvGhpDaGVzc1JvZ3Vl",
			"VGFsZW50SW5mby5wcm90byKdAgoRQ2hlc3NSb2d1ZUdldEluZm8SMQoPY2hl",
			"c3NfYWVvbl9pbmZvGAogASgLMhguQ2hlc3NSb2d1ZVF1ZXJ5QWVvbkluZm8S",
			"FAoMYXJlYV9pZF9saXN0GAwgAygNEjEKD3F1ZXJ5X2RpY2VfaW5mbxgCIAEo",
			"CzIYLkNoZXNzUm9ndWVRdWVyeURpY2VJbmZvEi8KEHRhbGVudF9pbmZvX2xp",
			"c3QYASABKAsyFS5DaGVzc1JvZ3VlVGFsZW50SW5mbxI8ChVyb2d1ZV9kaWZm",
			"aWN1bHR5X2luZm8YDSABKAsyHS5DaGVzc1JvZ3VlUXVlcnlEaWZmY3VsdHlJ",
			"bmZvEh0KFWV4cGxvcmVkX2FyZWFfaWRfbGlzdBgDIAMoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueQueryAeonInfoReflection.Descriptor,
			ChessRogueQueryDiceInfoReflection.Descriptor,
			ChessRogueQueryDiffcultyInfoReflection.Descriptor,
			ChessRogueTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueGetInfo), ChessRogueGetInfo.Parser, new string[]
			{
				"ChessAeonInfo",
				"AreaIdList",
				"QueryDiceInfo",
				"TalentInfoList",
				"RogueDifficultyInfo",
				"ExploredAreaIdList"
			}, null, null, null, null)
		}));
	}
}
