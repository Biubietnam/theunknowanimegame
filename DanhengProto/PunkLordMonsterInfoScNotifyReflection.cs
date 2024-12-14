using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D2A RID: 3370
	public static class PunkLordMonsterInfoScNotifyReflection
	{
		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600968C RID: 38540 RVA: 0x00190957 File Offset: 0x0018EB57
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003A6E RID: 14958
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFQdW5rTG9yZE1vbnN0ZXJJbmZvU2NOb3RpZnkucHJvdG8aJVB1bmtMb3Jk",
			"TW9uc3RlckluZm9Ob3RpZnlSZWFzb24ucHJvdG8aGlB1bmtMb3JkQmF0dGxl",
			"UmVjb3JkLnByb3RvGh5QdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8ucHJvdG8i",
			"vwEKG1B1bmtMb3JkTW9uc3RlckluZm9TY05vdGlmeRIwCgZyZWFzb24YCyAB",
			"KA4yIC5QdW5rTG9yZE1vbnN0ZXJJbmZvTm90aWZ5UmVhc29uEi0KCmJhc2lj",
			"X2luZm8YDiABKAsyGS5QdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8SEwoLRkRE",
			"RkFLR0dQR0YYASADKA0SKgoLQ0RBSkdMSUlCSUkYCCABKAsyFS5QdW5rTG9y",
			"ZEJhdHRsZVJlY29yZEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PunkLordMonsterInfoNotifyReasonReflection.Descriptor,
			PunkLordBattleRecordReflection.Descriptor,
			PunkLordMonsterBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterInfoScNotify), PunkLordMonsterInfoScNotify.Parser, new string[]
			{
				"Reason",
				"BasicInfo",
				"FDDFAKGGPGF",
				"CDAJGLIIBII"
			}, null, null, null, null)
		}));
	}
}
