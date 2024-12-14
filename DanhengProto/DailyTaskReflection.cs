using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000356 RID: 854
	public static class DailyTaskReflection
	{
		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x0006B332 File Offset: 0x00069532
		public static FileDescriptor Descriptor
		{
			get
			{
				return DailyTaskReflection.descriptor;
			}
		}

		// Token: 0x04000F7B RID: 3963
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9EYWlseVRhc2sucHJvdG8iOQoJRGFpbHlUYXNrEhMKC2lzX2ZpbmlzaGVk" + "GAcgASgIEhcKD21haW5fbWlzc2lvbl9pZBgDIAEoDUIeqgIbRWdnTGluay5E" + "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DailyTask), DailyTask.Parser, new string[]
			{
				"IsFinished",
				"MainMissionId"
			}, null, null, null, null)
		}));
	}
}
