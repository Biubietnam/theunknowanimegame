using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A72 RID: 2674
	public static class MainMissionReflection
	{
		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x0013A7FC File Offset: 0x001389FC
		public static FileDescriptor Descriptor
		{
			get
			{
				return MainMissionReflection.descriptor;
			}
		}

		// Token: 0x04002D8D RID: 11661
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFNYWluTWlzc2lvbi5wcm90bxoYTWlzc2lvbkN1c3RvbVZhbHVlLnByb3Rv",
			"GhNNaXNzaW9uU3RhdHVzLnByb3RvImkKC01haW5NaXNzaW9uEgoKAmlkGA4g",
			"ASgNEi4KEWN1c3RvbV92YWx1ZV9saXN0GAEgAygLMhMuTWlzc2lvbkN1c3Rv",
			"bVZhbHVlEh4KBnN0YXR1cxgPIAEoDjIOLk1pc3Npb25TdGF0dXNCHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MissionCustomValueReflection.Descriptor,
			MissionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MainMission), MainMission.Parser, new string[]
			{
				"Id",
				"CustomValueList",
				"Status"
			}, null, null, null, null)
		}));
	}
}
