using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000620 RID: 1568
	public static class GetAssistListScRspReflection
	{
		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x000C0719 File Offset: 0x000BE919
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetAssistListScRspReflection.descriptor;
			}
		}

		// Token: 0x04001C16 RID: 7190
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRBc3Npc3RMaXN0U2NSc3AucHJvdG8aFlBsYXllckFzc2lzdEluZm8u" + "cHJvdG8iTQoSR2V0QXNzaXN0TGlzdFNjUnNwEiYKC2Fzc2lzdF9saXN0GAgg" + "AygLMhEuUGxheWVyQXNzaXN0SW5mbxIPCgdyZXRjb2RlGA0gASgNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlayerAssistInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetAssistListScRsp), GetAssistListScRsp.Parser, new string[]
			{
				"AssistList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
