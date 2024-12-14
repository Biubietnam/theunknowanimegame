using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADA RID: 2778
	public static class MissionCustomValueReflection
	{
		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06007B19 RID: 31513 RVA: 0x00145D9C File Offset: 0x00143F9C
		public static FileDescriptor Descriptor
		{
			get
			{
				return MissionCustomValueReflection.descriptor;
			}
		}

		// Token: 0x04002F39 RID: 12089
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNaXNzaW9uQ3VzdG9tVmFsdWUucHJvdG8iOQoSTWlzc2lvbkN1c3RvbVZh" + "bHVlEg0KBWluZGV4GAogASgNEhQKDGN1c3RvbV92YWx1ZRgMIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValue), MissionCustomValue.Parser, new string[]
			{
				"Index",
				"CustomValue"
			}, null, null, null, null)
		}));
	}
}
