using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200076E RID: 1902
	public static class GetPlayerReplayInfoScRspReflection
	{
		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06005502 RID: 21762 RVA: 0x000E46AE File Offset: 0x000E28AE
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlayerReplayInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04002157 RID: 8535
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRQbGF5ZXJSZXBsYXlJbmZvU2NSc3AucHJvdG8aEFJlcGxheUluZm8u" + "cHJvdG8iTQoYR2V0UGxheWVyUmVwbGF5SW5mb1NjUnNwEiAKC0NISUZFR05Q" + "UEpQGAIgAygLMgsuUmVwbGF5SW5mbxIPCgdyZXRjb2RlGA4gASgNQh6qAhtF" + "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ReplayInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerReplayInfoScRsp), GetPlayerReplayInfoScRsp.Parser, new string[]
			{
				"CHIFEGNPPJP",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
