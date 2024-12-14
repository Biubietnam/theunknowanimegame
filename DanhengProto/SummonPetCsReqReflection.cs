using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001208 RID: 4616
	public static class SummonPetCsReqReflection
	{
		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0600CE5C RID: 52828 RVA: 0x0022998E File Offset: 0x00227B8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SummonPetCsReqReflection.descriptor;
			}
		}

		// Token: 0x04005323 RID: 21283
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTdW1tb25QZXRDc1JlcS5wcm90byIpCg5TdW1tb25QZXRDc1JlcRIXCg9z" + "dW1tb25lZF9wZXRfaWQYDyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl" + "ci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SummonPetCsReq), SummonPetCsReq.Parser, new string[]
			{
				"SummonedPetId"
			}, null, null, null, null)
		}));
	}
}
