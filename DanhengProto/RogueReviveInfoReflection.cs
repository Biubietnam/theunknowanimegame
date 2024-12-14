using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F6A RID: 3946
	public static class RogueReviveInfoReflection
	{
		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x001D86DE File Offset: 0x001D68DE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueReviveInfoReflection.descriptor;
			}
		}

		// Token: 0x04004781 RID: 18305
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZVJldml2ZUluZm8ucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90byJ6",
			"Cg9Sb2d1ZVJldml2ZUluZm8SEwoLTUVGT0FPRkhPREcYByADKA0SEwoLUEFI",
			"R09JRENNSU0YCiABKA0SEwoLS0pFUENFQkJES0YYAyABKA0SKAoRcm9ndWVf",
			"cmV2aXZlX2Nvc3QYAiABKAsyDS5JdGVtQ29zdERhdGFCHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueReviveInfo), RogueReviveInfo.Parser, new string[]
			{
				"MEFOAOFHODG",
				"PAHGOIDCMIM",
				"KJEPCEBBDKF",
				"RogueReviveCost"
			}, null, null, null, null)
		}));
	}
}
