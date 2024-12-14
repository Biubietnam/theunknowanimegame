using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A84 RID: 2692
	public static class MarkChatEmojiCsReqReflection
	{
		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x0600775E RID: 30558 RVA: 0x0013CA18 File Offset: 0x0013AC18
		public static FileDescriptor Descriptor
		{
			get
			{
				return MarkChatEmojiCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002DD7 RID: 11735
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJrQ2hhdEVtb2ppQ3NSZXEucHJvdG8iPAoSTWFya0NoYXRFbW9qaUNz" + "UmVxEhAKCGV4dHJhX2lkGA8gASgNEhQKDGlzX3JlbW92ZV9pZBgEIAEoCEIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MarkChatEmojiCsReq), MarkChatEmojiCsReq.Parser, new string[]
			{
				"ExtraId",
				"IsRemoveId"
			}, null, null, null, null)
		}));
	}
}
