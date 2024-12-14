using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A8 RID: 1704
	public static class GetFirstTalkByPerformanceNpcCsReqReflection
	{
		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06004C51 RID: 19537 RVA: 0x000CF19B File Offset: 0x000CD39B
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001E36 RID: 7734
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHZXRGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjQ3NSZXEucHJvdG8iQAoh" + "R2V0Rmlyc3RUYWxrQnlQZXJmb3JtYW5jZU5wY0NzUmVxEhsKE3BlcmZvcm1h" + "bmNlX2lkX2xpc3QYBSADKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkByPerformanceNpcCsReq), GetFirstTalkByPerformanceNpcCsReq.Parser, new string[]
			{
				"PerformanceIdList"
			}, null, null, null, null)
		}));
	}
}
