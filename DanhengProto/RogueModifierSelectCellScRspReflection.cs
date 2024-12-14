using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F52 RID: 3922
	public static class RogueModifierSelectCellScRspReflection
	{
		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600AEF7 RID: 44791 RVA: 0x001D6522 File Offset: 0x001D4722
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierSelectCellScRspReflection.descriptor;
			}
		}

		// Token: 0x0400472E RID: 18222
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZU1vZGlmaWVyU2VsZWN0Q2VsbFNjUnNwLnByb3RvGg5JdGVtTGlz",
			"dC5wcm90byJgChxSb2d1ZU1vZGlmaWVyU2VsZWN0Q2VsbFNjUnNwEh4KC0RL",
			"S0pPRUpOSUFLGA8gASgLMgkuSXRlbUxpc3QSDwoHY2VsbF9pZBgHIAEoDRIP",
			"CgdyZXRjb2RlGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierSelectCellScRsp), RogueModifierSelectCellScRsp.Parser, new string[]
			{
				"DKKJOEJNIAK",
				"CellId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
