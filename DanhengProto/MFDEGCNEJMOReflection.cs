using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ACA RID: 2762
	public static class MFDEGCNEJMOReflection
	{
		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06007A65 RID: 31333 RVA: 0x001443AB File Offset: 0x001425AB
		public static FileDescriptor Descriptor
		{
			get
			{
				return MFDEGCNEJMOReflection.descriptor;
			}
		}

		// Token: 0x04002F01 RID: 12033
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRkRFR0NORUpNTy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byI7CgtNRkRF" + "R0NORUpNTxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUSCgoC" + "aWQYAiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MFDEGCNEJMO), MFDEGCNEJMO.Parser, new string[]
			{
				"AvatarType",
				"Id"
			}, null, null, null, null)
		}));
	}
}
