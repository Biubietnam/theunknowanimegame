using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200073E RID: 1854
	public static class GetMultiPathAvatarInfoScRspReflection
	{
		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x060052E4 RID: 21220 RVA: 0x000DF232 File Offset: 0x000DD432
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetMultiPathAvatarInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400208D RID: 8333
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFHZXRNdWx0aVBhdGhBdmF0YXJJbmZvU2NSc3AucHJvdG8aGU11bHRpUGF0",
			"aEF2YXRhckluZm8ucHJvdG8aGU11bHRpUGF0aEF2YXRhclR5cGUucHJvdG8i",
			"mwIKG0dldE11bHRpUGF0aEF2YXRhckluZm9TY1JzcBIaChJiYXNpY190eXBl",
			"X2lkX2xpc3QYAiADKA0SOQobbXVsdGlfcGF0aF9hdmF0YXJfaW5mb19saXN0",
			"GAcgAygLMhQuTXVsdGlQYXRoQXZhdGFySW5mbxIPCgdyZXRjb2RlGAggASgN",
			"EkgKD2N1cl9hdmF0YXJfcGF0aBgFIAMoCzIvLkdldE11bHRpUGF0aEF2YXRh",
			"ckluZm9TY1JzcC5DdXJBdmF0YXJQYXRoRW50cnkaSgoSQ3VyQXZhdGFyUGF0",
			"aEVudHJ5EgsKA2tleRgBIAEoDRIjCgV2YWx1ZRgCIAEoDjIULk11bHRpUGF0",
			"aEF2YXRhclR5cGU6AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MultiPathAvatarInfoReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetMultiPathAvatarInfoScRsp), GetMultiPathAvatarInfoScRsp.Parser, new string[]
			{
				"BasicTypeIdList",
				"MultiPathAvatarInfoList",
				"Retcode",
				"CurAvatarPath"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
