using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000178 RID: 376
	public static class CellFinalMonsterInfoReflection
	{
		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x000308C7 File Offset: 0x0002EAC7
		public static FileDescriptor Descriptor
		{
			get
			{
				return CellFinalMonsterInfoReflection.descriptor;
			}
		}

		// Token: 0x04000709 RID: 1801
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDZWxsRmluYWxNb25zdGVySW5mby5wcm90bxobQ2VsbE1vbnN0ZXJTZWxl",
			"Y3RJbmZvLnByb3RvGhVDZWxsTW9uc3RlckluZm8ucHJvdG8icgoUQ2VsbEZp",
			"bmFsTW9uc3RlckluZm8SKAoOY2VsbF9ib3NzX2luZm8YAiABKAsyEC5DZWxs",
			"TW9uc3RlckluZm8SMAoQc2VsZWN0X2Jvc3NfaW5mbxgLIAEoCzIWLkNlbGxN",
			"b25zdGVyU2VsZWN0SW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			CellMonsterSelectInfoReflection.Descriptor,
			CellMonsterInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CellFinalMonsterInfo), CellFinalMonsterInfo.Parser, new string[]
			{
				"CellBossInfo",
				"SelectBossInfo"
			}, null, null, null, null)
		}));
	}
}
