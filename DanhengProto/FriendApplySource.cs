using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C3 RID: 1475
	public enum FriendApplySource
	{
		// Token: 0x04001A23 RID: 6691
		[OriginalName("FRIEND_APPLY_SOURCE_NONE")]
		None,
		// Token: 0x04001A24 RID: 6692
		[OriginalName("FRIEND_APPLY_SOURCE_SEARCH")]
		Search,
		// Token: 0x04001A25 RID: 6693
		[OriginalName("FRIEND_APPLY_SOURCE_RECOMMEND")]
		Recommend,
		// Token: 0x04001A26 RID: 6694
		[OriginalName("FRIEND_APPLY_SOURCE_ASSIST")]
		Assist,
		// Token: 0x04001A27 RID: 6695
		[OriginalName("FRIEND_APPLY_SOURCE_RECOMMEND_ASSIST")]
		RecommendAssist,
		// Token: 0x04001A28 RID: 6696
		[OriginalName("FRIEND_APPLY_SOURCE_PSN_FRIEND")]
		PsnFriend,
		// Token: 0x04001A29 RID: 6697
		[OriginalName("FRIEND_APPLY_SOURCE_ASSIST_REWARD")]
		AssistReward
	}
}
