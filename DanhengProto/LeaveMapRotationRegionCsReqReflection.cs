using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F4 RID: 2548
	public static class LeaveMapRotationRegionCsReqReflection
	{
		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06007122 RID: 28962 RVA: 0x0012D49E File Offset: 0x0012B69E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveMapRotationRegionCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002B8E RID: 11150
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFMZWF2ZU1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu" + "Zm8ucHJvdG8iOgobTGVhdmVNYXBSb3RhdGlvblJlZ2lvbkNzUmVxEhsKBm1v" + "dGlvbhgIIAEoCzILLk1vdGlvbkluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl" + "cnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveMapRotationRegionCsReq), LeaveMapRotationRegionCsReq.Parser, new string[]
			{
				"Motion"
			}, null, null, null, null)
		}));
	}
}
