using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B2 RID: 1970
	public static class GetRogueCommonDialogueDataScRspReflection
	{
		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060057F3 RID: 22515 RVA: 0x000EB422 File Offset: 0x000E9622
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetRogueCommonDialogueDataScRspReflection.descriptor;
			}
		}

		// Token: 0x0400224E RID: 8782
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVHZXRSb2d1ZUNvbW1vbkRpYWxvZ3VlRGF0YVNjUnNwLnByb3RvGiFSb2d1",
			"ZUNvbW1vbkRpYWxvZ3VlRGF0YUluZm8ucHJvdG8ibAofR2V0Um9ndWVDb21t",
			"b25EaWFsb2d1ZURhdGFTY1JzcBIPCgdyZXRjb2RlGAUgASgNEjgKEmRpYWxv",
			"Z3VlX2RhdGFfbGlzdBgHIAMoCzIcLlJvZ3VlQ29tbW9uRGlhbG9ndWVEYXRh",
			"SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueCommonDialogueDataInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueCommonDialogueDataScRsp), GetRogueCommonDialogueDataScRsp.Parser, new string[]
			{
				"Retcode",
				"DialogueDataList"
			}, null, null, null, null)
		}));
	}
}
