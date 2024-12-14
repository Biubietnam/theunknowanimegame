using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C36 RID: 3126
	public static class NpcRogueGameInfoReflection
	{
		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x06008A94 RID: 35476 RVA: 0x0016DE78 File Offset: 0x0016C078
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcRogueGameInfoReflection.descriptor;
			}
		}

		// Token: 0x04003521 RID: 13601
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZOcGNSb2d1ZUdhbWVJbmZvLnByb3RvGhtOcGNEaWFsb2d1ZUV2ZW50UGFy",
			"YW0ucHJvdG8i2wIKEE5wY1JvZ3VlR2FtZUluZm8SNwoLTEZFUEJBSk9DUEUY",
			"AiADKAsyIi5OcGNSb2d1ZUdhbWVJbmZvLkxGRVBCQUpPQ1BFRW50cnkSFAoM",
			"YWVvbl90YWxrX2lkGAQgASgNEhcKD2ZpbmlzaF9kaWFsb2d1ZRgDIAEoCBIT",
			"CgtMQ1BNUE9LSEFFShgOIAEoDRITCgtOSEpKS0xCS0NPShgJIAEoCBI5Chlk",
			"aWFsb2d1ZV9ldmVudF9wYXJhbV9saXN0GAUgAygLMhYuTnBjRGlhbG9ndWVF",
			"dmVudFBhcmFtEhMKC0pFSkNBRkhGSkZKGA8gASgIEhgKEHRhbGtfZGlhbG9n",
			"dWVfaWQYBiABKA0SFwoPZXZlbnRfdW5pcXVlX2lkGAwgASgNGjIKEExGRVBC",
			"QUpPQ1BFRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			NpcDialogueEventParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcRogueGameInfo), NpcRogueGameInfo.Parser, new string[]
			{
				"LFEPBAJOCPE",
				"AeonTalkId",
				"FinishDialogue",
				"LCPMPOKHAEJ",
				"NHJJKLBKCOJ",
				"DialogueEventParamList",
				"JEJCAFHFJFJ",
				"TalkDialogueId",
				"EventUniqueId"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
