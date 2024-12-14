using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF4 RID: 3572
	public static class RogueAeonInfoReflection
	{
		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x001AD056 File Offset: 0x001AB256
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueAeonInfoReflection.descriptor;
			}
		}

		// Token: 0x04004187 RID: 16775
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNSb2d1ZUFlb25JbmZvLnByb3RvIngKDVJvZ3VlQWVvbkluZm8SFAoMYWVv",
			"bl9pZF9saXN0GAogAygNEhMKC2lzX3VubG9ja2VkGAggASgIEhkKEXVubG9j",
			"a2VkX2Flb25fbnVtGAsgASgNEiEKGXVubG9ja2VkX2Flb25fZW5oYW5jZV9u",
			"dW0YDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueAeonInfo), RogueAeonInfo.Parser, new string[]
			{
				"AeonIdList",
				"IsUnlocked",
				"UnlockedAeonNum",
				"UnlockedAeonEnhanceNum"
			}, null, null, null, null)
		}));
	}
}
