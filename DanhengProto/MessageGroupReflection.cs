using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AC0 RID: 2752
	public static class MessageGroupReflection
	{
		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06007A13 RID: 31251 RVA: 0x0014345A File Offset: 0x0014165A
		public static FileDescriptor Descriptor
		{
			get
			{
				return MessageGroupReflection.descriptor;
			}
		}

		// Token: 0x04002ED1 RID: 11985
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJNZXNzYWdlR3JvdXAucHJvdG8aFE1lc3NhZ2VTZWN0aW9uLnByb3RvGhhN",
			"ZXNzYWdlR3JvdXBTdGF0dXMucHJvdG8ioAEKDE1lc3NhZ2VHcm91cBItChRt",
			"ZXNzYWdlX3NlY3Rpb25fbGlzdBgLIAMoCzIPLk1lc3NhZ2VTZWN0aW9uEiMK",
			"BnN0YXR1cxgPIAEoDjITLk1lc3NhZ2VHcm91cFN0YXR1cxIUCgxyZWZyZXNo",
			"X3RpbWUYASABKAMSCgoCaWQYCiABKA0SGgoSbWVzc2FnZV9zZWN0aW9uX2lk",
			"GAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			MessageSectionReflection.Descriptor,
			MessageGroupStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MessageGroup), MessageGroup.Parser, new string[]
			{
				"MessageSectionList",
				"Status",
				"RefreshTime",
				"Id",
				"MessageSectionId"
			}, null, null, null, null)
		}));
	}
}
