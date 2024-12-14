using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000802 RID: 2050
	public static class GetSpringRecoverDataScRspReflection
	{
		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x000F371A File Offset: 0x000F191A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetSpringRecoverDataScRspReflection.descriptor;
			}
		}

		// Token: 0x0400236C RID: 9068
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch9HZXRTcHJpbmdSZWNvdmVyRGF0YVNjUnNwLnByb3RvGhJIZWFsUG9vbElu",
			"Zm8ucHJvdG8aGVNwcmluZ1JlY292ZXJDb25maWcucHJvdG8iiAEKGUdldFNw",
			"cmluZ1JlY292ZXJEYXRhU2NSc3ASJQoOaGVhbF9wb29sX2luZm8YDSABKAsy",
			"DS5IZWFsUG9vbEluZm8SDwoHcmV0Y29kZRgJIAEoDRIzChVzcHJpbmdfcmVj",
			"b3Zlcl9jb25maWcYAiABKAsyFC5TcHJpbmdSZWNvdmVyQ29uZmlnQh6qAhtF",
			"Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			HealPoolInfoReflection.Descriptor,
			SpringRecoverConfigReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetSpringRecoverDataScRsp), GetSpringRecoverDataScRsp.Parser, new string[]
			{
				"HealPoolInfo",
				"Retcode",
				"SpringRecoverConfig"
			}, null, null, null, null)
		}));
	}
}
