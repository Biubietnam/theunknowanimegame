using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F88 RID: 3976
	public static class RogueTournConfirmSettleScRspReflection
	{
		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600B116 RID: 45334 RVA: 0x001DB9F7 File Offset: 0x001D9BF7
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournConfirmSettleScRspReflection.descriptor;
			}
		}

		// Token: 0x04004808 RID: 18440
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZVRvdXJuQ29uZmlybVNldHRsZVNjUnNwLnByb3RvGhhSb2d1ZVRv",
			"dXJuU2F2ZUxpc3QucHJvdG8aHFJvZ3VlVG91cm5DdXJTY2VuZUluZm8ucHJv",
			"dG8aDkl0ZW1MaXN0LnByb3RvItYBChxSb2d1ZVRvdXJuQ29uZmlybVNldHRs",
			"ZVNjUnNwEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGAggASgLMhcu",
			"Um9ndWVUb3VybkN1clNjZW5lSW5mbxIeCgtIRUxIT0JOQUpJTBgHIAEoCzIJ",
			"Lkl0ZW1MaXN0Eh4KC05PTUdQQkFIRUdOGAogASgLMgkuSXRlbUxpc3QSKAoL",
			"R0pCR0JBQUtOUE4YCSABKAsyEy5Sb2d1ZVRvdXJuU2F2ZUxpc3QSDwoHcmV0",
			"Y29kZRgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournSaveListReflection.Descriptor,
			RogueTournCurSceneInfoReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournConfirmSettleScRsp), RogueTournConfirmSettleScRsp.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"HELHOBNAJIL",
				"NOMGPBAHEGN",
				"GJBGBAAKNPN",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
