using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D82 RID: 3458
	public static class RecallPetCsReqReflection
	{
		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06009A6E RID: 39534 RVA: 0x0019B01F File Offset: 0x0019921F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RecallPetCsReqReflection.descriptor;
			}
		}

		// Token: 0x04003BF7 RID: 15351
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRSZWNhbGxQZXRDc1JlcS5wcm90byIpCg5SZWNhbGxQZXRDc1JlcRIXCg9z" + "dW1tb25lZF9wZXRfaWQYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RecallPetCsReq), RecallPetCsReq.Parser, new string[]
			{
				"SummonedPetId"
			}, null, null, null, null)
		}));
	}
}
