using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A66 RID: 2662
	public static class LogisticsGameScRspReflection
	{
		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06007609 RID: 30217 RVA: 0x00139346 File Offset: 0x00137546
		public static FileDescriptor Descriptor
		{
			get
			{
				return LogisticsGameScRspReflection.descriptor;
			}
		}

		// Token: 0x04002D5A RID: 11610
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhMb2dpc3RpY3NHYW1lU2NSc3AucHJvdG8aFExvZ2lzdGljc1Njb3JlLnBy",
			"b3RvInIKEkxvZ2lzdGljc0dhbWVTY1JzcBIQCghldmVudF9pZBgBIAEoDRIP",
			"CgdyZXRjb2RlGA0gASgNEiQKC1BEQk9LSE5IUE5BGAQgAygLMg8uTG9naXN0",
			"aWNzU2NvcmUSEwoLTFBMQ0RFTEdKREkYCyABKAhCHqoCG0VnZ0xpbmsuRGFu",
			"aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LogisticsScoreReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LogisticsGameScRsp), LogisticsGameScRsp.Parser, new string[]
			{
				"EventId",
				"Retcode",
				"PDBOKHNHPNA",
				"LPLCDELGJDI"
			}, null, null, null, null)
		}));
	}
}
