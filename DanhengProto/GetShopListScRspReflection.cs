using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F6 RID: 2038
	public static class GetShopListScRspReflection
	{
		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06005AEB RID: 23275 RVA: 0x000F228A File Offset: 0x000F048A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetShopListScRspReflection.descriptor;
			}
		}

		// Token: 0x0400233E RID: 9022
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTaG9wTGlzdFNjUnNwLnByb3RvGgpTaG9wLnByb3RvIk4KEEdldFNo" + "b3BMaXN0U2NSc3ASDwoHcmV0Y29kZRgKIAEoDRIXCghTaG9wTGlzdBgBIAMo" + "CzIFLlNob3ASEAoIU2hvcFR5cGUYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu" + "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ShopReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetShopListScRsp), GetShopListScRsp.Parser, new string[]
			{
				"Retcode",
				"ShopList",
				"ShopType"
			}, null, null, null, null)
		}));
	}
}
