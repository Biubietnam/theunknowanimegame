using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E3 RID: 483
	public enum ChessRogueBoardCellStatus
	{
		// Token: 0x04000927 RID: 2343
		[OriginalName("IDLE")]
		Idle,
		// Token: 0x04000928 RID: 2344
		[OriginalName("SELECTED")]
		Selected,
		// Token: 0x04000929 RID: 2345
		[OriginalName("PROCESSING")]
		Processing,
		// Token: 0x0400092A RID: 2346
		[OriginalName("FINISH")]
		Finish
	}
}
