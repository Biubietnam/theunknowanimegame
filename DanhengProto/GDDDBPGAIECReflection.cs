using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005EA RID: 1514
	public static class GDDDBPGAIECReflection
	{
		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x000BAE06 File Offset: 0x000B9006
		public static FileDescriptor Descriptor
		{
			get
			{
				return GDDDBPGAIECReflection.descriptor;
			}
		}

		// Token: 0x04001B42 RID: 6978
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHREREQlBHQUlFQy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJPCgtHRERE" + "QlBHQUlFQxIgCgthdmF0YXJfdHlwZRgFIAEoDjILLkF2YXRhclR5cGUSEgoK" + "YXNzaXN0X3VpZBgPIAEoDRIKCgJpZBgLIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GDDDBPGAIEC), GDDDBPGAIEC.Parser, new string[]
			{
				"AvatarType",
				"AssistUid",
				"Id"
			}, null, null, null, null)
		}));
	}
}
