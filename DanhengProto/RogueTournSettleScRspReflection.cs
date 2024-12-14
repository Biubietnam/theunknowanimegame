using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101A RID: 4122
	public static class RogueTournSettleScRspReflection
	{
		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x001EBBAF File Offset: 0x001E9DAF
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournSettleScRspReflection.descriptor;
			}
		}

		// Token: 0x04004A41 RID: 19009
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZVRvdXJuU2V0dGxlU2NSc3AucHJvdG8aGlJvZ3VlVG91cm5GaW5p",
			"c2hJbmZvLnByb3RvGhxSb2d1ZVRvdXJuQ3VyU2NlbmVJbmZvLnByb3RvIpcB",
			"ChVSb2d1ZVRvdXJuU2V0dGxlU2NSc3ASMAoRdG91cm5fZmluaXNoX2luZm8Y",
			"AyABKAsyFS5Sb2d1ZVRvdXJuRmluaXNoSW5mbxIPCgdyZXRjb2RlGAIgASgN",
			"EjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9pbmZvGA0gASgLMhcuUm9ndWVU",
			"b3VybkN1clNjZW5lSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournFinishInfoReflection.Descriptor,
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournSettleScRsp), RogueTournSettleScRsp.Parser, new string[]
			{
				"TournFinishInfo",
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
