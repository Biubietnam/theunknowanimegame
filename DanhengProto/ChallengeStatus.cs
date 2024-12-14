using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001BB RID: 443
	public enum ChallengeStatus
	{
		// Token: 0x04000866 RID: 2150
		[OriginalName("CHALLENGE_UNKNOWN")]
		ChallengeUnknown,
		// Token: 0x04000867 RID: 2151
		[OriginalName("CHALLENGE_DOING")]
		ChallengeDoing,
		// Token: 0x04000868 RID: 2152
		[OriginalName("CHALLENGE_FINISH")]
		ChallengeFinish,
		// Token: 0x04000869 RID: 2153
		[OriginalName("CHALLENGE_FAILED")]
		ChallengeFailed
	}
}
