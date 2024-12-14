using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADC RID: 2780
	public static class MissionCustomValueListReflection
	{
		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x001460D1 File Offset: 0x001442D1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionCustomValueListReflection.descriptor;
			}
		}

		// Token: 0x04002F40 RID: 12096
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNaXNzaW9uQ3VzdG9tVmFsdWVMaXN0LnByb3RvGhhNaXNzaW9uQ3VzdG9t" + "VmFsdWUucHJvdG8iSAoWTWlzc2lvbkN1c3RvbVZhbHVlTGlzdBIuChFjdXN0" + "b21fdmFsdWVfbGlzdBgFIAMoCzITLk1pc3Npb25DdXN0b21WYWx1ZUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MissionCustomValueReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValueList), MissionCustomValueList.Parser, new string[]
			{
				"CustomValueList"
			}, null, null, null, null)
		}));
	}
}
