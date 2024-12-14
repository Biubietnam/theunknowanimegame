using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F48 RID: 3912
	public static class RogueModifierAddNotifyReflection
	{
		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x0600AE9D RID: 44701 RVA: 0x001D5909 File Offset: 0x001D3B09
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierAddNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004712 RID: 18194
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU1vZGlmaWVyQWRkTm90aWZ5LnByb3RvGhNSb2d1ZU1vZGlmaWVy" + "LnByb3RvIjoKFlJvZ3VlTW9kaWZpZXJBZGROb3RpZnkSIAoIbW9kaWZpZXIY" + "BSABKAsyDi5Sb2d1ZU1vZGlmaWVyQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueModifierReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierAddNotify), RogueModifierAddNotify.Parser, new string[]
			{
				"Modifier"
			}, null, null, null, null)
		}));
	}
}
