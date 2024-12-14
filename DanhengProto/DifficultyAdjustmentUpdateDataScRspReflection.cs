using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A2 RID: 930
	public static class DifficultyAdjustmentUpdateDataScRspReflection
	{
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x00072C75 File Offset: 0x00070E75
		public static FileDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentUpdateDataScRspReflection.descriptor;
			}
		}

		// Token: 0x040010A7 RID: 4263
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilEaWZmaWN1bHR5QWRqdXN0bWVudFVwZGF0ZURhdGFTY1JzcC5wcm90bxoR",
			"RlBHS0hJRkVOR0wucHJvdG8ifgojRGlmZmljdWx0eUFkanVzdG1lbnRVcGRh",
			"dGVEYXRhU2NSc3ASGgoEZGF0YRgPIAEoCzIMLkZQR0tISUZFTkdMEg8KB3Jl",
			"dGNvZGUYAiABKA0SKgoUY29udGVudF9wYWNrYWdlX2xpc3QYByADKAsyDC5G",
			"UEdLSElGRU5HTEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			FPGKHIFENGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentUpdateDataScRsp), DifficultyAdjustmentUpdateDataScRsp.Parser, new string[]
			{
				"Data",
				"Retcode",
				"ContentPackageList"
			}, null, null, null, null)
		}));
	}
}
