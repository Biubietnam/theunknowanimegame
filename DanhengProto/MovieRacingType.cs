using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B99 RID: 2969
	public enum MovieRacingType
	{
		// Token: 0x04003254 RID: 12884
		[OriginalName("MOVIE_RACING_OVER_TAKE")]
		MovieRacingOverTake,
		// Token: 0x04003255 RID: 12885
		[OriginalName("MOVIE_RACING_OVER_TAKE_ENDLESS")]
		MovieRacingOverTakeEndless,
		// Token: 0x04003256 RID: 12886
		[OriginalName("MOVIE_RACING_SHOOTING")]
		MovieRacingShooting,
		// Token: 0x04003257 RID: 12887
		[OriginalName("MOVIE_RACING_SHOOTING_ENDLESS")]
		MovieRacingShootingEndless
	}
}
