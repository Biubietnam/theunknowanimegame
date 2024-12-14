using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BFE RID: 3070
	public static class NBAPLJDBOCBReflection
	{
		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x060087F2 RID: 34802 RVA: 0x00166FB9 File Offset: 0x001651B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return NBAPLJDBOCBReflection.descriptor;
			}
		}

		// Token: 0x04003423 RID: 13347
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChFOQkFQTEpEQk9DQi5wcm90bxoVUm9ndWVDb21tb25CdWZmLnByb3RvGhZH",
			"YW1lUm9ndWVNaXJhY2xlLnByb3RvIm8KC05CQVBMSkRCT0NCEhIKCml0ZW1f",
			"dmFsdWUYCiABKA0SJwoMbWlyYWNsZV9saXN0GAcgAygLMhEuR2FtZVJvZ3Vl",
			"TWlyYWNsZRIjCglidWZmX2xpc3QYAyADKAsyEC5Sb2d1ZUNvbW1vbkJ1ZmZC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueCommonBuffReflection.Descriptor,
			GameRogueMiracleReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NBAPLJDBOCB), NBAPLJDBOCB.Parser, new string[]
			{
				"ItemValue",
				"MiracleList",
				"BuffList"
			}, null, null, null, null)
		}));
	}
}
