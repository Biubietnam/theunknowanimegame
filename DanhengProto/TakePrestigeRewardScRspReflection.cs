using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130A RID: 4874
	public static class TakePrestigeRewardScRspReflection
	{
		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600D977 RID: 55671 RVA: 0x00243646 File Offset: 0x00241846
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakePrestigeRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040056A8 RID: 22184
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlUHJlc3RpZ2VSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv" + "dG8iVAoXVGFrZVByZXN0aWdlUmV3YXJkU2NSc3ASGQoGcmV3YXJkGAQgASgL" + "MgkuSXRlbUxpc3QSDwoHcmV0Y29kZRgLIAEoDRINCgVsZXZlbBgBIAEoDUIe" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakePrestigeRewardScRsp), TakePrestigeRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"Level"
			}, null, null, null, null)
		}));
	}
}
