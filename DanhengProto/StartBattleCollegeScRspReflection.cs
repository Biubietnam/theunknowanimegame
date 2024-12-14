using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200119E RID: 4510
	public static class StartBattleCollegeScRspReflection
	{
		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600C959 RID: 51545 RVA: 0x0021BF82 File Offset: 0x0021A182
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartBattleCollegeScRspReflection.descriptor;
			}
		}

		// Token: 0x04005136 RID: 20790
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1TdGFydEJhdHRsZUNvbGxlZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0bGVJ",
			"bmZvLnByb3RvIl0KF1N0YXJ0QmF0dGxlQ29sbGVnZVNjUnNwEgoKAmlkGAkg",
			"ASgNEg8KB3JldGNvZGUYAiABKA0SJQoLYmF0dGxlX2luZm8YBSABKAsyEC5T",
			"Y2VuZUJhdHRsZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartBattleCollegeScRsp), StartBattleCollegeScRsp.Parser, new string[]
			{
				"Id",
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
