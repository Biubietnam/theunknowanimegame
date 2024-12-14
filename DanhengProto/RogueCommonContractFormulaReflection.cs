using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E3E RID: 3646
	public static class RogueCommonContractFormulaReflection
	{
		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x001B5880 File Offset: 0x001B3A80
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonContractFormulaReflection.descriptor;
			}
		}

		// Token: 0x040042A6 RID: 17062
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZUNvbW1vbkNvbnRyYWN0Rm9ybXVsYS5wcm90bxoRRm9ybXVsYUlu" + "Zm8ucHJvdG8iQAoaUm9ndWVDb21tb25Db250cmFjdEZvcm11bGESIgoMZm9y" + "bXVsYV9pbmZvGAQgASgLMgwuRm9ybXVsYUluZm9CHqoCG0VnZ0xpbmsuRGFu" + "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			FormulaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonContractFormula), RogueCommonContractFormula.Parser, new string[]
			{
				"FormulaInfo"
			}, null, null, null, null)
		}));
	}
}
