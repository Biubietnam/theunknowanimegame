using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200031A RID: 794
	public static class ComposeItemScRspReflection
	{
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x000652C3 File Offset: 0x000634C3
		public static FileDescriptor Descriptor
		{
			get
			{
				return ComposeItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04000E9F RID: 3743
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZDb21wb3NlSXRlbVNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJrChBD",
			"b21wb3NlSXRlbVNjUnNwEiMKEHJldHVybl9pdGVtX2xpc3QYDiABKAsyCS5J",
			"dGVtTGlzdBINCgVjb3VudBgCIAEoDRIPCgdyZXRjb2RlGAMgASgNEhIKCmNv",
			"bXBvc2VfaWQYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ComposeItemScRsp), ComposeItemScRsp.Parser, new string[]
			{
				"ReturnItemList",
				"Count",
				"Retcode",
				"ComposeId"
			}, null, null, null, null)
		}));
	}
}
