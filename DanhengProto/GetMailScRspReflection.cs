using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000706 RID: 1798
	public static class GetMailScRspReflection
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600505F RID: 20575 RVA: 0x000D88C4 File Offset: 0x000D6AC4
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMailScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F96 RID: 8086
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJHZXRNYWlsU2NSc3AucHJvdG8aEENsaWVudE1haWwucHJvdG8ikwEKDEdl",
			"dE1haWxTY1JzcBIjCg5Ob3RpY2VNYWlsTGlzdBgOIAMoCzILLkNsaWVudE1h",
			"aWwSEAoIVG90YWxOdW0YDyABKA0SDQoFSXNFbmQYCCABKAgSDQoFU3RhcnQY",
			"BiABKA0SDwoHcmV0Y29kZRgCIAEoDRIdCghNYWlsTGlzdBgHIAMoCzILLkNs",
			"aWVudE1haWxCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			ClientMailReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMailScRsp), GetMailScRsp.Parser, new string[]
			{
				"NoticeMailList",
				"TotalNum",
				"IsEnd",
				"Start",
				"Retcode",
				"MailList"
			}, null, null, null, null)
		}));
	}
}
