using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECC RID: 3788
	public static class RogueMagicEnterScRspReflection
	{
		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0600A950 RID: 43344 RVA: 0x001C7E60 File Offset: 0x001C6060
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterScRspReflection.descriptor;
			}
		}

		// Token: 0x0400451C RID: 17692
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljRW50ZXJTY1JzcC5wcm90bxocUm9ndWVNYWdpY0N1clNj",
			"ZW5lSW5mby5wcm90bxoXUm9ndWVNYWdpY0N1ckluZm8ucHJvdG8ilgEKFFJv",
			"Z3VlTWFnaWNFbnRlclNjUnNwEjsKGnJvZ3VlX3RvdXJuX2N1cl9zY2VuZV9p",
			"bmZvGAIgASgLMhcuUm9ndWVNYWdpY0N1clNjZW5lSW5mbxIwChRyb2d1ZV90",
			"b3Vybl9jdXJfaW5mbxgOIAEoCzISLlJvZ3VlTWFnaWNDdXJJbmZvEg8KB3Jl",
			"dGNvZGUYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicCurSceneInfoReflection.Descriptor,
			RogueMagicCurInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicEnterScRsp), RogueMagicEnterScRsp.Parser, new string[]
			{
				"RogueTournCurSceneInfo",
				"RogueTournCurInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
