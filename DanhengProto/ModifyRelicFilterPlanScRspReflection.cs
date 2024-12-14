using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AFE RID: 2814
	public static class ModifyRelicFilterPlanScRspReflection
	{
		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06007C8A RID: 31882 RVA: 0x00149B42 File Offset: 0x00147D42
		public static FileDescriptor Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanScRspReflection.descriptor;
			}
		}

		// Token: 0x04002FDE RID: 12254
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBNb2RpZnlSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90bxodUmVsaWNGaWx0",
			"ZXJQbGFuU2V0dGluZ3MucHJvdG8aGVJlbGljRmlsdGVyUGxhbkljb24ucHJv",
			"dG8itwEKGk1vZGlmeVJlbGljRmlsdGVyUGxhblNjUnNwEhcKD1VwZGF0ZVRp",
			"bWVzdGFtcBgNIAEoAxIRCglTbG90SW5kZXgYDCABKA0SDwoHcmV0Y29kZRgP",
			"IAEoDRIMCgROYW1lGAIgASgJEiIKBEljb24YCCABKAsyFC5SZWxpY0ZpbHRl",
			"clBsYW5JY29uEioKCFNldHRpbmdzGA4gASgLMhguUmVsaWNGaWx0ZXJQbGFu",
			"U2V0dGluZ3NCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			RelicFilterPlanSettingsReflection.Descriptor,
			RelicFilterPlanIconReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ModifyRelicFilterPlanScRsp), ModifyRelicFilterPlanScRsp.Parser, new string[]
			{
				"UpdateTimestamp",
				"SlotIndex",
				"Retcode",
				"Name",
				"Icon",
				"Settings"
			}, null, null, null, null)
		}));
	}
}
