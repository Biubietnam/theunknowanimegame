using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E52 RID: 3666
	public static class RogueCommonFormulaReflection
	{
		// Token: 0x17002E32 RID: 11826
		// (get) Token: 0x0600A395 RID: 41877 RVA: 0x001B80D5 File Offset: 0x001B62D5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonFormulaReflection.descriptor;
			}
		}

		// Token: 0x040042F8 RID: 17144
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZUNvbW1vbkZvcm11bGEucHJvdG8aEUZvcm11bGFJbmZvLnByb3Rv" + "IjgKElJvZ3VlQ29tbW9uRm9ybXVsYRIiCgxmb3JtdWxhX2luZm8YCiABKAsy" + "DC5Gb3JtdWxhSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[]
		{
			FormulaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonFormula), RogueCommonFormula.Parser, new string[]
			{
				"FormulaInfo"
			}, null, null, null, null)
		}));
	}
}
