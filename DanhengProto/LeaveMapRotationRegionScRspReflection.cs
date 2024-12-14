using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F8 RID: 2552
	public static class LeaveMapRotationRegionScRspReflection
	{
		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x0012D916 File Offset: 0x0012BB16
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveMapRotationRegionScRspReflection.descriptor;
			}
		}

		// Token: 0x04002B96 RID: 11158
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFMZWF2ZU1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu",
			"Zm8ucHJvdG8iZwobTGVhdmVNYXBSb3RhdGlvblJlZ2lvblNjUnNwEg8KB3Jl",
			"dGNvZGUYCCABKA0SGwoGbW90aW9uGAMgASgLMgsuTW90aW9uSW5mbxIaChJj",
			"bGllbnRfcG9zX3ZlcnNpb24YByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveMapRotationRegionScRsp), LeaveMapRotationRegionScRsp.Parser, new string[]
			{
				"Retcode",
				"Motion",
				"ClientPosVersion"
			}, null, null, null, null)
		}));
	}
}
