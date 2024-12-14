using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE0 RID: 3552
	public static class ReviveRogueAvatarScRspReflection
	{
		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x001A8DF9 File Offset: 0x001A6FF9
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReviveRogueAvatarScRspReflection.descriptor;
			}
		}

		// Token: 0x04004129 RID: 16681
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxSZXZpdmVSb2d1ZUF2YXRhclNjUnNwLnByb3RvGhVSb2d1ZVJldml2ZUlu",
			"Zm8ucHJvdG8iuAEKFlJldml2ZVJvZ3VlQXZhdGFyU2NSc3ASFgoOYmFzZV9h",
			"dmF0YXJfaWQYBSABKA0SGwoTYmFzZV9hdmF0YXJfaWRfbGlzdBgNIAMoDRIc",
			"ChR0cmlhbF9hdmF0YXJfaWRfbGlzdBgPIAMoDRIPCgdyZXRjb2RlGAggASgN",
			"EiUKC3Jldml2ZV9pbmZvGAsgASgLMhAuUm9ndWVSZXZpdmVJbmZvEhMKC0VJ",
			"QUNPTU1KQ0NMGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueReviveInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReviveRogueAvatarScRsp), ReviveRogueAvatarScRsp.Parser, new string[]
			{
				"BaseAvatarId",
				"BaseAvatarIdList",
				"TrialAvatarIdList",
				"Retcode",
				"ReviveInfo",
				"EIACOMMJCCL"
			}, null, null, null, null)
		}));
	}
}
