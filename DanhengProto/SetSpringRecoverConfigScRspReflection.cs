using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001134 RID: 4404
	public static class SetSpringRecoverConfigScRspReflection
	{
		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600C46C RID: 50284 RVA: 0x0020F319 File Offset: 0x0020D519
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetSpringRecoverConfigScRspReflection.descriptor;
			}
		}

		// Token: 0x04004F5C RID: 20316
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTZXRTcHJpbmdSZWNvdmVyQ29uZmlnU2NSc3AucHJvdG8aGVNwcmluZ1Jl",
			"Y292ZXJDb25maWcucHJvdG8iYwobU2V0U3ByaW5nUmVjb3ZlckNvbmZpZ1Nj",
			"UnNwEjMKFXNwcmluZ19yZWNvdmVyX2NvbmZpZxgGIAEoCzIULlNwcmluZ1Jl",
			"Y292ZXJDb25maWcSDwoHcmV0Y29kZRgNIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			SpringRecoverConfigReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetSpringRecoverConfigScRsp), SetSpringRecoverConfigScRsp.Parser, new string[]
			{
				"SpringRecoverConfig",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
