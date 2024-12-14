using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200110C RID: 4364
	public static class SetLanguageCsReqReflection
	{
		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x0020AAC0 File Offset: 0x00208CC0
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetLanguageCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004EB5 RID: 20149
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXRMYW5ndWFnZUNzUmVxLnByb3RvGhJMYW5ndWFnZVR5cGUucHJvdG8i" + "MwoQU2V0TGFuZ3VhZ2VDc1JlcRIfCghsYW5ndWFnZRgNIAEoDjINLkxhbmd1" + "YWdlVHlwZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[]
		{
			LanguageTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetLanguageCsReq), SetLanguageCsReq.Parser, new string[]
			{
				"Language"
			}, null, null, null, null)
		}));
	}
}
