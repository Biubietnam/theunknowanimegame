using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CC8 RID: 3272
	public static class PlayerLoginScRspReflection
	{
		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x00182D32 File Offset: 0x00180F32
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerLoginScRspReflection.descriptor;
			}
		}

		// Token: 0x04003847 RID: 14407
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZQbGF5ZXJMb2dpblNjUnNwLnByb3RvGhVQbGF5ZXJCYXNpY0luZm8ucHJv",
			"dG8i9wEKEFBsYXllckxvZ2luU2NSc3ASJAoKYmFzaWNfaW5mbxgEIAEoCzIQ",
			"LlBsYXllckJhc2ljSW5mbxITCgtOREZFQUVJSEJGShgGIAEoCRIPCgdyZXRj",
			"b2RlGAogASgNEhQKDGN1cl90aW1lem9uZRgHIAEoBRIbChNzZXJ2ZXJfdGlt",
			"ZXN0YW1wX21zGAggASgEEg8KB3N0YW1pbmEYDiABKA0SFAoMbG9naW5fcmFu",
			"ZG9tGAIgASgEEhMKC0xKTUZPSExPQkNJGAMgASgIEhMKC0RNQUFNQU1DTktK",
			"GAwgASgJEhMKC0pPUFBBRU5ETUZKGAkgASgIQh6qAhtFZ2dMaW5rLkRhbmhl",
			"bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PlayerBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLoginScRsp), PlayerLoginScRsp.Parser, new string[]
			{
				"BasicInfo",
				"NDFEAEIHBFJ",
				"Retcode",
				"CurTimezone",
				"ServerTimestampMs",
				"Stamina",
				"LoginRandom",
				"LJMFOHLOBCI",
				"DMAAMAMCNKJ",
				"JOPPAENDMFJ"
			}, null, null, null, null)
		}));
	}
}
