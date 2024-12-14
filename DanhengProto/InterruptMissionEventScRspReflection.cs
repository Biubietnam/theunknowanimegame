using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000940 RID: 2368
	public static class InterruptMissionEventScRspReflection
	{
		// Token: 0x17001DB7 RID: 7607
		// (get) Token: 0x060069B3 RID: 27059 RVA: 0x0011A0E6 File Offset: 0x001182E6
		public static FileDescriptor Descriptor
		{
			get
			{
				return InterruptMissionEventScRspReflection.descriptor;
			}
		}

		// Token: 0x0400287C RID: 10364
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBJbnRlcnJ1cHRNaXNzaW9uRXZlbnRTY1JzcC5wcm90byJHChpJbnRlcnJ1" + "cHRNaXNzaW9uRXZlbnRTY1JzcBIYChBtaXNzaW9uX2V2ZW50X2lkGAsgASgN" + "Eg8KB3JldGNvZGUYBiABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InterruptMissionEventScRsp), InterruptMissionEventScRsp.Parser, new string[]
			{
				"MissionEventId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
