using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FAE RID: 4014
	public static class RogueTournEnterScRspReflection
	{
		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600B2E5 RID: 45797 RVA: 0x001E0994 File Offset: 0x001DEB94
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterScRspReflection.descriptor;
			}
		}

		// Token: 0x040048AB RID: 18603
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuRW50ZXJTY1JzcC5wcm90bxoXUm9ndWVUb3VybkN1cklu",
			"Zm8ucHJvdG8aHFJvZ3VlVG91cm5DdXJTY2VuZUluZm8ucHJvdG8ilgEKFFJv",
			"Z3VlVG91cm5FbnRlclNjUnNwEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9p",
			"bmZvGAMgASgLMhcuUm9ndWVUb3VybkN1clNjZW5lSW5mbxIwChRyb2d1ZV90",
			"b3Vybl9jdXJfaW5mbxgPIAEoCzISLlJvZ3VlVG91cm5DdXJJbmZvEg8KB3Jl",
			"dGNvZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournCurInfoReflection.Descriptor,
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournEnterScRsp), RogueTournEnterScRsp.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"RogueTournCurInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
