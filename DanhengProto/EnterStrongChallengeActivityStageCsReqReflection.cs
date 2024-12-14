using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046A RID: 1130
	public static class EnterStrongChallengeActivityStageCsReqReflection
	{
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x0008A7A1 File Offset: 0x000889A1
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400140C RID: 5132
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CixFbnRlclN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5U3RhZ2VDc1JlcS5wcm90",
			"bxobU3Ryb25nQ2hhbGxlbmdlQXZhdGFyLnByb3RvInoKJkVudGVyU3Ryb25n",
			"Q2hhbGxlbmdlQWN0aXZpdHlTdGFnZUNzUmVxEhAKCHN0YWdlX2lkGA4gASgN",
			"EhEKCWJ1ZmZfbGlzdBgCIAMoDRIrCgthdmF0YXJfbGlzdBgBIAMoCzIWLlN0",
			"cm9uZ0NoYWxsZW5nZUF2YXRhckIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			StrongChallengeAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterStrongChallengeActivityStageCsReq), EnterStrongChallengeActivityStageCsReq.Parser, new string[]
			{
				"StageId",
				"BuffList",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
