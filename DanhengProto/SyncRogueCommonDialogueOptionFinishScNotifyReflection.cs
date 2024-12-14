using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001286 RID: 4742
	public static class SyncRogueCommonDialogueOptionFinishScNotifyReflection
	{
		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600D397 RID: 54167 RVA: 0x00235050 File Offset: 0x00233250
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueOptionFinishScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054B4 RID: 21684
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CjFTeW5jUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlvbkZpbmlzaFNjTm90aWZ5",
			"LnByb3RvGiNSb2d1ZUNvbW1vbkRpYWxvZ3VlT3B0aW9uSW5mby5wcm90bxoh",
			"Um9ndWVDb21tb25EaWFsb2d1ZURhdGFJbmZvLnByb3RvIsoBCitTeW5jUm9n",
			"dWVDb21tb25EaWFsb2d1ZU9wdGlvbkZpbmlzaFNjTm90aWZ5EhcKD2V2ZW50",
			"X3VuaXF1ZV9pZBgHIAEoDRIRCglvcHRpb25faWQYAyABKA0SOgoScmVzdWx0",
			"X29wdGlvbl9pbmZvGAQgASgLMh4uUm9ndWVDb21tb25EaWFsb2d1ZU9wdGlv",
			"bkluZm8SMwoNZGlhbG9ndWVfZGF0YRgLIAEoCzIcLlJvZ3VlQ29tbW9uRGlh",
			"bG9ndWVEYXRhSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonDialogueOptionInfoReflection.Descriptor,
			RogueCommonDialogueDataInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonDialogueOptionFinishScNotify), SyncRogueCommonDialogueOptionFinishScNotify.Parser, new string[]
			{
				"EventUniqueId",
				"OptionId",
				"ResultOptionInfo",
				"DialogueData"
			}, null, null, null, null)
		}));
	}
}
