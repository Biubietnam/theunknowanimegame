using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F0E RID: 3854
	public static class RogueMagicScepterSelectResultReflection
	{
		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x001CF387 File Offset: 0x001CD587
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterSelectResultReflection.descriptor;
			}
		}

		// Token: 0x0400462A RID: 17962
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiNSb2d1ZU1hZ2ljU2NlcHRlclNlbGVjdFJlc3VsdC5wcm90bxoXUm9ndWVN",
			"YWdpY1NjZXB0ZXIucHJvdG8iYAodUm9ndWVNYWdpY1NjZXB0ZXJTZWxlY3RS",
			"ZXN1bHQSEwoLTFBOQ0JOQ0pESUsYDSABKAgSKgoOc2VsZWN0X3NjZXB0ZXIY",
			"AiABKAsyEi5Sb2d1ZU1hZ2ljU2NlcHRlckIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueMagicScepterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicScepterSelectResult), RogueMagicScepterSelectResult.Parser, new string[]
			{
				"LPNCBNCJDIK",
				"SelectScepter"
			}, null, null, null, null)
		}));
	}
}
