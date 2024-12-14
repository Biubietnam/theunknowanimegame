using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C30 RID: 3120
	public static class NpcMeetByPerformanceStatusReflection
	{
		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x0016D317 File Offset: 0x0016B517
		public static FileDescriptor Descriptor
		{
			get
			{
				return NpcMeetByPerformanceStatusReflection.descriptor;
			}
		}

		// Token: 0x04003508 RID: 13576
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBOcGNNZWV0QnlQZXJmb3JtYW5jZVN0YXR1cy5wcm90byJFChpOcGNNZWV0" + "QnlQZXJmb3JtYW5jZVN0YXR1cxIPCgdpc19tZWV0GAsgASgIEhYKDnBlcmZv" + "cm1hbmNlX2lkGA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(NpcMeetByPerformanceStatus), NpcMeetByPerformanceStatus.Parser, new string[]
			{
				"IsMeet",
				"PerformanceId"
			}, null, null, null, null)
		}));
	}
}
