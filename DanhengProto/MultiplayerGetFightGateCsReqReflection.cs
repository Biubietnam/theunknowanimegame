using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB0 RID: 2992
	public static class MultiplayerGetFightGateCsReqReflection
	{
		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x0015D5CE File Offset: 0x0015B7CE
		public static FileDescriptor Descriptor
		{
			get
			{
				return MultiplayerGetFightGateCsReqReflection.descriptor;
			}
		}

		// Token: 0x040032AD RID: 12973
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNdWx0aXBsYXllckdldEZpZ2h0R2F0ZUNzUmVxLnByb3RvIjMKHE11bHRp" + "cGxheWVyR2V0RmlnaHRHYXRlQ3NSZXESEwoLcGxheWVyX2RhdGEYCCABKA1C" + "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MultiplayerGetFightGateCsReq), MultiplayerGetFightGateCsReq.Parser, new string[]
			{
				"PlayerData"
			}, null, null, null, null)
		}));
	}
}
