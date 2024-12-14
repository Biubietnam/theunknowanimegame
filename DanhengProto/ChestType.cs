using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002BF RID: 703
	public enum ChestType
	{
		// Token: 0x04000CF9 RID: 3321
		[OriginalName("MAP_INFO_CHEST_TYPE_NONE")]
		MapInfoChestTypeNone,
		// Token: 0x04000CFA RID: 3322
		[OriginalName("MAP_INFO_CHEST_TYPE_NORMAL")]
		MapInfoChestTypeNormal = 101,
		// Token: 0x04000CFB RID: 3323
		[OriginalName("MAP_INFO_CHEST_TYPE_CHALLENGE")]
		MapInfoChestTypeChallenge,
		// Token: 0x04000CFC RID: 3324
		[OriginalName("MAP_INFO_CHEST_TYPE_PUZZLE")]
		MapInfoChestTypePuzzle = 104
	}
}
