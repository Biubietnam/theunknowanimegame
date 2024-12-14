using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E4 RID: 228
	public static class BattleEventBattleInfoReflection
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0001E16D File Offset: 0x0001C36D
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleEventBattleInfoReflection.descriptor;
			}
		}

		// Token: 0x04000440 RID: 1088
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtCYXR0bGVFdmVudEJhdHRsZUluZm8ucHJvdG8aEVBIS01MT01DTk1OLnBy",
			"b3RvGhlCYXR0bGVFdmVudFByb3BlcnR5LnByb3RvIngKFUJhdHRsZUV2ZW50",
			"QmF0dGxlSW5mbxIXCg9iYXR0bGVfZXZlbnRfaWQYASABKA0SJAoGc3RhdHVz",
			"GAIgASgLMhQuQmF0dGxlRXZlbnRQcm9wZXJ0eRIgCgpza2lsbF9pbmZvGAMg",
			"AygLMgwuUEhLTUxPTUNOTU5CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			PHKMLOMCNMNReflection.Descriptor,
			BattleEventPropertyReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleEventBattleInfo), BattleEventBattleInfo.Parser, new string[]
			{
				"BattleEventId",
				"Status",
				"SkillInfo"
			}, null, null, null, null)
		}));
	}
}
