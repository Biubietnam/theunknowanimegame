using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001180 RID: 4480
	public static class SpringRecoverSingleAvatarCsReqReflection
	{
		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600C7F0 RID: 51184 RVA: 0x002186CC File Offset: 0x002168CC
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpringRecoverSingleAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x040050B9 RID: 20665
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRTcHJpbmdSZWNvdmVyU2luZ2xlQXZhdGFyQ3NSZXEucHJvdG8aEEF2YXRh",
			"clR5cGUucHJvdG8inwEKHlNwcmluZ1JlY292ZXJTaW5nbGVBdmF0YXJDc1Jl",
			"cRIQCghmbG9vcl9pZBgCIAEoDRITCgtIS0NCSkpHS05GTxgDIAEoCBIQCghw",
			"bGFuZV9pZBgMIAEoDRIKCgJpZBgNIAEoDRIgCgthdmF0YXJfdHlwZRgIIAEo",
			"DjILLkF2YXRhclR5cGUSFgoOcHJvcF9lbnRpdHlfaWQYDiABKA1CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpringRecoverSingleAvatarCsReq), SpringRecoverSingleAvatarCsReq.Parser, new string[]
			{
				"FloorId",
				"HKCBJJGKNFO",
				"PlaneId",
				"Id",
				"AvatarType",
				"PropEntityId"
			}, null, null, null, null)
		}));
	}
}
