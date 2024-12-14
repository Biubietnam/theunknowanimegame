using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200010A RID: 266
	public static class BattleTargetListReflection
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000243BF File Offset: 0x000225BF
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleTargetListReflection.descriptor;
			}
		}

		// Token: 0x04000541 RID: 1345
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCYXR0bGVUYXJnZXRMaXN0LnByb3RvGhJCYXR0bGVUYXJnZXQucHJvdG8i" + "PQoQQmF0dGxlVGFyZ2V0TGlzdBIpChJiYXR0bGVfdGFyZ2V0X2xpc3QYASAD" + "KAsyDS5CYXR0bGVUYXJnZXRCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			BattleTargetReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleTargetList), BattleTargetList.Parser, new string[]
			{
				"BattleTargetList_"
			}, null, null, null, null)
		}));
	}
}
