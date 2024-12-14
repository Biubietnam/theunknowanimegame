using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E22 RID: 3618
	public static class RogueBuffRerollCallbackReflection
	{
		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600A196 RID: 41366 RVA: 0x001B0FDE File Offset: 0x001AF1DE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBuffRerollCallbackReflection.descriptor;
			}
		}

		// Token: 0x04004219 RID: 16921
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZUJ1ZmZSZXJvbGxDYWxsYmFjay5wcm90bxofUm9ndWVDb21tb25C",
			"dWZmU2VsZWN0SW5mby5wcm90byJPChdSb2d1ZUJ1ZmZSZXJvbGxDYWxsYmFj",
			"axI0ChBidWZmX3NlbGVjdF9pbmZvGAMgASgLMhouUm9ndWVDb21tb25CdWZm",
			"U2VsZWN0SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonBuffSelectInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBuffRerollCallback), RogueBuffRerollCallback.Parser, new string[]
			{
				"BuffSelectInfo"
			}, null, null, null, null)
		}));
	}
}
