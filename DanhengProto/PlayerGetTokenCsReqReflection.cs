using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB8 RID: 3256
	public static class PlayerGetTokenCsReqReflection
	{
		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x0017F602 File Offset: 0x0017D802
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerGetTokenCsReqReflection.descriptor;
			}
		}

		// Token: 0x040037CD RID: 14285
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlQbGF5ZXJHZXRUb2tlbkNzUmVxLnByb3RvIqYBChNQbGF5ZXJHZXRUb2tl",
			"bkNzUmVxEhIKCmNoYW5uZWxfaWQYAiABKA0SEwoLYWNjb3VudF91aWQYDyAB",
			"KAkSEAoIcGxhdGZvcm0YCyABKA0SEwoLSklPUE1GTlBCTlAYDCABKA0SEwoL",
			"Q0dFR09MTE1IQ0oYASABKA0SCwoDdWlkGAogASgNEg0KBXRva2VuGAYgASgJ",
			"Eg4KBmRldmljZRgFIAEoCUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerGetTokenCsReq), PlayerGetTokenCsReq.Parser, new string[]
			{
				"ChannelId",
				"AccountUid",
				"Platform",
				"JIOPMFNPBNP",
				"CGEGOLLMHCJ",
				"Uid",
				"Token",
				"Device"
			}, null, null, null, null)
		}));
	}
}
