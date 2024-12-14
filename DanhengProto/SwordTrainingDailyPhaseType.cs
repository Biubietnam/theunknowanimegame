using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001223 RID: 4643
	public enum SwordTrainingDailyPhaseType
	{
		// Token: 0x0400537D RID: 21373
		[OriginalName("SWORD_TRAINING_DAILY_PHASE_TYPE_NONE")]
		None,
		// Token: 0x0400537E RID: 21374
		[OriginalName("SWORD_TRAINING_DAILY_PHASE_TYPE_MORNING")]
		Morning,
		// Token: 0x0400537F RID: 21375
		[OriginalName("SWORD_TRAINING_DAILY_PHASE_TYPE_NOON")]
		Noon,
		// Token: 0x04005380 RID: 21376
		[OriginalName("SWORD_TRAINING_DAILY_PHASE_TYPE_AFTERNOON")]
		Afternoon,
		// Token: 0x04005381 RID: 21377
		[OriginalName("SWORD_TRAINING_DAILY_PHASE_TYPE_EVENING")]
		Evening
	}
}
