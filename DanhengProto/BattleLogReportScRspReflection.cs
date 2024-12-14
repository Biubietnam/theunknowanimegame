using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000EA RID: 234
	public static class BattleLogReportScRspReflection
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0001EA4A File Offset: 0x0001CC4A
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleLogReportScRspReflection.descriptor;
			}
		}

		// Token: 0x04000452 RID: 1106
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpCYXR0bGVMb2dSZXBvcnRTY1JzcC5wcm90byJFChRCYXR0bGVMb2dSZXBv" + "cnRTY1JzcBIPCgdyZXRjb2RlGAMgASgNEhwKFGlzX2JhdHRsZV9sb2dfcmVw" + "b3J0GAYgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleLogReportScRsp), BattleLogReportScRsp.Parser, new string[]
			{
				"Retcode",
				"IsBattleLogReport"
			}, null, null, null, null)
		}));
	}
}
