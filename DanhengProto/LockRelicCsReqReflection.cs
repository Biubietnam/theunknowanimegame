using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A58 RID: 2648
	public static class LockRelicCsReqReflection
	{
		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x00137DF2 File Offset: 0x00135FF2
		public static FileDescriptor Descriptor
		{
			get
			{
				return LockRelicCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002D2A RID: 11562
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2NrUmVsaWNDc1JlcS5wcm90byJZCg5Mb2NrUmVsaWNDc1JlcRIUCgxp" + "c19wcm90ZWN0ZWQYDSABKAgSHAoUcmVsaWNfdW5pcXVlX2lkX2xpc3QYCCAD" + "KA0SEwoLT0tLSkZJQk5HQ0UYAiABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LockRelicCsReq), LockRelicCsReq.Parser, new string[]
			{
				"IsProtected",
				"RelicUniqueIdList",
				"OKKJFIBNGCE"
			}, null, null, null, null)
		}));
	}
}
