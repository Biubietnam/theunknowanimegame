using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006FA RID: 1786
	public static class GetLineupAvatarDataScRspReflection
	{
		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x000D7802 File Offset: 0x000D5A02
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetLineupAvatarDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001F71 RID: 8049
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRMaW5ldXBBdmF0YXJEYXRhU2NSc3AucHJvdG8aFkxpbmV1cEF2YXRh",
			"ckRhdGEucHJvdG8iWAoYR2V0TGluZXVwQXZhdGFyRGF0YVNjUnNwEisKEGF2",
			"YXRhcl9kYXRhX2xpc3QYDyADKAsyES5MaW5ldXBBdmF0YXJEYXRhEg8KB3Jl",
			"dGNvZGUYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			LineupAvatarDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetLineupAvatarDataScRsp), GetLineupAvatarDataScRsp.Parser, new string[]
			{
				"AvatarDataList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
