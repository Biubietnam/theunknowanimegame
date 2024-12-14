using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E42 RID: 3650
	public static class RogueCommonDialogueDataInfoReflection
	{
		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600A2D3 RID: 41683 RVA: 0x001B5E7D File Offset: 0x001B407D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueDataInfoReflection.descriptor;
			}
		}

		// Token: 0x040042B2 RID: 17074
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YUluZm8ucHJvdG8aI1JvZ3VlQ29t",
			"bW9uRGlhbG9ndWVPcHRpb25JbmZvLnByb3RvGh1Sb2d1ZUNvbW1vbkRpYWxv",
			"Z3VlSW5mby5wcm90byKcAQobUm9ndWVDb21tb25EaWFsb2d1ZURhdGFJbmZv",
			"EhcKD2V2ZW50X3VuaXF1ZV9pZBgBIAEoDRIvCg1kaWFsb2d1ZV9pbmZvGAog",
			"ASgLMhguUm9ndWVDb21tb25EaWFsb2d1ZUluZm8SMwoLb3B0aW9uX2xpc3QY",
			"DiADKAsyHi5Sb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uSW5mb0IeqgIbRWdn",
			"TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonDialogueOptionInfoReflection.Descriptor,
			RogueCommonDialogueInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDialogueDataInfo), RogueCommonDialogueDataInfo.Parser, new string[]
			{
				"EventUniqueId",
				"DialogueInfo",
				"OptionList"
			}, null, null, null, null)
		}));
	}
}
