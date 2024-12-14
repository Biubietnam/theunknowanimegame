using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A00 RID: 2560
	public static class LeaveRogueScRspReflection
	{
		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x0012E4B6 File Offset: 0x0012C6B6
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveRogueScRspReflection.descriptor;
			}
		}

		// Token: 0x04002BAE RID: 11182
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVMZWF2ZVJvZ3VlU2NSc3AucHJvdG8aD1JvZ3VlSW5mby5wcm90bxoPU2Nl",
			"bmVJbmZvLnByb3RvGhhSb2d1ZU1hcFJvdGF0ZUluZm8ucHJvdG8aEExpbmV1",
			"cEluZm8ucHJvdG8iqQEKD0xlYXZlUm9ndWVTY1JzcBIoCgtyb3RhdGVfaW5m",
			"bxgHIAEoCzITLlJvZ3VlTWFwUm90YXRlSW5mbxIjCg9yb2d1ZV9nYW1lX2lu",
			"Zm8YDCABKAsyCi5Sb2d1ZUluZm8SGwoGbGluZXVwGAsgASgLMgsuTGluZXVw",
			"SW5mbxIPCgdyZXRjb2RlGAogASgNEhkKBXNjZW5lGA4gASgLMgouU2NlbmVJ",
			"bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor,
			RogueMapRotateInfoReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRogueScRsp), LeaveRogueScRsp.Parser, new string[]
			{
				"RotateInfo",
				"RogueGameInfo",
				"Lineup",
				"Retcode",
				"Scene"
			}, null, null, null, null)
		}));
	}
}
