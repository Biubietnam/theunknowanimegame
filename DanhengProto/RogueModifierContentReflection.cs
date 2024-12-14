using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F4A RID: 3914
	public static class RogueModifierContentReflection
	{
		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600AEB2 RID: 44722 RVA: 0x001D5BCD File Offset: 0x001D3DCD
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierContentReflection.descriptor;
			}
		}

		// Token: 0x04004717 RID: 18199
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1vZGlmaWVyQ29udGVudC5wcm90bxoeUm9ndWVNb2RpZmllckNv",
			"bnRlbnRUeXBlLnByb3RvIokBChRSb2d1ZU1vZGlmaWVyQ29udGVudBIiChpj",
			"b250ZW50X21vZGlmaWVyX2VmZmVjdF9pZBgDIAEoDRI4ChVtb2RpZmllcl9j",
			"b250ZW50X3R5cGUYByABKA4yGS5Sb2d1ZU1vZGlmaWVyQ29udGVudFR5cGUS",
			"EwoLR0ZETkVKTFBDTUIYDiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueModifierContentTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierContent), RogueModifierContent.Parser, new string[]
			{
				"ContentModifierEffectId",
				"ModifierContentType",
				"GFDNEJLPCMB"
			}, null, null, null, null)
		}));
	}
}
