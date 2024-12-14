using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC6 RID: 2758
	public static class MessageSectionReflection
	{
		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06007A48 RID: 31304 RVA: 0x00143DA1 File Offset: 0x00141FA1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MessageSectionReflection.descriptor;
			}
		}

		// Token: 0x04002EEC RID: 12012
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRNZXNzYWdlU2VjdGlvbi5wcm90bxoRTWVzc2FnZUl0ZW0ucHJvdG8aGk1l",
			"c3NhZ2VTZWN0aW9uU3RhdHVzLnByb3RvIpcBCg5NZXNzYWdlU2VjdGlvbhIW",
			"Cg5mcm96ZW5faXRlbV9pZBgOIAEoDRIZChFtZXNzYWdlX2l0ZW1fbGlzdBgJ",
			"IAMoDRIlCgZzdGF0dXMYCiABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1cxIf",
			"CglpdGVtX2xpc3QYDyADKAsyDC5NZXNzYWdlSXRlbRIKCgJpZBgDIAEoDUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MessageItemReflection.Descriptor,
			MessageSectionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MessageSection), MessageSection.Parser, new string[]
			{
				"FrozenItemId",
				"MessageItemList",
				"Status",
				"ItemList",
				"Id"
			}, null, null, null, null)
		}));
	}
}
