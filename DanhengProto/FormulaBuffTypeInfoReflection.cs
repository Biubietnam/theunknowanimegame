using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B4 RID: 1460
	public static class FormulaBuffTypeInfoReflection
	{
		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x000B1FB9 File Offset: 0x000B01B9
		public static FileDescriptor Descriptor
		{
			get
			{
				return FormulaBuffTypeInfoReflection.descriptor;
			}
		}

		// Token: 0x040019EF RID: 6639
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGb3JtdWxhQnVmZlR5cGVJbmZvLnByb3RvIjwKE0Zvcm11bGFCdWZmVHlw" + "ZUluZm8SCwoDa2V5GAwgASgNEhgKEGZvcm11bGFfYnVmZl9udW0YCSABKAVC" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FormulaBuffTypeInfo), FormulaBuffTypeInfo.Parser, new string[]
			{
				"Key",
				"FormulaBuffNum"
			}, null, null, null, null)
		}));
	}
}
