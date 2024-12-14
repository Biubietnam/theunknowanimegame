using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E4 RID: 4836
	public static class TakeMailAttachmentScRspReflection
	{
		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x0023F8EF File Offset: 0x0023DAEF
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeMailAttachmentScRspReflection.descriptor;
			}
		}

		// Token: 0x0400561F RID: 22047
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1UYWtlTWFpbEF0dGFjaG1lbnRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv",
			"dG8aHkNsaWVudE1haWxBdHRhY2htZW50SXRlbS5wcm90byKSAQoXVGFrZU1h",
			"aWxBdHRhY2htZW50U2NSc3ASHQoKQXR0YWNobWVudBgKIAEoCzIJLkl0ZW1M",
			"aXN0Eg8KB3JldGNvZGUYASABKA0SLwoMRmFpbE1haWxMaXN0GAwgAygLMhku",
			"Q2xpZW50TWFpbEF0dGFjaG1lbnRJdGVtEhYKDlN1Y2NNYWlsSWRMaXN0GAsg",
			"AygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor,
			ClientMailAttachmentItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeMailAttachmentScRsp), TakeMailAttachmentScRsp.Parser, new string[]
			{
				"Attachment",
				"Retcode",
				"FailMailList",
				"SuccMailIdList"
			}, null, null, null, null)
		}));
	}
}
