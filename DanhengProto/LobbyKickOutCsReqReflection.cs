using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A44 RID: 2628
	public static class LobbyKickOutCsReqReflection
	{
		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x00136370 File Offset: 0x00134570
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyKickOutCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002CE1 RID: 11489
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2JieUtpY2tPdXRDc1JlcS5wcm90byIgChFMb2JieUtpY2tPdXRDc1Jl" + "cRILCgN1aWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyKickOutCsReq), LobbyKickOutCsReq.Parser, new string[]
			{
				"Uid"
			}, null, null, null, null)
		}));
	}
}
