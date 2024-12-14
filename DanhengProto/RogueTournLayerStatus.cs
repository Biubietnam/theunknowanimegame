using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE1 RID: 4065
	public enum RogueTournLayerStatus
	{
		// Token: 0x04004972 RID: 18802
		[OriginalName("ROGUE_TOURN_LAYER_STATUS_NONE")]
		None,
		// Token: 0x04004973 RID: 18803
		[OriginalName("ROGUE_TOURN_LAYER_STATUS_PROCESSING")]
		Processing,
		// Token: 0x04004974 RID: 18804
		[OriginalName("ROGUE_TOURN_LAYER_STATUS_FINISH")]
		Finish
	}
}
