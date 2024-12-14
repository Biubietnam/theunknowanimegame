using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E00 RID: 3584
	public static class RogueArcadeRestartScRspReflection
	{
		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600A048 RID: 41032 RVA: 0x001AE0F6 File Offset: 0x001AC2F6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueArcadeRestartScRspReflection.descriptor;
			}
		}

		// Token: 0x040041AA RID: 16810
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZUFyY2FkZVJlc3RhcnRTY1JzcC5wcm90bxoRSUtFTkFBSkRBRkYu",
			"cHJvdG8iXAoXUm9ndWVBcmNhZGVSZXN0YXJ0U2NSc3ASDwoHcmV0Y29kZRgP",
			"IAEoDRIwChpyb2d1ZV90b3Vybl9jdXJfc2NlbmVfaW5mbxgFIAEoCzIMLklL",
			"RU5BQUpEQUZGQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			IKENAAJDAFFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeRestartScRsp), RogueArcadeRestartScRsp.Parser, new string[]
			{
				"Retcode",
				"RogueTournCurSceneInfo"
			}, null, null, null, null)
		}));
	}
}
