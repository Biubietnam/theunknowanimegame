using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D2 RID: 1234
	public static class ExchangeGachaCeilingCsReqReflection
	{
		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x00097874 File Offset: 0x00095A74
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExchangeGachaCeilingCsReqReflection.descriptor;
			}
		}

		// Token: 0x040015E4 RID: 5604
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9FeGNoYW5nZUdhY2hhQ2VpbGluZ0NzUmVxLnByb3RvIkIKGUV4Y2hhbmdl" + "R2FjaGFDZWlsaW5nQ3NSZXESEgoKZ2FjaGFfdHlwZRgIIAEoDRIRCglhdmF0" + "YXJfaWQYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeGachaCeilingCsReq), ExchangeGachaCeilingCsReq.Parser, new string[]
			{
				"GachaType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
