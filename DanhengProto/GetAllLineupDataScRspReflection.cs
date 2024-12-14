using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000608 RID: 1544
	public static class GetAllLineupDataScRspReflection
	{
		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x000BE436 File Offset: 0x000BC636
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAllLineupDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001BC9 RID: 7113
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRBbGxMaW5ldXBEYXRhU2NSc3AucHJvdG8aEExpbmV1cEluZm8ucHJv",
			"dG8iXQoVR2V0QWxsTGluZXVwRGF0YVNjUnNwEg8KB3JldGNvZGUYCyABKA0S",
			"IAoLbGluZXVwX2xpc3QYBSADKAsyCy5MaW5ldXBJbmZvEhEKCWN1cl9pbmRl",
			"eBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
			"bzM="
		})), new FileDescriptor[]
		{
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAllLineupDataScRsp), GetAllLineupDataScRsp.Parser, new string[]
			{
				"Retcode",
				"LineupList",
				"CurIndex"
			}, null, null, null, null)
		}));
	}
}
