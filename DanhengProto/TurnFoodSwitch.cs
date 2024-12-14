using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013AF RID: 5039
	public enum TurnFoodSwitch
	{
		// Token: 0x04005981 RID: 22913
		[OriginalName("TURN_FOOD_SWITCH_NONE")]
		None,
		// Token: 0x04005982 RID: 22914
		[OriginalName("TURN_FOOD_SWITCH_ATTACK")]
		Attack,
		// Token: 0x04005983 RID: 22915
		[OriginalName("TURN_FOOD_SWITCH_DEFINE")]
		Define
	}
}
