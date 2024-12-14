using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000136 RID: 310
	public static class BNBMFMMBIAOReflection
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00029ABB File Offset: 0x00027CBB
		public static FileDescriptor Descriptor
		{
			get
			{
				return BNBMFMMBIAOReflection.descriptor;
			}
		}

		// Token: 0x0400060D RID: 1549
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTkJNRk1NQklBTy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byI7CgtCTkJN" + "Rk1NQklBTxIgCgthdmF0YXJfdHlwZRgLIAEoDjILLkF2YXRhclR5cGUSCgoC" + "aWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BNBMFMMBIAO), BNBMFMMBIAO.Parser, new string[]
			{
				"AvatarType",
				"Id"
			}, null, null, null, null)
		}));
	}
}
