using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A74 RID: 2676
	public static class MainMissionCustomValueReflection
	{
		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x0013AC2E File Offset: 0x00138E2E
		public static FileDescriptor Descriptor
		{
			get
			{
				return MainMissionCustomValueReflection.descriptor;
			}
		}

		// Token: 0x04002D97 RID: 11671
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxNYWluTWlzc2lvbkN1c3RvbVZhbHVlLnByb3RvGhxNaXNzaW9uQ3VzdG9t",
			"VmFsdWVMaXN0LnByb3RvImUKFk1haW5NaXNzaW9uQ3VzdG9tVmFsdWUSMgoR",
			"Y3VzdG9tX3ZhbHVlX2xpc3QYCyABKAsyFy5NaXNzaW9uQ3VzdG9tVmFsdWVM",
			"aXN0EhcKD21haW5fbWlzc2lvbl9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MissionCustomValueListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MainMissionCustomValue), MainMissionCustomValue.Parser, new string[]
			{
				"CustomValueList",
				"MainMissionId"
			}, null, null, null, null)
		}));
	}
}
