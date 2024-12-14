using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011BA RID: 4538
	public static class StartPartialChallengeScRspReflection
	{
		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600CAB6 RID: 51894 RVA: 0x0021FC20 File Offset: 0x0021DE20
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartPartialChallengeScRspReflection.descriptor;
			}
		}

		// Token: 0x040051BD RID: 20925
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiBTdGFydFBhcnRpYWxDaGFsbGVuZ2VTY1JzcC5wcm90bxoPU2NlbmVJbmZv",
			"LnByb3RvGhJDdXJDaGFsbGVuZ2UucHJvdG8aEExpbmV1cEluZm8ucHJvdG8i",
			"iwEKGlN0YXJ0UGFydGlhbENoYWxsZW5nZVNjUnNwEhsKBmxpbmV1cBgKIAEo",
			"CzILLkxpbmV1cEluZm8SGQoFc2NlbmUYCSABKAsyCi5TY2VuZUluZm8SDwoH",
			"cmV0Y29kZRgIIAEoDRIkCg1jdXJfY2hhbGxlbmdlGAsgASgLMg0uQ3VyQ2hh",
			"bGxlbmdlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor,
			CurChallengeReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartPartialChallengeScRsp), StartPartialChallengeScRsp.Parser, new string[]
			{
				"Lineup",
				"Scene",
				"Retcode",
				"CurChallenge"
			}, null, null, null, null)
		}));
	}
}
