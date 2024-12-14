using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000674 RID: 1652
	public static class GetCurChallengeScRspReflection
	{
		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06004A0E RID: 18958 RVA: 0x000C9B22 File Offset: 0x000C7D22
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCurChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D6D RID: 7533
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpHZXRDdXJDaGFsbGVuZ2VTY1JzcC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnBy",
			"b3RvGhBMaW5ldXBJbmZvLnByb3RvIm8KFEdldEN1ckNoYWxsZW5nZVNjUnNw",
			"EiAKC2xpbmV1cF9saXN0GAEgAygLMgsuTGluZXVwSW5mbxIPCgdyZXRjb2Rl",
			"GAkgASgNEiQKDWN1cl9jaGFsbGVuZ2UYCyABKAsyDS5DdXJDaGFsbGVuZ2VC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengeScRsp), GetCurChallengeScRsp.Parser, new string[]
			{
				"LineupList",
				"Retcode",
				"CurChallenge"
			}, null, null, null, null)
		}));
	}
}
