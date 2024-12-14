using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4A RID: 3658
	public static class RogueCommonDialogueOptionInfoReflection
	{
		// Token: 0x17002E18 RID: 11800
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x001B70B9 File Offset: 0x001B52B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionInfoReflection.descriptor;
			}
		}

		// Token: 0x040042D7 RID: 17111
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uSW5mby5wcm90bxoqUm9ndWVD",
			"b21tb25EaWFsb2d1ZU9wdGlvbkRpc3BsYXlJbmZvLnByb3RvGilSb2d1ZUNv",
			"bW1vbkRpYWxvZ3VlT3B0aW9uUmVzdWx0SW5mby5wcm90byLlAQodUm9ndWVD",
			"b21tb25EaWFsb2d1ZU9wdGlvbkluZm8SEQoJb3B0aW9uX2lkGAcgASgNEg4K",
			"BmFyZ19pZBgIIAEoDRIQCghpc192YWxpZBgGIAEoCBI8Cg1kaXNwbGF5X3Zh",
			"bHVlGAkgASgLMiUuUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkRpc3BsYXlJ",
			"bmZvEkAKEm9wdGlvbl9yZXN1bHRfaW5mbxgEIAMoCzIkLlJvZ3VlQ29tbW9u",
			"RGlhbG9ndWVPcHRpb25SZXN1bHRJbmZvEg8KB2NvbmZpcm0YBSABKAhCHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonDialogueOptionDisplayInfoReflection.Descriptor,
			RogueCommonDialogueOptionResultInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonDialogueOptionInfo), RogueCommonDialogueOptionInfo.Parser, new string[]
			{
				"OptionId",
				"ArgId",
				"IsValid",
				"DisplayValue",
				"OptionResultInfo",
				"Confirm"
			}, null, null, null, null)
		}));
	}
}
