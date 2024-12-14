using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009C2 RID: 2498
	public static class KLMFIBACKFDReflection
	{
		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x00129975 File Offset: 0x00127B75
		public static FileDescriptor Descriptor
		{
			get
			{
				return KLMFIBACKFDReflection.descriptor;
			}
		}

		// Token: 0x04002ADB RID: 10971
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFLTE1GSUJBQ0tGRC5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5wcm90bxoZ",
			"Q2hhbGxlbmdlTGluZXVwTGlzdC5wcm90byLAAQoLS0xNRklCQUNLRkQSEAoI",
			"YnVmZl9vbmUYDyABKA0SJgoLcGxheWVyX2luZm8YCSABKAsyES5QbGF5ZXJT",
			"aW1wbGVJbmZvEhAKCGJ1ZmZfdHdvGA0gASgNEikKC2xpbmV1cF9saXN0GAQg",
			"AygLMhQuQ2hhbGxlbmdlTGluZXVwTGlzdBITCgtyZW1hcmtfbmFtZRgOIAEo",
			"CRIQCghzY29yZV9pZBgCIAEoDRITCgtQUE1LRE1JTkJOSBgMIAEoDUIeqgIb",
			"RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor,
			ChallengeLineupListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(KLMFIBACKFD), KLMFIBACKFD.Parser, new string[]
			{
				"BuffOne",
				"PlayerInfo",
				"BuffTwo",
				"LineupList",
				"RemarkName",
				"ScoreId",
				"PPMKDMINBNH"
			}, null, null, null, null)
		}));
	}
}
