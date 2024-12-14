using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007EA RID: 2026
	public static class GetSecretKeyInfoScRspReflection
	{
		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06005A69 RID: 23145 RVA: 0x000F10C2 File Offset: 0x000EF2C2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSecretKeyInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002318 RID: 8984
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRTZWNyZXRLZXlJbmZvU2NSc3AucHJvdG8aE1NlY3JldEtleUluZm8u",
			"cHJvdG8iYgoVR2V0U2VjcmV0S2V5SW5mb1NjUnNwEg8KB3JldGNvZGUYBiAB",
			"KA0SEwoLTElCTk5MTkRIQ04YByABKAwSIwoLc2VjcmV0X2luZm8YAyADKAsy",
			"Di5TZWNyZXRLZXlJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
			"dG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			SecretKeyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSecretKeyInfoScRsp), GetSecretKeyInfoScRsp.Parser, new string[]
			{
				"Retcode",
				"LIBNNLNDHCN",
				"SecretInfo"
			}, null, null, null, null)
		}));
	}
}
