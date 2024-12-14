using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200045C RID: 1116
	public static class EnterRogueScRspReflection
	{
		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x00088C33 File Offset: 0x00086E33
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterRogueScRspReflection.descriptor;
			}
		}

		// Token: 0x040013CB RID: 5067
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVFbnRlclJvZ3VlU2NSc3AucHJvdG8aD1JvZ3VlSW5mby5wcm90bxoPU2Nl",
			"bmVJbmZvLnByb3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aEExpbmV1",
			"cEluZm8ucHJvdG8iqQEKD0VudGVyUm9ndWVTY1JzcBIoCgtyb3RhdGVfaW5m",
			"bxgOIAEoCzITLlJvZ3VlTWFwUm90YXRlSW5mbxIbCgZsaW5ldXAYDCABKAsy",
			"Cy5MaW5ldXBJbmZvEiMKD3JvZ3VlX2dhbWVfaW5mbxgHIAEoCzIKLlJvZ3Vl",
			"SW5mbxIPCgdyZXRjb2RlGAsgASgNEhkKBXNjZW5lGAMgASgLMgouU2NlbmVJ",
			"bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueScRsp), EnterRogueScRsp.Parser, new string[]
			{
				"RotateInfo",
				"Lineup",
				"RogueGameInfo",
				"Retcode",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
