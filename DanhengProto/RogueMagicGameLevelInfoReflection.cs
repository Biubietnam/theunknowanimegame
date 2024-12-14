using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED4 RID: 3796
	public static class RogueMagicGameLevelInfoReflection
	{
		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600A9B1 RID: 43441 RVA: 0x001C9066 File Offset: 0x001C7266
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameLevelInfoReflection.descriptor;
			}
		}

		// Token: 0x04004543 RID: 17731
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZU1hZ2ljR2FtZUxldmVsSW5mby5wcm90bxocUm9ndWVNYWdpY1Nl",
			"dHRsZVJlYXNvbi5wcm90bxoZUm9ndWVNYWdpY0xheWVySW5mby5wcm90bxob",
			"Um9ndWVNYWdpY0xldmVsU3RhdHVzLnByb3RvIuIBChdSb2d1ZU1hZ2ljR2Ft",
			"ZUxldmVsSW5mbxInCgZyZWFzb24YAiABKA4yFy5Sb2d1ZU1hZ2ljU2V0dGxl",
			"UmVhc29uEiYKBnN0YXR1cxgPIAEoDjIWLlJvZ3VlTWFnaWNMZXZlbFN0YXR1",
			"cxITCgtMQUJHS01QTUJFRBgMIAEoDRIXCg9jdXJfbGV2ZWxfaW5kZXgYASAB",
			"KA0SGQoRZXh0cmFfcm91bmRfbGltaXQYByABKA0SLQoPbGV2ZWxfaW5mb19s",
			"aXN0GAggAygLMhQuUm9ndWVNYWdpY0xheWVySW5mb0IeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicSettleReasonReflection.Descriptor,
			RogueMagicLayerInfoReflection.Descriptor,
			RogueMagicLevelStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicGameLevelInfo), RogueMagicGameLevelInfo.Parser, new string[]
			{
				"Reason",
				"Status",
				"LABGKMPMBED",
				"CurLevelIndex",
				"ExtraRoundLimit",
				"LevelInfoList"
			}, null, null, null, null)
		}));
	}
}
