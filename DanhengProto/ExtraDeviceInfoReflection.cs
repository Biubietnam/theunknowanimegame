using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004F0 RID: 1264
	public static class ExtraDeviceInfoReflection
	{
		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0009AEA7 File Offset: 0x000990A7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ExtraDeviceInfoReflection.descriptor;
			}
		}

		// Token: 0x0400165E RID: 5726
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVFeHRyYURldmljZUluZm8ucHJvdG8inAEKD0V4dHJhRGV2aWNlSW5mbxIT",
			"CgtLTE1PT01CUEhJTxgBIAEoCRITCgtPRU9LQkxJT0dDQhgCIAEoCRITCgtE",
			"Q05GSk5MSkVETxgDIAEoCRITCgtHQk5PUE5QRUFPRhgEIAEoCRITCgtBTU9J",
			"Qk1KR0tOThgFIAEoCRITCgtMTENNSUNBRUZHTRgGIAEoCRILCgNNQUMYByAB",
			"KAlCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ExtraDeviceInfo), ExtraDeviceInfo.Parser, new string[]
			{
				"KLMOOMBPHIO",
				"OEOKBLIOGCB",
				"DCNFJNLJEDO",
				"GBNOPNPEAOF",
				"AMOIBMJGKNN",
				"LLCMICAEFGM",
				"MAC"
			}, null, null, null, null)
		}));
	}
}
