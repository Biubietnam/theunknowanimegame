using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B5 RID: 5045
	public enum TutorialStatus
	{
		// Token: 0x04005994 RID: 22932
		[OriginalName("TUTORIAL_NONE")]
		TutorialNone,
		// Token: 0x04005995 RID: 22933
		[OriginalName("TUTORIAL_UNLOCK")]
		TutorialUnlock,
		// Token: 0x04005996 RID: 22934
		[OriginalName("TUTORIAL_FINISH")]
		TutorialFinish
	}
}
