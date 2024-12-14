using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DCA RID: 3530
	public static class ResetMapRotationRegionScRspReflection
	{
		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x001A4897 File Offset: 0x001A2A97
		public static FileDescriptor Descriptor
		{
			get
			{
				return ResetMapRotationRegionScRspReflection.descriptor;
			}
		}

		// Token: 0x04003D5F RID: 15711
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFSZXNldE1hcFJvdGF0aW9uUmVnaW9uU2NSc3AucHJvdG8aEE1vdGlvbklu",
			"Zm8ucHJvdG8iZwobUmVzZXRNYXBSb3RhdGlvblJlZ2lvblNjUnNwEhoKEmNs",
			"aWVudF9wb3NfdmVyc2lvbhgFIAEoDRIPCgdyZXRjb2RlGAogASgNEhsKBm1v",
			"dGlvbhgGIAEoCzILLk1vdGlvbkluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
			"cnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ResetMapRotationRegionScRsp), ResetMapRotationRegionScRsp.Parser, new string[]
			{
				"ClientPosVersion",
				"Retcode",
				"Motion"
			}, null, null, null, null)
		}));
	}
}
