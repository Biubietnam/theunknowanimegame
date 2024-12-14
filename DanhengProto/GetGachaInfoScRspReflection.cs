using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006DA RID: 1754
	public static class GetGachaInfoScRspReflection
	{
		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x000D44EE File Offset: 0x000D26EE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetGachaInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001EF9 RID: 7929
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRHYWNoYUluZm9TY1JzcC5wcm90bxoPR2FjaGFJbmZvLnByb3RvIp4B",
			"ChFHZXRHYWNoYUluZm9TY1JzcBITCgtQSkFGSU1NQ1BERhgGIAEoDRITCgtI",
			"REZNTkxIQ09NRRgFIAEoDRITCgtISkZMR0NORUtLSxgMIAEoDRIjCg9nYWNo",
			"YV9pbmZvX2xpc3QYCCADKAsyCi5HYWNoYUluZm8SFAoMZ2FjaGFfcmFuZG9t",
			"GAIgASgNEg8KB3JldGNvZGUYCSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			GachaInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaInfoScRsp), GetGachaInfoScRsp.Parser, new string[]
			{
				"PJAFIMMCPDF",
				"HDFMNLHCOME",
				"HJFLGCNEKKK",
				"GachaInfoList",
				"GachaRandom",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
