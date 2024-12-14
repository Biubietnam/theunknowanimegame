using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001284 RID: 4740
	public static class SyncRogueCommonDialogueDataScNotifyReflection
	{
		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600D383 RID: 54147 RVA: 0x00234DB6 File Offset: 0x00232FB6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueDataScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054AE RID: 21678
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilTeW5jUm9ndWVDb21tb25EaWFsb2d1ZURhdGFTY05vdGlmeS5wcm90bxoh",
			"Um9ndWVDb21tb25EaWFsb2d1ZURhdGFJbmZvLnByb3RvIl8KI1N5bmNSb2d1",
			"ZUNvbW1vbkRpYWxvZ3VlRGF0YVNjTm90aWZ5EjgKEmRpYWxvZ3VlX2RhdGFf",
			"bGlzdBgGIAMoCzIcLlJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRhSW5mb0IeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonDialogueDataInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonDialogueDataScNotify), SyncRogueCommonDialogueDataScNotify.Parser, new string[]
			{
				"DialogueDataList"
			}, null, null, null, null)
		}));
	}
}
