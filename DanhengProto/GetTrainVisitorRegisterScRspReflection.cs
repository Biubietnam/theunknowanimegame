using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200082E RID: 2094
	public static class GetTrainVisitorRegisterScRspReflection
	{
		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06005D3C RID: 23868 RVA: 0x000F76EA File Offset: 0x000F58EA
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetTrainVisitorRegisterScRspReflection.descriptor;
			}
		}

		// Token: 0x04002402 RID: 9218
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJHZXRUcmFpblZpc2l0b3JSZWdpc3RlclNjUnNwLnByb3RvGhZUcmFpblZp",
			"c2l0b3JJbmZvLnByb3RvImwKHEdldFRyYWluVmlzaXRvclJlZ2lzdGVyU2NS",
			"c3ASDwoHcmV0Y29kZRgOIAEoDRITCgtCSEpFSU1JTExQRhgBIAMoDRImCgtK",
			"Qk1QRUdQUENIUBgGIAMoCzIRLlRyYWluVmlzaXRvckluZm9CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			TrainVisitorInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetTrainVisitorRegisterScRsp), GetTrainVisitorRegisterScRsp.Parser, new string[]
			{
				"Retcode",
				"BHJEIMILLPF",
				"JBMPEGPPCHP"
			}, null, null, null, null)
		}));
	}
}
