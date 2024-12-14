using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B8D RID: 2957
	public enum MonsterBattleType
	{
		// Token: 0x0400321E RID: 12830
		[OriginalName("MONSTER_BATTLE_TYPE_NONE")]
		None,
		// Token: 0x0400321F RID: 12831
		[OriginalName("MONSTER_BATTLE_TYPE_TRIGGER_BATTLE")]
		TriggerBattle,
		// Token: 0x04003220 RID: 12832
		[OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SIMULATE_BATTLE")]
		DirectDieSimulateBattle,
		// Token: 0x04003221 RID: 12833
		[OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SKIP_BATTLE")]
		DirectDieSkipBattle,
		// Token: 0x04003222 RID: 12834
		[OriginalName("MONSTER_BATTLE_TYPE_NO_BATTLE")]
		NoBattle
	}
}
