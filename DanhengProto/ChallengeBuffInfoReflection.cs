using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001A4 RID: 420
	public static class ChallengeBuffInfoReflection
	{
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00036D88 File Offset: 0x00034F88
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x04000806 RID: 2054
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdDaGFsbGVuZ2VCdWZmSW5mby5wcm90bxocQ2hhbGxlbmdlU3RvcnlCdWZm",
			"SW5mby5wcm90bxobQ2hhbGxlbmdlQm9zc0J1ZmZJbmZvLnByb3RvImsKEUNo",
			"YWxsZW5nZUJ1ZmZJbmZvEisKCnN0b3J5X2luZm8YBCABKAsyFy5DaGFsbGVu",
			"Z2VTdG9yeUJ1ZmZJbmZvEikKCWJvc3NfaW5mbxgDIAEoCzIWLkNoYWxsZW5n",
			"ZUJvc3NCdWZmSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChallengeStoryBuffInfoReflection.Descriptor,
			ChallengeBossBuffInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBuffInfo), ChallengeBuffInfo.Parser, new string[]
			{
				"StoryInfo",
				"BossInfo"
			}, null, null, null, null)
		}));
	}
}
