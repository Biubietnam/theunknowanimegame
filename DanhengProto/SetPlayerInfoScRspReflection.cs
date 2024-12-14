using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001122 RID: 4386
	public static class SetPlayerInfoScRspReflection
	{
		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600C399 RID: 50073 RVA: 0x0020CE14 File Offset: 0x0020B014
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetPlayerInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004F01 RID: 20225
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhTZXRQbGF5ZXJJbmZvU2NSc3AucHJvdG8aGU11bHRpUGF0aEF2YXRhcklu",
			"Zm8ucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5cGUucHJvdG8itQEKElNldFBs",
			"YXllckluZm9TY1JzcBItCg9jdXJfYXZhdGFyX3BhdGgYDSABKA4yFC5NdWx0",
			"aVBhdGhBdmF0YXJUeXBlEhEKCWlzX21vZGlmeRgBIAEoCBI3ChljdXJfYXZh",
			"dGFyX3BhdGhfaW5mb19saXN0GAsgAygLMhQuTXVsdGlQYXRoQXZhdGFySW5m",
			"bxIPCgdyZXRjb2RlGAQgASgNEhMKC0RMRkpMQUpNTEhKGA4gASgDQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MultiPathAvatarInfoReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerInfoScRsp), SetPlayerInfoScRsp.Parser, new string[]
			{
				"CurAvatarPath",
				"IsModify",
				"CurAvatarPathInfoList",
				"Retcode",
				"DLFJLAJMLHJ"
			}, null, null, null, null)
		}));
	}
}
