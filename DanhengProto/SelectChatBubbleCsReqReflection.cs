using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200109E RID: 4254
	public static class SelectChatBubbleCsReqReflection
	{
		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x001FEF12 File Offset: 0x001FD112
		public static FileDescriptor Descriptor
		{
			get
			{
				return SelectChatBubbleCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004D17 RID: 19735
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZWxlY3RDaGF0QnViYmxlQ3NSZXEucHJvdG8iKgoVU2VsZWN0Q2hhdEJ1" + "YmJsZUNzUmVxEhEKCWJ1YmJsZV9pZBgGIAEoDUIeqgIbRWdnTGluay5EYW5o" + "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SelectChatBubbleCsReq), SelectChatBubbleCsReq.Parser, new string[]
			{
				"BubbleId"
			}, null, null, null, null)
		}));
	}
}
