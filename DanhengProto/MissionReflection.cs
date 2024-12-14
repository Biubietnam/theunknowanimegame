using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD6 RID: 2774
	public static class MissionReflection
	{
		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x00145730 File Offset: 0x00143930
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionReflection.descriptor;
			}
		}

		// Token: 0x04002F2A RID: 12074
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg1NaXNzaW9uLnByb3RvGhNNaXNzaW9uU3RhdHVzLnByb3RvIkcKB01pc3Np" + "b24SEAoIcHJvZ3Jlc3MYAyABKA0SHgoGc3RhdHVzGAggASgOMg4uTWlzc2lv" + "blN0YXR1cxIKCgJpZBgGIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MissionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(Mission), Mission.Parser, new string[]
			{
				"Progress",
				"Status",
				"Id"
			}, null, null, null, null)
		}));
	}
}
