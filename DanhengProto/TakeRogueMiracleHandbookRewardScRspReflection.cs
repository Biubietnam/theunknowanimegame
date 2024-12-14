using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200132E RID: 4910
	public static class TakeRogueMiracleHandbookRewardScRspReflection
	{
		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600DB20 RID: 56096 RVA: 0x002479D0 File Offset: 0x00245BD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return TakeRogueMiracleHandbookRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x0400573F RID: 22335
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilUYWtlUm9ndWVNaXJhY2xlSGFuZGJvb2tSZXdhcmRTY1JzcC5wcm90bxoO",
			"SXRlbUxpc3QucHJvdG8iZgojVGFrZVJvZ3VlTWlyYWNsZUhhbmRib29rUmV3",
			"YXJkU2NSc3ASGQoGcmV3YXJkGAEgASgLMgkuSXRlbUxpc3QSDwoHcmV0Y29k",
			"ZRgGIAEoDRITCgtQTUtOQk1JTUhPQRgOIAMoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueMiracleHandbookRewardScRsp), TakeRogueMiracleHandbookRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"PMKNBMIMHOA"
			}, null, null, null, null)
		}));
	}
}
