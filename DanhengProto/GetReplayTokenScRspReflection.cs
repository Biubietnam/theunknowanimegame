using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200079A RID: 1946
	public static class GetReplayTokenScRspReflection
	{
		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x000E9142 File Offset: 0x000E7342
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetReplayTokenScRspReflection.descriptor;
			}
		}

		// Token: 0x04002204 RID: 8708
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlHZXRSZXBsYXlUb2tlblNjUnNwLnByb3RvGhBSZXBsYXlUeXBlLnByb3Rv",
			"In4KE0dldFJlcGxheVRva2VuU2NSc3ASEAoIc3RhZ2VfaWQYDCABKA0SEwoL",
			"Qk5DT09EQUhIUEMYDSABKAkSDwoHcmV0Y29kZRgIIAEoDRIgCgtyZXBsYXlf",
			"dHlwZRgGIAEoDjILLlJlcGxheVR5cGUSDQoFdG9rZW4YByABKAlCHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ReplayTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetReplayTokenScRsp), GetReplayTokenScRsp.Parser, new string[]
			{
				"StageId",
				"BNCOODAHHPC",
				"Retcode",
				"ReplayType",
				"Token"
			}, null, null, null, null)
		}));
	}
}
