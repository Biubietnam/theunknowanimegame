using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001252 RID: 4690
	public static class SwordTrainingStoryBattleScRspReflection
	{
		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600D174 RID: 53620 RVA: 0x002302CE File Offset: 0x0022E4CE
		public static FileDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStoryBattleScRspReflection.descriptor;
			}
		}

		// Token: 0x04005408 RID: 21512
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNTd29yZFRyYWluaW5nU3RvcnlCYXR0bGVTY1JzcC5wcm90bxoVU2NlbmVC",
			"YXR0bGVJbmZvLnByb3RvIlcKHVN3b3JkVHJhaW5pbmdTdG9yeUJhdHRsZVNj",
			"UnNwEg8KB3JldGNvZGUYDiABKA0SJQoLYmF0dGxlX2luZm8YAyABKAsyEC5T",
			"Y2VuZUJhdHRsZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStoryBattleScRsp), SwordTrainingStoryBattleScRsp.Parser, new string[]
			{
				"Retcode",
				"BattleInfo"
			}, null, null, null, null)
		}));
	}
}
