using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F46 RID: 3910
	public static class RogueModifierReflection
	{
		// Token: 0x1700313D RID: 12605
		// (get) Token: 0x0600AE82 RID: 44674 RVA: 0x001D5386 File Offset: 0x001D3586
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierReflection.descriptor;
			}
		}

		// Token: 0x04004707 RID: 18183
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNSb2d1ZU1vZGlmaWVyLnByb3RvGhxDaGVzc1JvZ3VlTW9kaWZpZXJJbmZv",
			"LnByb3RvGh1Sb2d1ZU1vZGlmaWVyU291cmNlVHlwZS5wcm90bxoaUm9ndWVN",
			"b2RpZmllckNvbnRlbnQucHJvdG8ixwEKDVJvZ3VlTW9kaWZpZXISHAoUbWFp",
			"bl9tb2RpZmllcl9lZmZlY3QYAiABKAQSLwoQbW9kaWZpZXJfY29udGVudBgG",
			"IAEoCzIVLlJvZ3VlTW9kaWZpZXJDb250ZW50EjYKFG1vZGlmaWVyX3NvdXJj",
			"ZV90eXBlGAggASgOMhguUm9ndWVNb2RpZmllclNvdXJjZVR5cGUSLwoNbW9k",
			"aWZpZXJfaW5mbxjHDiABKAsyFy5DaGVzc1JvZ3VlTW9kaWZpZXJJbmZvQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueModifierInfoReflection.Descriptor,
			RogueModifierSourceTypeReflection.Descriptor,
			RogueModifierContentReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifier), RogueModifier.Parser, new string[]
			{
				"MainModifierEffect",
				"ModifierContent",
				"ModifierSourceType",
				"ModifierInfo"
			}, null, null, null, null)
		}));
	}
}
