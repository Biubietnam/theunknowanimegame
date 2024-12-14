using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002DA RID: 730
	public static class ClientMailAttachmentItemReflection
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0005CE4A File Offset: 0x0005B04A
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientMailAttachmentItemReflection.descriptor;
			}
		}

		// Token: 0x04000D80 RID: 3456
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DbGllbnRNYWlsQXR0YWNobWVudEl0ZW0ucHJvdG8iPAoYQ2xpZW50TWFp" + "bEF0dGFjaG1lbnRJdGVtEg8KB2l0ZW1faWQYCyABKA0SDwoHbWFpbF9pZBgK" + "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientMailAttachmentItem), ClientMailAttachmentItem.Parser, new string[]
			{
				"ItemId",
				"MailId"
			}, null, null, null, null)
		}));
	}
}
