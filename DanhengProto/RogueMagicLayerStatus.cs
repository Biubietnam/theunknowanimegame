using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE9 RID: 3817
	public enum RogueMagicLayerStatus
	{
		// Token: 0x040045A8 RID: 17832
		[OriginalName("ROGUE_MAGIC_LAYER_STATUS_NONE")]
		None,
		// Token: 0x040045A9 RID: 17833
		[OriginalName("ROGUE_MAGIC_LAYER_STATUS_PROCESSING")]
		Processing,
		// Token: 0x040045AA RID: 17834
		[OriginalName("ROGUE_MAGIC_LAYER_STATUS_FINISH")]
		Finish
	}
}
