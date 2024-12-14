using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200140A RID: 5130
	public static class UseItemScRspReflection
	{
		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x002607E5 File Offset: 0x0025E9E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return UseItemScRspReflection.descriptor;
			}
		}

		// Token: 0x04005AE7 RID: 23271
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChJVc2VJdGVtU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIpUBCgxVc2VJ",
			"dGVtU2NSc3ASDwoHcmV0Y29kZRgIIAEoDRIeCgtyZXR1cm5fZGF0YRgHIAEo",
			"CzIJLkl0ZW1MaXN0EhMKC0dOR09LRkVNQ01JGAIgASgEEhMKC3VzZV9pdGVt",
			"X2lkGA0gASgNEhYKDnVzZV9pdGVtX2NvdW50GA4gASgNEhIKCmZvcm11bGFf",
			"aWQYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UseItemScRsp), UseItemScRsp.Parser, new string[]
			{
				"Retcode",
				"ReturnData",
				"GNGOKFEMCMI",
				"UseItemId",
				"UseItemCount",
				"FormulaId"
			}, null, null, null, null)
		}));
	}
}
