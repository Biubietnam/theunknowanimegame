using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A70 RID: 2672
	public static class MailTypeReflection
	{
		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x0013A7A4 File Offset: 0x001389A4
		public static FileDescriptor Descriptor
		{
			get
			{
				return MailTypeReflection.descriptor;
			}
		}

		// Token: 0x04002D89 RID: 11657
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5NYWlsVHlwZS5wcm90byo0CghNYWlsVHlwZRIUChBNQUlMX1RZUEVfTk9S" + "TUFMEAASEgoOTUFJTF9UWVBFX1NUQVIQAUIeqgIbRWdnTGluay5EYW5oZW5n" + "U2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(MailType)
		}, null, null));
	}
}
