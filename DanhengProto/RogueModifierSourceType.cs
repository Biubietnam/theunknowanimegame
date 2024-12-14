using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F55 RID: 3925
	public enum RogueModifierSourceType
	{
		// Token: 0x04004739 RID: 18233
		[OriginalName("ROGUE_MODIFIER_SOURCE_NONE")]
		RogueModifierSourceNone,
		// Token: 0x0400473A RID: 18234
		[OriginalName("ROGUE_MODIFIER_SOURCE_DICE_ROLL")]
		RogueModifierSourceDiceRoll,
		// Token: 0x0400473B RID: 18235
		[OriginalName("ROGUE_MODIFIER_SOURCE_AEON")]
		RogueModifierSourceAeon,
		// Token: 0x0400473C RID: 18236
		[OriginalName("ROGUE_MODIFIER_SOURCE_BOARD_EVENT")]
		RogueModifierSourceBoardEvent,
		// Token: 0x0400473D RID: 18237
		[OriginalName("ROGUE_MODIFIER_SOURCE_DIALOG_EVENT")]
		RogueModifierSourceDialogEvent,
		// Token: 0x0400473E RID: 18238
		[OriginalName("ROGUE_MODIFIER_SOURCE_MIRACLE")]
		RogueModifierSourceMiracle,
		// Token: 0x0400473F RID: 18239
		[OriginalName("ROGUE_MODIFIER_SOURCE_CELL_MARK")]
		RogueModifierSourceCellMark,
		// Token: 0x04004740 RID: 18240
		[OriginalName("ROGUE_MODIFIER_SOURCE_AEON_TALENT")]
		RogueModifierSourceAeonTalent,
		// Token: 0x04004741 RID: 18241
		[OriginalName("ROGUE_MODIFIER_SOURCE_BOSS_DECAY")]
		RogueModifierSourceBossDecay,
		// Token: 0x04004742 RID: 18242
		[OriginalName("ROGUE_MODIFIER_SOURCE_DICE_BRANCH")]
		RogueModifierSourceDiceBranch
	}
}
