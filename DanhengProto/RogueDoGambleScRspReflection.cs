using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E74 RID: 3700
	public static class RogueDoGambleScRspReflection
	{
		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600A516 RID: 42262 RVA: 0x001BBA91 File Offset: 0x001B9C91
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueDoGambleScRspReflection.descriptor;
			}
		}

		// Token: 0x0400436D RID: 17261
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZURvR2FtYmxlU2NSc3AucHJvdG8aFVJvZ3VlR2FtYmxlSW5mby5w",
			"cm90byJ2ChJSb2d1ZURvR2FtYmxlU2NSc3ASEwoLSUlES0lHRE5DS0cYDyAB",
			"KA0SDwoHcmV0Y29kZRgCIAEoDRITCgtERUlBRktORk1HTxgKIAEoDRIlCgtn",
			"YW1ibGVfaW5mbxgNIAEoCzIQLlJvZ3VlR2FtYmxlSW5mb0IeqgIbRWdnTGlu",
			"ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueGambleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueDoGambleScRsp), RogueDoGambleScRsp.Parser, new string[]
			{
				"IIDKIGDNCKG",
				"Retcode",
				"DEIAFKNFMGO",
				"GambleInfo"
			}, null, null, null, null)
		}));
	}
}
