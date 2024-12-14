using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F1C RID: 3868
	public static class RogueMagicSettleScRspReflection
	{
		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x0600AC98 RID: 44184 RVA: 0x001D04AF File Offset: 0x001CE6AF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicSettleScRspReflection.descriptor;
			}
		}

		// Token: 0x04004653 RID: 18003
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZU1hZ2ljU2V0dGxlU2NSc3AucHJvdG8aGlJvZ3VlTWFnaWNGaW5p",
			"c2hJbmZvLnByb3RvGhFKTkRNS0hJQkNQSi5wcm90bxocUm9ndWVNYWdpY0N1",
			"clNjZW5lSW5mby5wcm90bxoOSXRlbUxpc3QucHJvdG8i2gEKFVJvZ3VlTWFn",
			"aWNTZXR0bGVTY1JzcBIeCgtIRUxIT0JOQUpJTBgJIAEoCzIJLkl0ZW1MaXN0",
			"EjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGAQgASgLMhcuUm9ndWVN",
			"YWdpY0N1clNjZW5lSW5mbxIwChF0b3Vybl9maW5pc2hfaW5mbxgIIAEoCzIV",
			"LlJvZ3VlTWFnaWNGaW5pc2hJbmZvEiEKC0VIUE1CRENBSVBFGA8gASgLMgwu",
			"Sk5ETUtISUJDUEoSDwoHcmV0Y29kZRgGIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicFinishInfoReflection.Descriptor,
			JNDMKHIBCPJReflection.Descriptor,
			RogueMagicCurSceneInfoReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicSettleScRsp), RogueMagicSettleScRsp.Parser, new string[]
			{
				"HELHOBNAJIL",
				"RogueTournCurSceneInfo",
				"TournFinishInfo",
				"EHPMBDCAIPE",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
