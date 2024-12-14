using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EF4 RID: 3828
	public static class RogueMagicQueryScRspReflection
	{
		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600AB01 RID: 43777 RVA: 0x001CCA2E File Offset: 0x001CAC2E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicQueryScRspReflection.descriptor;
			}
		}

		// Token: 0x040045CE RID: 17870
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljUXVlcnlTY1JzcC5wcm90bxoXUm9ndWVNYWdpY0N1cklu",
			"Zm8ucHJvdG8aF1JvZ3VlTWFnaWNHZXRJbmZvLnByb3RvIoUBChRSb2d1ZU1h",
			"Z2ljUXVlcnlTY1JzcBIwChRyb2d1ZV90b3Vybl9jdXJfaW5mbxgBIAEoCzIS",
			"LlJvZ3VlTWFnaWNDdXJJbmZvEioKDnJvZ3VlX2dldF9pbmZvGAMgASgLMhIu",
			"Um9ndWVNYWdpY0dldEluZm8SDwoHcmV0Y29kZRgPIAEoDUIeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicCurInfoReflection.Descriptor,
			RogueMagicGetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicQueryScRsp), RogueMagicQueryScRsp.Parser, new string[]
			{
				"RogueTournCurInfo",
				"RogueGetInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
