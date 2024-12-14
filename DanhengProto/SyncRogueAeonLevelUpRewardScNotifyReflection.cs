using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200127C RID: 4732
	public static class SyncRogueAeonLevelUpRewardScNotifyReflection
	{
		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x0600D328 RID: 54056 RVA: 0x00233FDD File Offset: 0x002321DD
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueAeonLevelUpRewardScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005491 RID: 21649
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihTeW5jUm9ndWVBZW9uTGV2ZWxVcFJld2FyZFNjTm90aWZ5LnByb3RvGg5J",
			"dGVtTGlzdC5wcm90byJfCiJTeW5jUm9ndWVBZW9uTGV2ZWxVcFJld2FyZFNj",
			"Tm90aWZ5Eg0KBWxldmVsGA0gASgNEhkKBnJld2FyZBgLIAEoCzIJLkl0ZW1M",
			"aXN0Eg8KB2Flb25faWQYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueAeonLevelUpRewardScNotify), SyncRogueAeonLevelUpRewardScNotify.Parser, new string[]
			{
				"Level",
				"Reward",
				"AeonId"
			}, null, null, null, null)
		}));
	}
}
