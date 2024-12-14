using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019C RID: 412
	public static class ChallengeBossRelicInfoReflection
	{
		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00035990 File Offset: 0x00033B90
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossRelicInfoReflection.descriptor;
			}
		}

		// Token: 0x040007D6 RID: 2006
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChxDaGFsbGVuZ2VCb3NzUmVsaWNJbmZvLnByb3RvGhBSZWxpY0FmZml4LnBy",
			"b3RvIoMBChZDaGFsbGVuZ2VCb3NzUmVsaWNJbmZvEhUKDW1haW5fYWZmaXhf",
			"aWQYAiABKA0SCwoDdGlkGAogASgNEiMKDnN1Yl9hZmZpeF9saXN0GAEgAygL",
			"MgsuUmVsaWNBZmZpeBINCgVsZXZlbBgFIAEoDRIRCgl1bmlxdWVfaWQYBCAB",
			"KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RelicAffixReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossRelicInfo), ChallengeBossRelicInfo.Parser, new string[]
			{
				"MainAffixId",
				"Tid",
				"SubAffixList",
				"Level",
				"UniqueId"
			}, null, null, null, null)
		}));
	}
}
