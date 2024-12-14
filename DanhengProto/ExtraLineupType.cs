using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F5 RID: 1269
	public enum ExtraLineupType
	{
		// Token: 0x04001676 RID: 5750
		[OriginalName("LINEUP_NONE")]
		LineupNone,
		// Token: 0x04001677 RID: 5751
		[OriginalName("LINEUP_CHALLENGE")]
		LineupChallenge,
		// Token: 0x04001678 RID: 5752
		[OriginalName("LINEUP_ROGUE")]
		LineupRogue,
		// Token: 0x04001679 RID: 5753
		[OriginalName("LINEUP_CHALLENGE_2")]
		LineupChallenge2,
		// Token: 0x0400167A RID: 5754
		[OriginalName("LINEUP_CHALLENGE_3")]
		LineupChallenge3,
		// Token: 0x0400167B RID: 5755
		[OriginalName("LINEUP_ROGUE_CHALLENGE")]
		LineupRogueChallenge,
		// Token: 0x0400167C RID: 5756
		[OriginalName("LINEUP_STAGE_TRIAL")]
		LineupStageTrial,
		// Token: 0x0400167D RID: 5757
		[OriginalName("LINEUP_ROGUE_TRIAL")]
		LineupRogueTrial,
		// Token: 0x0400167E RID: 5758
		[OriginalName("LINEUP_ACTIVITY")]
		LineupActivity,
		// Token: 0x0400167F RID: 5759
		[OriginalName("LINEUP_BOXING_CLUB")]
		LineupBoxingClub,
		// Token: 0x04001680 RID: 5760
		[OriginalName("LINEUP_TREASURE_DUNGEON")]
		LineupTreasureDungeon = 11,
		// Token: 0x04001681 RID: 5761
		[OriginalName("LINEUP_CHESS_ROGUE")]
		LineupChessRogue,
		// Token: 0x04001682 RID: 5762
		[OriginalName("LINEUP_HELIOBUS")]
		LineupHeliobus,
		// Token: 0x04001683 RID: 5763
		[OriginalName("LINEUP_TOURN_ROGUE")]
		LineupTournRogue,
		// Token: 0x04001684 RID: 5764
		[OriginalName("LINEUP_RELIC_ROGUE")]
		LineupRelicRogue,
		// Token: 0x04001685 RID: 5765
		[OriginalName("LINEUP_ARCADE_ROGUE")]
		LineupArcadeRogue,
		// Token: 0x04001686 RID: 5766
		[OriginalName("LINEUP_MAGIC_ROGUE")]
		LineupMagicRogue
	}
}
