using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F62 RID: 3938
	public static class RogueRecordInfoReflection
	{
		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600AF95 RID: 44949 RVA: 0x001D7B9A File Offset: 0x001D5D9A
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueRecordInfoReflection.descriptor;
			}
		}

		// Token: 0x04004768 RID: 18280
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVSb2d1ZVJlY29yZEluZm8ucHJvdG8aF1JvZ3VlUmVjb3JkQXZhdGFyLnBy",
			"b3RvGg9Sb2d1ZUJ1ZmYucHJvdG8ibwoPUm9ndWVSZWNvcmRJbmZvEh0KCWJ1",
			"ZmZfbGlzdBgFIAMoCzIKLlJvZ3VlQnVmZhInCgthdmF0YXJfbGlzdBgOIAMo",
			"CzISLlJvZ3VlUmVjb3JkQXZhdGFyEhQKDG1pcmFjbGVfbGlzdBgMIAMoDUIe",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueRecordAvatarReflection.Descriptor,
			RogueBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueRecordInfo), RogueRecordInfo.Parser, new string[]
			{
				"BuffList",
				"AvatarList",
				"MiracleList"
			}, null, null, null, null)
		}));
	}
}
