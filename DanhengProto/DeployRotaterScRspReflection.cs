using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000388 RID: 904
	public static class DeployRotaterScRspReflection
	{
		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x0006FD31 File Offset: 0x0006DF31
		public static FileDescriptor Descriptor
		{
			get
			{
				return DeployRotaterScRspReflection.descriptor;
			}
		}

		// Token: 0x04001028 RID: 4136
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhEZXBsb3lSb3RhdGVyU2NSc3AucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv",
			"GhdSb3RhdGVyRW5lcmd5SW5mby5wcm90byJyChJEZXBsb3lSb3RhdGVyU2NS",
			"c3ASDwoHcmV0Y29kZRgLIAEoDRInCgtlbmVyZ3lfaW5mbxgNIAEoCzISLlJv",
			"dGF0ZXJFbmVyZ3lJbmZvEiIKDHJvdGF0ZXJfZGF0YRgGIAEoCzIMLlJvdGF0",
			"ZXJEYXRhQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DeployRotaterScRsp), DeployRotaterScRsp.Parser, new string[]
			{
				"Retcode",
				"EnergyInfo",
				"RotaterData"
			}, null, null, null, null)
		}));
	}
}
