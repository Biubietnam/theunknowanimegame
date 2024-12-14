using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C40 RID: 3136
	public static class OBEPIHAHMDFReflection
	{
		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x06008B1A RID: 35610 RVA: 0x0016F7D5 File Offset: 0x0016D9D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return OBEPIHAHMDFReflection.descriptor;
			}
		}

		// Token: 0x04003561 RID: 13665
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQkVQSUhBSE1ERi5wcm90bxocTWlzc2lvbkN1c3RvbVZhbHVlTGlzdC5w" + "cm90byJOCgtPQkVQSUhBSE1ERhIKCgJpZBgGIAEoDRIzChFjdXN0b21fdmFs" + "dWVfbGlzdBiIDyABKAsyFy5NaXNzaW9uQ3VzdG9tVmFsdWVMaXN0Qh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			MissionCustomValueListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OBEPIHAHMDF), OBEPIHAHMDF.Parser, new string[]
			{
				"Id",
				"CustomValueList"
			}, null, null, null, null)
		}));
	}
}
