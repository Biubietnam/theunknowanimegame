using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CBA RID: 3258
	public static class PlayerGetTokenScRspReflection
	{
		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600910F RID: 37135 RVA: 0x0017FE01 File Offset: 0x0017E001
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerGetTokenScRspReflection.descriptor;
			}
		}

		// Token: 0x040037E0 RID: 14304
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlQbGF5ZXJHZXRUb2tlblNjUnNwLnByb3RvGg9CbGFja0luZm8ucHJvdG8i",
			"eQoTUGxheWVyR2V0VG9rZW5TY1JzcBILCgNtc2cYBiABKAkSHgoKYmxhY2tf",
			"aW5mbxgOIAEoCzIKLkJsYWNrSW5mbxIPCgdyZXRjb2RlGAsgASgNEhcKD3Nl",
			"Y3JldF9rZXlfc2VlZBgFIAEoBBILCgN1aWQYDCABKA1CHqoCG0VnZ0xpbmsu",
			"RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			BlackInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerGetTokenScRsp), PlayerGetTokenScRsp.Parser, new string[]
			{
				"Msg",
				"BlackInfo",
				"Retcode",
				"SecretKeySeed",
				"Uid"
			}, null, null, null, null)
		}));
	}
}
