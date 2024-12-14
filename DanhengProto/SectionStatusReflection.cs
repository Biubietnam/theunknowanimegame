using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001098 RID: 4248
	public static class SectionStatusReflection
	{
		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600BD62 RID: 48482 RVA: 0x001FE6C5 File Offset: 0x001FC8C5
		public static FileDescriptor Descriptor
		{
			get
			{
				return SectionStatusReflection.descriptor;
			}
		}

		// Token: 0x04004D06 RID: 19718
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWN0aW9uU3RhdHVzLnByb3RvGhpNZXNzYWdlU2VjdGlvblN0YXR1cy5w" + "cm90byJSCg1TZWN0aW9uU3RhdHVzEi0KDnNlY3Rpb25fc3RhdHVzGAUgASgO" + "MhUuTWVzc2FnZVNlY3Rpb25TdGF0dXMSEgoKc2VjdGlvbl9pZBgPIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MessageSectionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SectionStatus), SectionStatus.Parser, new string[]
			{
				"SectionStatus_",
				"SectionId"
			}, null, null, null, null)
		}));
	}
}
