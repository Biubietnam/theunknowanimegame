using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200075A RID: 1882
	public static class GetPetDataScRspReflection
	{
		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06005421 RID: 21537 RVA: 0x000E247E File Offset: 0x000E067E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPetDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002108 RID: 8456
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRQZXREYXRhU2NSc3AucHJvdG8iSwoPR2V0UGV0RGF0YVNjUnNwEhMK" + "C3BldF9pZF9saXN0GAYgAygNEg8KB3JldGNvZGUYBCABKA0SEgoKY3VyX3Bl" + "dF9pZBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPetDataScRsp), GetPetDataScRsp.Parser, new string[]
			{
				"PetIdList",
				"Retcode",
				"CurPetId"
			}, null, null, null, null)
		}));
	}
}
