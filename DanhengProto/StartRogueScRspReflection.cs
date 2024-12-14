using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C6 RID: 4550
	public static class StartRogueScRspReflection
	{
		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600CB57 RID: 52055 RVA: 0x00221BA1 File Offset: 0x0021FDA1
		public static FileDescriptor Descriptor
		{
			get
			{
				return StartRogueScRspReflection.descriptor;
			}
		}

		// Token: 0x04005208 RID: 21000
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVTdGFydFJvZ3VlU2NSc3AucHJvdG8aD1JvZ3VlSW5mby5wcm90bxoPU2Nl",
			"bmVJbmZvLnByb3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aEExpbmV1",
			"cEluZm8ucHJvdG8iqQEKD1N0YXJ0Um9ndWVTY1JzcBIbCgZsaW5ldXAYCyAB",
			"KAsyCy5MaW5ldXBJbmZvEigKC3JvdGF0ZV9pbmZvGA4gASgLMhMuUm9ndWVN",
			"YXBSb3RhdGVJbmZvEg8KB3JldGNvZGUYBCABKA0SGQoFc2NlbmUYBiABKAsy",
			"Ci5TY2VuZUluZm8SIwoPcm9ndWVfZ2FtZV9pbmZvGA8gASgLMgouUm9ndWVJ",
			"bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StartRogueScRsp), StartRogueScRsp.Parser, new string[]
			{
				"Lineup",
				"RotateInfo",
				"Retcode",
				"Scene",
				"RogueGameInfo"
			}, null, null, null, null)
		}));
	}
}
