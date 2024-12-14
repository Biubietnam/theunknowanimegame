using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117E RID: 4478
	public static class SpringRecoverScRspReflection
	{
		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600C7D9 RID: 51161 RVA: 0x00218334 File Offset: 0x00216534
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRecoverScRspReflection.descriptor;
			}
		}

		// Token: 0x040050B2 RID: 20658
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTcHJpbmdSZWNvdmVyU2NSc3AucHJvdG8aEkhlYWxQb29sSW5mby5wcm90" + "byJKChJTcHJpbmdSZWNvdmVyU2NSc3ASIwoMSGVhbFBvb2xJbmZvGAogASgL" + "Mg0uSGVhbFBvb2xJbmZvEg8KB3JldGNvZGUYDiABKA1CHqoCG0VnZ0xpbmsu" + "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			HealPoolInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverScRsp), SpringRecoverScRsp.Parser, new string[]
			{
				"HealPoolInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
