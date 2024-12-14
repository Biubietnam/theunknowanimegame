using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E38 RID: 3640
	public static class RogueCommonBuffReforgeSelectInfoReflection
	{
		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x0600A265 RID: 41573 RVA: 0x001B48B5 File Offset: 0x001B2AB5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonBuffReforgeSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x04004277 RID: 17015
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZSb2d1ZUNvbW1vbkJ1ZmZSZWZvcmdlU2VsZWN0SW5mby5wcm90bxoVUm9n",
			"dWVDb21tb25CdWZmLnByb3RvImIKIFJvZ3VlQ29tbW9uQnVmZlJlZm9yZ2VT",
			"ZWxlY3RJbmZvEiYKDHNlbGVjdF9idWZmcxgBIAMoCzIQLlJvZ3VlQ29tbW9u",
			"QnVmZhIWCg5zZWxlY3RfaGludF9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonBuffReforgeSelectInfo), RogueCommonBuffReforgeSelectInfo.Parser, new string[]
			{
				"SelectBuffs",
				"SelectHintId"
			}, null, null, null, null)
		}));
	}
}
