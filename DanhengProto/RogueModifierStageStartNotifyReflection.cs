using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F56 RID: 3926
	public static class RogueModifierStageStartNotifyReflection
	{
		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x001D6A2A File Offset: 0x001D4C2A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueModifierStageStartNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004743 RID: 18243
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZU1vZGlmaWVyU3RhZ2VTdGFydE5vdGlmeS5wcm90bxodUm9ndWVN",
			"b2RpZmllclNvdXJjZVR5cGUucHJvdG8iVwodUm9ndWVNb2RpZmllclN0YWdl",
			"U3RhcnROb3RpZnkSNgoUbW9kaWZpZXJfc291cmNlX3R5cGUYAiABKA4yGC5S",
			"b2d1ZU1vZGlmaWVyU291cmNlVHlwZUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
			"dmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueModifierSourceTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierStageStartNotify), RogueModifierStageStartNotify.Parser, new string[]
			{
				"ModifierSourceType"
			}, null, null, null, null)
		}));
	}
}
