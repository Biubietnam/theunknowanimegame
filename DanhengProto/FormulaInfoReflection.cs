using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B6 RID: 1462
	public static class FormulaInfoReflection
	{
		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x000B22ED File Offset: 0x000B04ED
		public static FileDescriptor Descriptor
		{
			get
			{
				return FormulaInfoReflection.descriptor;
			}
		}

		// Token: 0x040019F6 RID: 6646
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFGb3JtdWxhSW5mby5wcm90bxoZRm9ybXVsYUJ1ZmZUeXBlSW5mby5wcm90",
			"byJqCgtGb3JtdWxhSW5mbxIRCglpc19leHBhbmQYCyABKAgSNAoWZm9ybXVs",
			"YV9idWZmX3R5cGVfbGlzdBgJIAMoCzIULkZvcm11bGFCdWZmVHlwZUluZm8S",
			"EgoKZm9ybXVsYV9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			FormulaBuffTypeInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FormulaInfo), FormulaInfo.Parser, new string[]
			{
				"IsExpand",
				"FormulaBuffTypeList",
				"FormulaId"
			}, null, null, null, null)
		}));
	}
}
