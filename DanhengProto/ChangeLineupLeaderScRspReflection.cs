using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C8 RID: 456
	public static class ChangeLineupLeaderScRspReflection
	{
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0003AEF6 File Offset: 0x000390F6
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChangeLineupLeaderScRspReflection.descriptor;
			}
		}

		// Token: 0x0400089A RID: 2202
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGFuZ2VMaW5ldXBMZWFkZXJTY1JzcC5wcm90byI4ChdDaGFuZ2VMaW5l" + "dXBMZWFkZXJTY1JzcBIMCgRzbG90GAQgASgNEg8KB3JldGNvZGUYDCABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChangeLineupLeaderScRsp), ChangeLineupLeaderScRsp.Parser, new string[]
			{
				"Slot",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
