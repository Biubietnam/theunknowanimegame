using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000776 RID: 1910
	public static class GetPrivateChatHistoryScRspReflection
	{
		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x000E535D File Offset: 0x000E355D
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPrivateChatHistoryScRspReflection.descriptor;
			}
		}

		// Token: 0x04002173 RID: 8563
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBHZXRQcml2YXRlQ2hhdEhpc3RvcnlTY1JzcC5wcm90bxoVQ2hhdE1lc3Nh",
			"Z2VEYXRhLnByb3RvIoIBChpHZXRQcml2YXRlQ2hhdEhpc3RvcnlTY1JzcBIS",
			"Cgp0YXJnZXRfdWlkGAggASgNEisKEWNoYXRfbWVzc2FnZV9saXN0GAUgAygL",
			"MhAuQ2hhdE1lc3NhZ2VEYXRhEg8KB3JldGNvZGUYDiABKA0SEgoKY29udGFj",
			"dF9pZBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			ChatMessageDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPrivateChatHistoryScRsp), GetPrivateChatHistoryScRsp.Parser, new string[]
			{
				"TargetUid",
				"ChatMessageList",
				"Retcode",
				"ContactId"
			}, null, null, null, null)
		}));
	}
}
