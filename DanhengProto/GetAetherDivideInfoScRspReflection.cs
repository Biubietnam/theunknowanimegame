using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000600 RID: 1536
	public static class GetAetherDivideInfoScRspReflection
	{
		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x000BCC82 File Offset: 0x000BAE82
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAetherDivideInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001B8B RID: 7051
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRBZXRoZXJEaXZpZGVJbmZvU2NSc3AucHJvdG8aHEFldGhlckRpdmlk",
			"ZVNwaXJpdEluZm8ucHJvdG8aFUFldGhlclNraWxsSW5mby5wcm90bxocQWV0",
			"aGVyRGl2aWRlTGluZXVwSW5mby5wcm90byKdAgoYR2V0QWV0aGVyRGl2aWRl",
			"SW5mb1NjUnNwEg8KB3JldGNvZGUYDCABKA0SEwoLT0lDR0xJTkNCQkoYBCAB",
			"KA0SEwoLTlBHT01MRkdCSk0YByABKA0SEwoLR09PSEpKSk9NRUoYASABKA0S",
			"EwoLUEhQQ0RHRU1BR0QYBiABKA0SKwoRYWV0aGVyX3NraWxsX2xpc3QYCiAD",
			"KAsyEC5BZXRoZXJTa2lsbEluZm8SEwoLQkRJR0tGUEhMSEsYDyABKA0SLAoL",
			"bGluZXVwX2xpc3QYCyADKAsyFy5BZXRoZXJEaXZpZGVMaW5ldXBJbmZvEiwK",
			"C2F2YXRhcl9saXN0GA0gAygLMhcuQWV0aGVyRGl2aWRlU3Bpcml0SW5mb0Ie",
			"qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			AetherDivideSpiritInfoReflection.Descriptor,
			AetherSkillInfoReflection.Descriptor,
			AetherDivideLineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAetherDivideInfoScRsp), GetAetherDivideInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"OICGLINCBBJ",
				"NPGOMLFGBJM",
				"GOOHJJJOMEJ",
				"PHPCDGEMAGD",
				"AetherSkillList",
				"BDIGKFPHLHK",
				"LineupList",
				"AvatarList"
			}, null, null, null, null)
		}));
	}
}
