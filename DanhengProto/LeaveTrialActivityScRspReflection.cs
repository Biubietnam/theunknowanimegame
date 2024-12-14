using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A04 RID: 2564
	public static class LeaveTrialActivityScRspReflection
	{
		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x0012EDC2 File Offset: 0x0012CFC2
		public static FileDescriptor Descriptor
		{
			get
			{
				return LeaveTrialActivityScRspReflection.descriptor;
			}
		}

		// Token: 0x04002BC0 RID: 11200
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1MZWF2ZVRyaWFsQWN0aXZpdHlTY1JzcC5wcm90byI8ChdMZWF2ZVRyaWFs" + "QWN0aXZpdHlTY1JzcBIQCghzdGFnZV9pZBgJIAEoDRIPCgdyZXRjb2RlGAUg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LeaveTrialActivityScRsp), LeaveTrialActivityScRsp.Parser, new string[]
			{
				"StageId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
