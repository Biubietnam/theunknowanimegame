using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200129A RID: 4762
	public static class SyncRogueRewardInfoScNotifyReflection
	{
		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600D477 RID: 54391 RVA: 0x00237499 File Offset: 0x00235699
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueRewardInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005504 RID: 21764
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTeW5jUm9ndWVSZXdhcmRJbmZvU2NOb3RpZnkucHJvdG8aGlJvZ3VlU2Nv",
			"cmVSZXdhcmRJbmZvLnByb3RvIlUKG1N5bmNSb2d1ZVJld2FyZEluZm9TY05v",
			"dGlmeRI2Chdyb2d1ZV9zY29yZV9yZXdhcmRfaW5mbxgKIAEoCzIVLlJvZ3Vl",
			"U2NvcmVSZXdhcmRJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueScoreRewardInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueRewardInfoScNotify), SyncRogueRewardInfoScNotify.Parser, new string[]
			{
				"RogueScoreRewardInfo"
			}, null, null, null, null)
		}));
	}
}
