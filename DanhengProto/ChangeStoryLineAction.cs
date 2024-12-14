using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001CF RID: 463
	public enum ChangeStoryLineAction
	{
		// Token: 0x040008B5 RID: 2229
		[OriginalName("ChangeStoryLineAction_None")]
		None,
		// Token: 0x040008B6 RID: 2230
		[OriginalName("ChangeStoryLineAction_FinishAction")]
		FinishAction,
		// Token: 0x040008B7 RID: 2231
		[OriginalName("ChangeStoryLineAction_Client")]
		Client,
		// Token: 0x040008B8 RID: 2232
		[OriginalName("ChangeStoryLineAction_CustomOP")]
		CustomOp
	}
}
