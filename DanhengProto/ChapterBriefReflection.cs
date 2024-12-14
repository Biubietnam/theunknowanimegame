using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D4 RID: 468
	public static class ChapterBriefReflection
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0003C34E File Offset: 0x0003A54E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChapterBriefReflection.descriptor;
			}
		}

		// Token: 0x040008CC RID: 2252
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJDaGFwdGVyQnJpZWYucHJvdG8iXQoMQ2hhcHRlckJyaWVmEgoKAmlkGAgg" + "ASgNEhMKC0pKR05PTUdQQ0tNGA4gASgNEhwKFHRha2VuX3Jld2FyZF9pZF9s" + "aXN0GAQgAygNEg4KBmlzX25ldxgBIAEoCEIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChapterBrief), ChapterBrief.Parser, new string[]
			{
				"Id",
				"JJGNOMGPCKM",
				"TakenRewardIdList",
				"IsNew"
			}, null, null, null, null)
		}));
	}
}
