using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB8 RID: 4024
	public static class RogueTournFormulaInfoReflection
	{
		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600B359 RID: 45913 RVA: 0x001E1CA6 File Offset: 0x001DFEA6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournFormulaInfoReflection.descriptor;
			}
		}

		// Token: 0x040048D1 RID: 18641
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtSb2d1ZVRvdXJuRm9ybXVsYUluZm8ucHJvdG8aEUZvcm11bGFJbmZvLnBy",
			"b3RvGhZGb3JtdWxhVHlwZVZhbHVlLnByb3RvIm8KFVJvZ3VlVG91cm5Gb3Jt",
			"dWxhSW5mbxItChJmb3JtdWxhX3R5cGVfdmFsdWUYAiABKAsyES5Gb3JtdWxh",
			"VHlwZVZhbHVlEicKEWdhbWVfZm9ybXVsYV9pbmZvGA0gAygLMgwuRm9ybXVs",
			"YUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			FormulaInfoReflection.Descriptor,
			FormulaTypeValueReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournFormulaInfo), RogueTournFormulaInfo.Parser, new string[]
			{
				"FormulaTypeValue",
				"GameFormulaInfo"
			}, null, null, null, null)
		}));
	}
}
