using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001440 RID: 5184
	public static class WorkbenchReforgeBuffFuncInfoReflection
	{
		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0600E75E RID: 59230 RVA: 0x0026725A File Offset: 0x0026545A
		public static FileDescriptor Descriptor
		{
			get
			{
				return WorkbenchReforgeBuffFuncInfoReflection.descriptor;
			}
		}

		// Token: 0x04005BCF RID: 23503
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJXb3JrYmVuY2hSZWZvcmdlQnVmZkZ1bmNJbmZvLnByb3RvGhJJdGVtQ29z",
			"dERhdGEucHJvdG8iswEKHFdvcmtiZW5jaFJlZm9yZ2VCdWZmRnVuY0luZm8S",
			"GAoQY2FuX2ZyZWVfcmVmb3JnZRgBIAEoCBIdChVpbnRfcmVmb3JnZV9udW1f",
			"dmFsdWUYAyABKAUSHgoWdWludF9yZWZvcmdlX251bV92YWx1ZRgMIAEoDRIg",
			"Cgljb3N0X2RhdGEYDiABKAsyDS5JdGVtQ29zdERhdGESGAoQZnJlZV9yZWZv",
			"cmdlX251bRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WorkbenchReforgeBuffFuncInfo), WorkbenchReforgeBuffFuncInfo.Parser, new string[]
			{
				"CanFreeReforge",
				"IntReforgeNumValue",
				"UintReforgeNumValue",
				"CostData",
				"FreeReforgeNum"
			}, null, null, null, null)
		}));
	}
}
