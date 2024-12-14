using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FF6 RID: 4086
	public static class RogueTournPermanentTalentInfoReflection
	{
		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600B5D9 RID: 46553 RVA: 0x001E820E File Offset: 0x001E640E
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournPermanentTalentInfoReflection.descriptor;
			}
		}

		// Token: 0x040049C2 RID: 18882
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZVRvdXJuUGVybWFuZW50VGFsZW50SW5mby5wcm90bxoZUm9ndWVU",
			"YWxlbnRJbmZvTGlzdC5wcm90byJuCh1Sb2d1ZVRvdXJuUGVybWFuZW50VGFs",
			"ZW50SW5mbxIuChB0YWxlbnRfaW5mb19saXN0GAggASgLMhQuUm9ndWVUYWxl",
			"bnRJbmZvTGlzdBIdChV0b3Vybl90YWxlbnRfY29pbl9udW0YBCABKA1CHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTalentInfoListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournPermanentTalentInfo), RogueTournPermanentTalentInfo.Parser, new string[]
			{
				"TalentInfoList",
				"TournTalentCoinNum"
			}, null, null, null, null)
		}));
	}
}
