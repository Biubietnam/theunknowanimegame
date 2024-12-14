using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200053D RID: 1341
	public enum FightKickoutType
	{
		// Token: 0x0400180E RID: 6158
		[OriginalName("FIGHT_KICKOUT_UNKNOWN")]
		FightKickoutUnknown,
		// Token: 0x0400180F RID: 6159
		[OriginalName("FIGHT_KICKOUT_BLACK")]
		FightKickoutBlack,
		// Token: 0x04001810 RID: 6160
		[OriginalName("FIGHT_KICKOUT_BY_GM")]
		FightKickoutByGm,
		// Token: 0x04001811 RID: 6161
		[OriginalName("FIGHT_KICKOUT_TIMEOUT")]
		FightKickoutTimeout,
		// Token: 0x04001812 RID: 6162
		[OriginalName("FIGHT_KICKOUT_SESSION_RESET")]
		FightKickoutSessionReset
	}
}
