using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001C RID: 28
	public static class AcceptMissionEventCsReqReflection
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00004418 File Offset: 0x00002618
		public static FileDescriptor Descriptor
		{
			get
			{
				return AcceptMissionEventCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000056 RID: 86
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1BY2NlcHRNaXNzaW9uRXZlbnRDc1JlcS5wcm90byIzChdBY2NlcHRNaXNz" + "aW9uRXZlbnRDc1JlcRIYChBtaXNzaW9uX2V2ZW50X2lkGAEgASgNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AcceptMissionEventCsReq), AcceptMissionEventCsReq.Parser, new string[]
			{
				"MissionEventId"
			}, null, null, null, null)
		}));
	}
}
