using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002F7 RID: 759
	public enum ClockParkPlayStatus
	{
		// Token: 0x04000E0F RID: 3599
		[OriginalName("CLOCK_PARK_PLAY_NONE")]
		ClockParkPlayNone,
		// Token: 0x04000E10 RID: 3600
		[OriginalName("CLOCK_PARK_PLAY_NORMAL_DEATH")]
		ClockParkPlayNormalDeath,
		// Token: 0x04000E11 RID: 3601
		[OriginalName("CLOCK_PARK_PLAY_NORMAL_PASS")]
		ClockParkPlayNormalPass,
		// Token: 0x04000E12 RID: 3602
		[OriginalName("CLOCK_PARK_PLAY_FINISH_SCRIPT")]
		ClockParkPlayFinishScript = 5
	}
}
