using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033C RID: 828
	public static class CurChallengeReflection
	{
		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x000686B5 File Offset: 0x000668B5
		public static FileDescriptor Descriptor
		{
			get
			{
				return CurChallengeReflection.descriptor;
			}
		}

		// Token: 0x04000F11 RID: 3857
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJDdXJDaGFsbGVuZ2UucHJvdG8aFUNoYWxsZW5nZVN0YXR1cy5wcm90bxoV",
			"RXh0cmFMaW5ldXBUeXBlLnByb3RvGhFLaWxsTW9uc3Rlci5wcm90bxoYQ2hh",
			"bGxlbmdlU3RvcnlJbmZvLnByb3RvIpgCCgxDdXJDaGFsbGVuZ2USKwoRZXh0",
			"cmFfbGluZXVwX3R5cGUYCSABKA4yEC5FeHRyYUxpbmV1cFR5cGUSFAoMY2hh",
			"bGxlbmdlX2lkGAYgASgNEhMKC3JvdW5kX2NvdW50GAEgASgNEhEKCXNjb3Jl",
			"X3R3bxgNIAEoDRInChFraWxsX21vbnN0ZXJfbGlzdBgFIAMoCzIMLktpbGxN",
			"b25zdGVyEhAKCHNjb3JlX2lkGAwgASgNEhcKD2RlYWRfYXZhdGFyX251bRgO",
			"IAEoDRIgCgZzdGF0dXMYCCABKA4yEC5DaGFsbGVuZ2VTdGF0dXMSJwoKc3Rh",
			"Z2VfaW5mbxgCIAEoCzITLkNoYWxsZW5nZVN0b3J5SW5mb0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChallengeStatusReflection.Descriptor,
			ExtraLineupTypeReflection.Descriptor,
			KillMonsterReflection.Descriptor,
			ChallengeStoryInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CurChallenge), CurChallenge.Parser, new string[]
			{
				"ExtraLineupType",
				"ChallengeId",
				"RoundCount",
				"ScoreTwo",
				"KillMonsterList",
				"ScoreId",
				"DeadAvatarNum",
				"Status",
				"StageInfo"
			}, null, null, null, null)
		}));
	}
}
