using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200046C RID: 1132
	public static class EnterStrongChallengeActivityStageScRspReflection
	{
		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x0600326E RID: 12910 RVA: 0x0008ABCF File Offset: 0x00088DCF
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterStrongChallengeActivityStageScRspReflection.descriptor;
			}
		}

		// Token: 0x04001417 RID: 5143
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CixFbnRlclN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90",
			"bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvInIKJkVudGVyU3Ryb25nQ2hhbGxl",
			"bmdlQWN0aXZpdHlTdGFnZVNjUnNwEhAKCHN0YWdlX2lkGAwgASgNEg8KB3Jl",
			"dGNvZGUYCCABKA0SJQoLYmF0dGxlX2luZm8YAyABKAsyEC5TY2VuZUJhdHRs",
			"ZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterStrongChallengeActivityStageScRsp), EnterStrongChallengeActivityStageScRsp.Parser, new string[]
			{
				"StageId",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
