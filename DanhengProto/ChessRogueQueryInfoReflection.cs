using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200027A RID: 634
	public static class ChessRogueQueryInfoReflection
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00050DBC File Offset: 0x0004EFBC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryInfoReflection.descriptor;
			}
		}

		// Token: 0x04000BCE RID: 3022
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlDaGVzc1JvZ3VlUXVlcnlJbmZvLnByb3RvGh1DaGVzc1JvZ3VlUXVlcnlE",
			"aWNlSW5mby5wcm90bxoaQ2hlc3NSb2d1ZVRhbGVudEluZm8ucHJvdG8aIkNo",
			"ZXNzUm9ndWVRdWVyeURpZmZjdWx0eUluZm8ucHJvdG8aHUNoZXNzUm9ndWVR",
			"dWVyeUFlb25JbmZvLnByb3RvGhFPSUNFSUNKS09DTS5wcm90byLOAgoTQ2hl",
			"c3NSb2d1ZVF1ZXJ5SW5mbxI8ChVyb2d1ZV9kaWZmaWN1bHR5X2luZm8YBiAB",
			"KAsyHS5DaGVzc1JvZ3VlUXVlcnlEaWZmY3VsdHlJbmZvEi0KF3JvZ3VlX3Zp",
			"cnR1YWxfaXRlbV9pbmZvGAMgASgLMgwuT0lDRUlDSktPQ00SLwoQdGFsZW50",
			"X2luZm9fbGlzdBgJIAEoCzIVLkNoZXNzUm9ndWVUYWxlbnRJbmZvEh0KFWV4",
			"cGxvcmVkX2FyZWFfaWRfbGlzdBgHIAMoDRIxCg9jaGVzc19hZW9uX2luZm8Y",
			"DyABKAsyGC5DaGVzc1JvZ3VlUXVlcnlBZW9uSW5mbxIxCg9xdWVyeV9kaWNl",
			"X2luZm8YASABKAsyGC5DaGVzc1JvZ3VlUXVlcnlEaWNlSW5mbxIUCgxhcmVh",
			"X2lkX2xpc3QYCCADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChessRogueQueryDiceInfoReflection.Descriptor,
			ChessRogueTalentInfoReflection.Descriptor,
			ChessRogueQueryDiffcultyInfoReflection.Descriptor,
			ChessRogueQueryAeonInfoReflection.Descriptor,
			OICEICJKOCMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQueryInfo), ChessRogueQueryInfo.Parser, new string[]
			{
				"RogueDifficultyInfo",
				"RogueVirtualItemInfo",
				"TalentInfoList",
				"ExploredAreaIdList",
				"ChessAeonInfo",
				"QueryDiceInfo",
				"AreaIdList"
			}, null, null, null, null)
		}));
	}
}
