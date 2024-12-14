using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F58 RID: 3928
	public static class RogueModifierUpdateNotifyReflection
	{
		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600AF27 RID: 44839 RVA: 0x001D6CC6 File Offset: 0x001D4EC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierUpdateNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004748 RID: 18248
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZU1vZGlmaWVyVXBkYXRlTm90aWZ5LnByb3RvGhNSb2d1ZU1vZGlm" + "aWVyLnByb3RvIj0KGVJvZ3VlTW9kaWZpZXJVcGRhdGVOb3RpZnkSIAoIbW9k" + "aWZpZXIYDyABKAsyDi5Sb2d1ZU1vZGlmaWVyQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueModifierReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierUpdateNotify), RogueModifierUpdateNotify.Parser, new string[]
			{
				"Modifier"
			}, null, null, null, null)
		}));
	}
}
