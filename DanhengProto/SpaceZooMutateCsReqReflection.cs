using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200116A RID: 4458
	public static class SpaceZooMutateCsReqReflection
	{
		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600C6EC RID: 50924 RVA: 0x00215E69 File Offset: 0x00214069
		public static FileDescriptor Descriptor
		{
			get
			{
				return SpaceZooMutateCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400505F RID: 20575
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTcGFjZVpvb011dGF0ZUNzUmVxLnByb3RvIjkKE1NwYWNlWm9vTXV0YXRl" + "Q3NSZXESDwoHaXRlbV9pZBgGIAEoDRIRCgl1bmlxdWVfaWQYDyABKA1CHqoC" + "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooMutateCsReq), SpaceZooMutateCsReq.Parser, new string[]
			{
				"ItemId",
				"UniqueId"
			}, null, null, null, null)
		}));
	}
}
