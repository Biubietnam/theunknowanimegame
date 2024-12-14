using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001444 RID: 5188
	public static class WorkbenchReforgeFormulaFuncInfoReflection
	{
		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x0600E790 RID: 59280 RVA: 0x00267A86 File Offset: 0x00265C86
		public static FileDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeFormulaFuncInfoReflection.descriptor;
			}
		}

		// Token: 0x04005BE1 RID: 23521
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiVXb3JrYmVuY2hSZWZvcmdlRm9ybXVsYUZ1bmNJbmZvLnByb3RvGhJJdGVt",
			"Q29zdERhdGEucHJvdG8itgEKH1dvcmtiZW5jaFJlZm9yZ2VGb3JtdWxhRnVu",
			"Y0luZm8SHgoWdWludF9yZWZvcmdlX251bV92YWx1ZRgHIAEoDRIgCgljb3N0",
			"X2RhdGEYDSABKAsyDS5JdGVtQ29zdERhdGESHQoVaW50X3JlZm9yZ2VfbnVt",
			"X3ZhbHVlGAIgASgFEhgKEGNhbl9mcmVlX3JlZm9yZ2UYCiABKAgSGAoQZnJl",
			"ZV9yZWZvcmdlX251bRgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
			"LlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WorkbenchReforgeFormulaFuncInfo), WorkbenchReforgeFormulaFuncInfo.Parser, new string[]
			{
				"UintReforgeNumValue",
				"CostData",
				"IntReforgeNumValue",
				"CanFreeReforge",
				"FreeReforgeNum"
			}, null, null, null, null)
		}));
	}
}
