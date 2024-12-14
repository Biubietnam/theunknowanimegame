using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001384 RID: 4996
	public static class TravelBrochureSelectMessageScRspReflection
	{
		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600DEE9 RID: 57065 RVA: 0x002512A1 File Offset: 0x0024F4A1
		public static FileDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSelectMessageScRspReflection.descriptor;
			}
		}

		// Token: 0x04005898 RID: 22680
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VTY1JzcC5wcm90bxoRS0hL",
			"TEtITkdET0cucHJvdG8aDkl0ZW1MaXN0LnByb3RvInEKIFRyYXZlbEJyb2No",
			"dXJlU2VsZWN0TWVzc2FnZVNjUnNwEiEKC0dLQVBET0NQQ0pNGAkgASgLMgwu",
			"S0hLTEtITkdET0cSDwoHcmV0Y29kZRgLIAEoDRIZCgZyZXdhcmQYAyABKAsy",
			"CS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			KHKLKHNGDOGReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSelectMessageScRsp), TravelBrochureSelectMessageScRsp.Parser, new string[]
			{
				"GKAPDOCPCJM",
				"Retcode",
				"Reward"
			}, null, null, null, null)
		}));
	}
}
