using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D8 RID: 2008
	public static class GetRollShopInfoCsReqReflection
	{
		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06005997 RID: 22935 RVA: 0x000EF068 File Offset: 0x000ED268
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRollShopInfoCsReqReflection.descriptor;
			}
		}

		// Token: 0x040022CC RID: 8908
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRSb2xsU2hvcEluZm9Dc1JlcS5wcm90byIsChRHZXRSb2xsU2hvcElu" + "Zm9Dc1JlcRIUCgxyb2xsX3Nob3BfaWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRollShopInfoCsReq), GetRollShopInfoCsReq.Parser, new string[]
			{
				"RollShopId"
			}, null, null, null, null)
		}));
	}
}
