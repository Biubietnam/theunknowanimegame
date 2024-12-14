using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D19 RID: 3353
	public enum PunkLordAttackerStatus
	{
		// Token: 0x04003A0F RID: 14863
		[OriginalName("PUNK_LORD_ATTACKER_STATUS_NONE")]
		None,
		// Token: 0x04003A10 RID: 14864
		[OriginalName("PUNK_LORD_ATTACKER_STATUS_ATTACKED")]
		Attacked,
		// Token: 0x04003A11 RID: 14865
		[OriginalName("PUNK_LORD_ATTACKER_STATUS_ATTACKING")]
		Attacking,
		// Token: 0x04003A12 RID: 14866
		[OriginalName("PUNK_LORD_ATTACKER_STATUS_ATTACKED_AND_ATTACKING")]
		AttackedAndAttacking
	}
}
