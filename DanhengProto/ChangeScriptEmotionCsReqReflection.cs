using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001CA RID: 458
	public static class ChangeScriptEmotionCsReqReflection
	{
		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0003B22D File Offset: 0x0003942D
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChangeScriptEmotionCsReqReflection.descriptor;
			}
		}

		// Token: 0x040008A1 RID: 2209
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DaGFuZ2VTY3JpcHRFbW90aW9uQ3NSZXEucHJvdG8aGkhlYXJ0RGlhbEVt",
			"b3Rpb25UeXBlLnByb3RvInYKGENoYW5nZVNjcmlwdEVtb3Rpb25Dc1JlcRIR",
			"CglzY3JpcHRfaWQYBiABKA0SMgoTdGFyZ2V0X2Vtb3Rpb25fdHlwZRgCIAEo",
			"DjIVLkhlYXJ0RGlhbEVtb3Rpb25UeXBlEhMKC0ZQUEVGQktCRkREGAcgASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			HeartDialEmotionTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChangeScriptEmotionCsReq), ChangeScriptEmotionCsReq.Parser, new string[]
			{
				"ScriptId",
				"TargetEmotionType",
				"FPPEFBKBFDD"
			}, null, null, null, null)
		}));
	}
}
