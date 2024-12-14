using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C6 RID: 454
	public static class ChangeLineupLeaderCsReqReflection
	{
		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0003AC88 File Offset: 0x00038E88
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChangeLineupLeaderCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000895 RID: 2197
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGFuZ2VMaW5ldXBMZWFkZXJDc1JlcS5wcm90byInChdDaGFuZ2VMaW5l" + "dXBMZWFkZXJDc1JlcRIMCgRzbG90GA8gASgNQh6qAhtFZ2dMaW5rLkRhbmhl" + "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChangeLineupLeaderCsReq), ChangeLineupLeaderCsReq.Parser, new string[]
			{
				"Slot"
			}, null, null, null, null)
		}));
	}
}
