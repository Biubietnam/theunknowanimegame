using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200093E RID: 2366
	public static class InterruptMissionEventCsReqReflection
	{
		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x0600699E RID: 27038 RVA: 0x00119E77 File Offset: 0x00118077
		public static FileDescriptor Descriptor
		{
			get
			{
				return InterruptMissionEventCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002877 RID: 10359
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBJbnRlcnJ1cHRNaXNzaW9uRXZlbnRDc1JlcS5wcm90byI2ChpJbnRlcnJ1" + "cHRNaXNzaW9uRXZlbnRDc1JlcRIYChBtaXNzaW9uX2V2ZW50X2lkGAIgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InterruptMissionEventCsReq), InterruptMissionEventCsReq.Parser, new string[]
			{
				"MissionEventId"
			}, null, null, null, null)
		}));
	}
}
