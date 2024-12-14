using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101E RID: 4126
	public static class RogueTournStartScRspReflection
	{
		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x001EC52D File Offset: 0x001EA72D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournStartScRspReflection.descriptor;
			}
		}

		// Token: 0x04004A57 RID: 19031
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZVRvdXJuU3RhcnRTY1JzcC5wcm90bxoXUm9ndWVUb3VybkN1cklu",
			"Zm8ucHJvdG8aHFJvZ3VlVG91cm5DdXJTY2VuZUluZm8ucHJvdG8ipAEKFFJv",
			"Z3VlVG91cm5TdGFydFNjUnNwEjAKFHJvZ3VlX3RvdXJuX2N1cl9pbmZvGAEg",
			"ASgLMhIuUm9ndWVUb3VybkN1ckluZm8SDwoHcmV0Y29kZRgNIAEoDRI7Chpy",
			"b2d1ZV90b3Vybl9jdXJfc2NlbmVfaW5mbxgKIAEoCzIXLlJvZ3VlVG91cm5D",
			"dXJTY2VuZUluZm8SDAoEd2VlaxgPIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournCurInfoReflection.Descriptor,
			RogueTournCurSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournStartScRsp), RogueTournStartScRsp.Parser, new string[]
			{
				"RogueTournCurInfo",
				"Retcode",
				"RogueTournCurSceneInfo",
				"Week"
			}, null, null, null, null)
		}));
	}
}
