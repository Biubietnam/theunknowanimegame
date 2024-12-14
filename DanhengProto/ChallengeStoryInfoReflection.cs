using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C0 RID: 448
	public static class ChallengeStoryInfoReflection
	{
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x00039EAC File Offset: 0x000380AC
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeStoryInfoReflection.descriptor;
			}
		}

		// Token: 0x04000877 RID: 2167
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDaGFsbGVuZ2VTdG9yeUluZm8ucHJvdG8aHENoYWxsZW5nZVN0b3J5QnVm",
			"Zkxpc3QucHJvdG8aG0NoYWxsZW5nZUJvc3NCdWZmTGlzdC5wcm90byJ2ChJD",
			"aGFsbGVuZ2VTdG9yeUluZm8SMAoPY3VyX3N0b3J5X2J1ZmZzGA4gASgLMhcu",
			"Q2hhbGxlbmdlU3RvcnlCdWZmTGlzdBIuCg5jdXJfYm9zc19idWZmcxgLIAEo",
			"CzIWLkNoYWxsZW5nZUJvc3NCdWZmTGlzdEIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChallengeStoryBuffListReflection.Descriptor,
			ChallengeBossBuffListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStoryInfo), ChallengeStoryInfo.Parser, new string[]
			{
				"CurStoryBuffs",
				"CurBossBuffs"
			}, null, null, null, null)
		}));
	}
}
