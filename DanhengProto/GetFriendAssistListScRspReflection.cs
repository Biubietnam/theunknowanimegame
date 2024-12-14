using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006B6 RID: 1718
	public static class GetFriendAssistListScRspReflection
	{
		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x000D08C2 File Offset: 0x000CEAC2
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFriendAssistListScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E6F RID: 7791
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRGcmllbmRBc3Npc3RMaXN0U2NSc3AucHJvdG8aFlBsYXllckFzc2lz",
			"dEluZm8ucHJvdG8iZwoYR2V0RnJpZW5kQXNzaXN0TGlzdFNjUnNwEhIKCnRh",
			"cmdldF91aWQYCyABKA0SDwoHcmV0Y29kZRgHIAEoDRImCgthc3Npc3RfbGlz",
			"dBgFIAMoCzIRLlBsYXllckFzc2lzdEluZm9CHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			PlayerAssistInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendAssistListScRsp), GetFriendAssistListScRsp.Parser, new string[]
			{
				"TargetUid",
				"Retcode",
				"AssistList"
			}, null, null, null, null)
		}));
	}
}
