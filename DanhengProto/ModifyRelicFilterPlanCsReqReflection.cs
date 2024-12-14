using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AFC RID: 2812
	public static class ModifyRelicFilterPlanCsReqReflection
	{
		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x001495B6 File Offset: 0x001477B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002FD3 RID: 12243
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBNb2RpZnlSZWxpY0ZpbHRlclBsYW5Dc1JlcS5wcm90bxodUmVsaWNGaWx0",
			"ZXJQbGFuU2V0dGluZ3MucHJvdG8aGVJlbGljRmlsdGVyUGxhbkljb24ucHJv",
			"dG8ijQEKGk1vZGlmeVJlbGljRmlsdGVyUGxhbkNzUmVxEhEKCVNsb3RJbmRl",
			"eBgHIAEoDRIMCgROYW1lGAUgASgJEiIKBEljb24YASABKAsyFC5SZWxpY0Zp",
			"bHRlclBsYW5JY29uEioKCFNldHRpbmdzGA8gASgLMhguUmVsaWNGaWx0ZXJQ",
			"bGFuU2V0dGluZ3NCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RelicFilterPlanSettingsReflection.Descriptor,
			RelicFilterPlanIconReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ModifyRelicFilterPlanCsReq), ModifyRelicFilterPlanCsReq.Parser, new string[]
			{
				"SlotIndex",
				"Name",
				"Icon",
				"Settings"
			}, null, null, null, null)
		}));
	}
}
