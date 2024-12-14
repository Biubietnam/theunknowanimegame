using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000DC RID: 220
	public static class BattleCollegeDataChangeScNotifyReflection
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0001D7A7 File Offset: 0x0001B9A7
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleCollegeDataChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000420 RID: 1056
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVCYXR0bGVDb2xsZWdlRGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGg5JdGVt",
			"TGlzdC5wcm90byJzCh9CYXR0bGVDb2xsZWdlRGF0YUNoYW5nZVNjTm90aWZ5",
			"EhMKC0hEREdQTU1OSUNEGAcgASgNEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1M",
			"aXN0EiAKGGZpbmlzaGVkX2NvbGxlZ2VfaWRfbGlzdBgDIAMoDUIeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleCollegeDataChangeScNotify), BattleCollegeDataChangeScNotify.Parser, new string[]
			{
				"HDDGPMMNICD",
				"Reward",
				"FinishedCollegeIdList"
			}, null, null, null, null)
		}));
	}
}
