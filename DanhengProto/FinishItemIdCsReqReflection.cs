using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000582 RID: 1410
	public static class FinishItemIdCsReqReflection
	{
		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x000ABE8D File Offset: 0x000AA08D
		public static FileDescriptor Descriptor
		{
			get
			{
				return FinishItemIdCsReqReflection.descriptor;
			}
		}

		// Token: 0x04001915 RID: 6421
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGaW5pc2hJdGVtSWRDc1JlcS5wcm90byI1ChFGaW5pc2hJdGVtSWRDc1Jl" + "cRIPCgdpdGVtX2lkGAwgASgNEg8KB3RleHRfaWQYCiABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FinishItemIdCsReq), FinishItemIdCsReq.Parser, new string[]
			{
				"ItemId",
				"TextId"
			}, null, null, null, null)
		}));
	}
}
