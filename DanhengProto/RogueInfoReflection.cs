using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA6 RID: 3750
	public static class RogueInfoReflection
	{
		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0600A78F RID: 42895 RVA: 0x001C338A File Offset: 0x001C158A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueInfoReflection.descriptor;
			}
		}

		// Token: 0x0400447F RID: 17535
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Cg9Sb2d1ZUluZm8ucHJvdG8aElJvZ3VlR2V0SW5mby5wcm90bxoWUm9ndWVD",
			"dXJyZW50SW5mby5wcm90byJjCglSb2d1ZUluZm8SLgoScm9ndWVfY3VycmVu",
			"dF9pbmZvGN8EIAEoCzIRLlJvZ3VlQ3VycmVudEluZm8SJgoOcm9ndWVfZ2V0",
			"X2luZm8YqwUgASgLMg0uUm9ndWVHZXRJbmZvQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueGetInfoReflection.Descriptor,
			RogueCurrentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueInfo), RogueInfo.Parser, new string[]
			{
				"RogueCurrentInfo",
				"RogueGetInfo"
			}, null, null, null, null)
		}));
	}
}
