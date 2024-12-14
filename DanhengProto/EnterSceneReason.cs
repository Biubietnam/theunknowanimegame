using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000463 RID: 1123
	public enum EnterSceneReason
	{
		// Token: 0x040013F0 RID: 5104
		[OriginalName("ENTER_SCENE_REASON_NONE")]
		None,
		// Token: 0x040013F1 RID: 5105
		[OriginalName("ENTER_SCENE_REASON_CHALLENGE_TIMEOUT")]
		ChallengeTimeout,
		// Token: 0x040013F2 RID: 5106
		[OriginalName("ENTER_SCENE_REASON_ROGUE_TIMEOUT")]
		RogueTimeout,
		// Token: 0x040013F3 RID: 5107
		[OriginalName("ENTER_SCENE_REASON_CHANGE_STORYLINE")]
		ChangeStoryline,
		// Token: 0x040013F4 RID: 5108
		[OriginalName("ENTER_SCENE_REASON_DIMENSION_MERGE")]
		DimensionMerge
	}
}
