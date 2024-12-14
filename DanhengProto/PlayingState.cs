using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CEB RID: 3307
	public enum PlayingState
	{
		// Token: 0x04003935 RID: 14645
		[OriginalName("PLAYING_STATE_NONE")]
		None,
		// Token: 0x04003936 RID: 14646
		[OriginalName("PLAYING_ROGUE_COSMOS")]
		PlayingRogueCosmos,
		// Token: 0x04003937 RID: 14647
		[OriginalName("PLAYING_ROGUE_CHESS")]
		PlayingRogueChess,
		// Token: 0x04003938 RID: 14648
		[OriginalName("PLAYING_ROGUE_CHESS_NOUS")]
		PlayingRogueChessNous,
		// Token: 0x04003939 RID: 14649
		[OriginalName("PLAYING_CHALLENGE_MEMORY")]
		PlayingChallengeMemory,
		// Token: 0x0400393A RID: 14650
		[OriginalName("PLAYING_CHALLENGE_STORY")]
		PlayingChallengeStory,
		// Token: 0x0400393B RID: 14651
		[OriginalName("PLAYING_CHALLENGE_BOSS")]
		PlayingChallengeBoss,
		// Token: 0x0400393C RID: 14652
		[OriginalName("PLAYING_ROGUE_TOURN")]
		PlayingRogueTourn,
		// Token: 0x0400393D RID: 14653
		[OriginalName("PLAYING_ROGUE_MAGIC")]
		PlayingRogueMagic
	}
}
