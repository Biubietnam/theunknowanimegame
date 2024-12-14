using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001154 RID: 4436
	public static class SkillUsePropertyReflection
	{
		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600C5DD RID: 50653 RVA: 0x00212F2F File Offset: 0x0021112F
		public static FileDescriptor Descriptor
		{
			get
			{
				return SkillUsePropertyReflection.descriptor;
			}
		}

		// Token: 0x04004FE8 RID: 20456
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZTa2lsbFVzZVByb3BlcnR5LnByb3RvIs8BChBTa2lsbFVzZVByb3BlcnR5",
			"EhAKCHNraWxsX2lkGAEgASgNEhIKCnNraWxsX3R5cGUYAiABKAkSEwoLc2tp",
			"bGxfbGV2ZWwYAyABKA0SFwoPc2tpbGxfdXNlX2NvdW50GAQgASgNEhMKC0VL",
			"Q0tDUEVFT1BNGAUgASgNEhMKC0tIQ01ESEJMSEZPGAYgASgNEhMKC01QSEtF",
			"T01HSEtEGAcgASgNEhMKC0NISkNETUpOQ0VEGAggASgNEhMKC0VHRVBQT0lI",
			"RkxHGAkgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SkillUseProperty), SkillUseProperty.Parser, new string[]
			{
				"SkillId",
				"SkillType",
				"SkillLevel",
				"SkillUseCount",
				"EKCKCPEEOPM",
				"KHCMDHBLHFO",
				"MPHKEOMGHKD",
				"CHJCDMJNCED",
				"EGEPPOIHFLG"
			}, null, null, null, null)
		}));
	}
}
