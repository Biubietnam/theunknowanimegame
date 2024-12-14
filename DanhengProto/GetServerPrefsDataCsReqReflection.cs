using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007EC RID: 2028
	public static class GetServerPrefsDataCsReqReflection
	{
		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x000F150E File Offset: 0x000EF70E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetServerPrefsDataCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002322 RID: 8994
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRTZXJ2ZXJQcmVmc0RhdGFDc1JlcS5wcm90byIyChdHZXRTZXJ2ZXJQ" + "cmVmc0RhdGFDc1JlcRIXCg9zZXJ2ZXJfcHJlZnNfaWQYByABKA1CHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetServerPrefsDataCsReq), GetServerPrefsDataCsReq.Parser, new string[]
			{
				"ServerPrefsId"
			}, null, null, null, null)
		}));
	}
}
