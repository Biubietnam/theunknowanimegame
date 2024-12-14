using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000240 RID: 576
	public static class ChessRogueLineupInfoReflection
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0004B929 File Offset: 0x00049B29
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueLineupInfoReflection.descriptor;
			}
		}

		// Token: 0x04000B12 RID: 2834
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlTGluZXVwSW5mby5wcm90bxogQ2hlc3NSb2d1ZUxpbmV1",
			"cEF2YXRhckluZm8ucHJvdG8aG1JvZ3VlQXZhdGFyUmV2aXZlQ29zdC5wcm90",
			"byJ7ChRDaGVzc1JvZ3VlTGluZXVwSW5mbxI2ChFjaGVzc19hdmF0YXJfbGlz",
			"dBgJIAMoCzIbLkNoZXNzUm9ndWVMaW5ldXBBdmF0YXJJbmZvEisKC3Jldml2",
			"ZV9pbmZvGA4gASgLMhYuUm9ndWVBdmF0YXJSZXZpdmVDb3N0Qh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueLineupAvatarInfoReflection.Descriptor,
			RogueAvatarReviveCostReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLineupInfo), ChessRogueLineupInfo.Parser, new string[]
			{
				"ChessAvatarList",
				"ReviveInfo"
			}, null, null, null, null)
		}));
	}
}
