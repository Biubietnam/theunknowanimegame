using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E2E RID: 3630
	public static class RogueCommonActionResultReflection
	{
		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600A1EA RID: 41450 RVA: 0x001B198F File Offset: 0x001AFB8F
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonActionResultReflection.descriptor;
			}
		}

		// Token: 0x04004233 RID: 16947
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1Sb2d1ZUNvbW1vbkFjdGlvblJlc3VsdC5wcm90bxonUm9ndWVDb21tb25B",
			"Y3Rpb25SZXN1bHRTb3VyY2VUeXBlLnByb3RvGiFSb2d1ZUNvbW1vbkFjdGlv",
			"blJlc3VsdERhdGEucHJvdG8igQEKF1JvZ3VlQ29tbW9uQWN0aW9uUmVzdWx0",
			"EjIKBnNvdXJjZRgJIAEoDjIiLlJvZ3VlQ29tbW9uQWN0aW9uUmVzdWx0U291",
			"cmNlVHlwZRIyCgxyb2d1ZV9hY3Rpb24YASABKAsyHC5Sb2d1ZUNvbW1vbkFj",
			"dGlvblJlc3VsdERhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonActionResultSourceTypeReflection.Descriptor,
			RogueCommonActionResultDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonActionResult), RogueCommonActionResult.Parser, new string[]
			{
				"Source",
				"RogueAction"
			}, null, null, null, null)
		}));
	}
}
