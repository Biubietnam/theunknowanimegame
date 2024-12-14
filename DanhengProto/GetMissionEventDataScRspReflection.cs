using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000722 RID: 1826
	public static class GetMissionEventDataScRspReflection
	{
		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x000DBB0A File Offset: 0x000D9D0A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMissionEventDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002010 RID: 8208
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRNaXNzaW9uRXZlbnREYXRhU2NSc3AucHJvdG8aDU1pc3Npb24ucHJv",
			"dG8ibQoYR2V0TWlzc2lvbkV2ZW50RGF0YVNjUnNwEg8KB3JldGNvZGUYCyAB",
			"KA0SJAoSbWlzc2lvbl9ldmVudF9saXN0GAQgAygLMgguTWlzc2lvbhIaChJj",
			"aGFsbGVuZ2VfZXZlbnRfaWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionEventDataScRsp), GetMissionEventDataScRsp.Parser, new string[]
			{
				"Retcode",
				"MissionEventList",
				"ChallengeEventId"
			}, null, null, null, null)
		}));
	}
}
