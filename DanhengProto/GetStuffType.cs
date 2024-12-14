using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000817 RID: 2071
	public enum GetStuffType
	{
		// Token: 0x040023AE RID: 9134
		[OriginalName("UNKNOW")]
		Unknow,
		// Token: 0x040023AF RID: 9135
		[OriginalName("MISSION_REWARD")]
		MissionReward,
		// Token: 0x040023B0 RID: 9136
		[OriginalName("EVENT_BUY_STUFF")]
		EventBuyStuff,
		// Token: 0x040023B1 RID: 9137
		[OriginalName("MARKET_BUY_STUFF")]
		MarketBuyStuff,
		// Token: 0x040023B2 RID: 9138
		[OriginalName("QUEST_REWARD")]
		QuestReward,
		// Token: 0x040023B3 RID: 9139
		[OriginalName("INITIAL")]
		Initial,
		// Token: 0x040023B4 RID: 9140
		[OriginalName("PHASE_FINISH_REWARD")]
		PhaseFinishReward
	}
}
