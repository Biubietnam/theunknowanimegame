using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001132 RID: 4402
	public static class SetSpringRecoverConfigCsReqReflection
	{
		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600C457 RID: 50263 RVA: 0x0020F039 File Offset: 0x0020D239
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetSpringRecoverConfigCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004F57 RID: 20311
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFTZXRTcHJpbmdSZWNvdmVyQ29uZmlnQ3NSZXEucHJvdG8aGVNwcmluZ1Jl",
			"Y292ZXJDb25maWcucHJvdG8iUgobU2V0U3ByaW5nUmVjb3ZlckNvbmZpZ0Nz",
			"UmVxEjMKFXNwcmluZ19yZWNvdmVyX2NvbmZpZxgBIAEoCzIULlNwcmluZ1Jl",
			"Y292ZXJDb25maWdCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
			"cHJvdG8z"
		})), new FileDescriptor[]
		{
			SpringRecoverConfigReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetSpringRecoverConfigCsReq), SetSpringRecoverConfigCsReq.Parser, new string[]
			{
				"SpringRecoverConfig"
			}, null, null, null, null)
		}));
	}
}
