using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F5A RID: 3930
	public static class RogueModuleInfoReflection
	{
		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x001D6F8D File Offset: 0x001D518D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModuleInfoReflection.descriptor;
			}
		}

		// Token: 0x0400474D RID: 18253
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVSb2d1ZU1vZHVsZUluZm8ucHJvdG8iKQoPUm9ndWVNb2R1bGVJbmZvEhYK" + "Dm1vZHVsZV9pZF9saXN0GAcgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModuleInfo), RogueModuleInfo.Parser, new string[]
			{
				"ModuleIdList"
			}, null, null, null, null)
		}));
	}
}
