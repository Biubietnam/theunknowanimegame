using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008A2 RID: 2210
	public static class HeartDialScriptInfoReflection
	{
		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06006298 RID: 25240 RVA: 0x00107E2E File Offset: 0x0010602E
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeartDialScriptInfoReflection.descriptor;
			}
		}

		// Token: 0x040025EB RID: 9707
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlIZWFydERpYWxTY3JpcHRJbmZvLnByb3RvGhpIZWFydERpYWxFbW90aW9u",
			"VHlwZS5wcm90bxoXSGVhcnREaWFsU3RlcFR5cGUucHJvdG8ipQEKE0hlYXJ0",
			"RGlhbFNjcmlwdEluZm8SEwoLTENPQUdOSkJDS0cYBCABKAgSEwoLR0dGS0VJ",
			"SkpMQ0UYDyABKAgSEQoJc2NyaXB0X2lkGAcgASgNEiAKBHN0ZXAYCiABKA4y",
			"Ei5IZWFydERpYWxTdGVwVHlwZRIvChBjdXJfZW1vdGlvbl90eXBlGA4gASgO",
			"MhUuSGVhcnREaWFsRW1vdGlvblR5cGVCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			HeartDialEmotionTypeReflection.Descriptor,
			HeartDialStepTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialScriptInfo), HeartDialScriptInfo.Parser, new string[]
			{
				"LCOAGNJBCKG",
				"GGFKEIJJLCE",
				"ScriptId",
				"Step",
				"CurEmotionType"
			}, null, null, null, null)
		}));
	}
}
