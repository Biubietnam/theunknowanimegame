using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D29 RID: 3369
	public enum PunkLordMonsterInfoNotifyReason
	{
		// Token: 0x04003A6A RID: 14954
		[OriginalName("PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_NONE")]
		None,
		// Token: 0x04003A6B RID: 14955
		[OriginalName("PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_ENTER_RAID")]
		EnterRaid,
		// Token: 0x04003A6C RID: 14956
		[OriginalName("PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_BATTLE_END")]
		BattleEnd,
		// Token: 0x04003A6D RID: 14957
		[OriginalName("PUNK_LORD_MONSTER_INFO_NOTIFY_REASON_LEAVE_RAID")]
		LeaveRaid
	}
}
