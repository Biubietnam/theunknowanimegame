using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F2 RID: 2034
	public static class GetShareDataScRspReflection
	{
		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x000F1CC6 File Offset: 0x000EFEC6
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetShareDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04002331 RID: 9009
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRTaGFyZURhdGFTY1JzcC5wcm90bxoPU2hhcmVEYXRhLnByb3RvIkUK" + "EUdldFNoYXJlRGF0YVNjUnNwEh8KC0tPTE9QUEhOSFBFGAYgAygLMgouU2hh" + "cmVEYXRhEg8KB3JldGNvZGUYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ShareDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetShareDataScRsp), GetShareDataScRsp.Parser, new string[]
			{
				"KOLOPPHNHPE",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
