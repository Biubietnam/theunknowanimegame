using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F26 RID: 3878
	public static class RogueMagicTalentInfoReflection
	{
		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600AD10 RID: 44304 RVA: 0x001D19BA File Offset: 0x001CFBBA
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicTalentInfoReflection.descriptor;
			}
		}

		// Token: 0x04004681 RID: 18049
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpSb2d1ZU1hZ2ljVGFsZW50SW5mby5wcm90bxoZUm9ndWVUYWxlbnRJbmZv",
			"TGlzdC5wcm90byJhChRSb2d1ZU1hZ2ljVGFsZW50SW5mbxIZChFtYWdpY190",
			"YWxlbnRfY29pbhgGIAEoDRIuChB0YWxlbnRfaW5mb19saXN0GAogASgLMhQu",
			"Um9ndWVUYWxlbnRJbmZvTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicTalentInfo), RogueMagicTalentInfo.Parser, new string[]
			{
				"MagicTalentCoin",
				"TalentInfoList"
			}, null, null, null, null)
		}));
	}
}
