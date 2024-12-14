using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000668 RID: 1640
	public static class GetCrossInfoScRspReflection
	{
		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06004986 RID: 18822 RVA: 0x000C8766 File Offset: 0x000C6966
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetCrossInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001D45 RID: 7493
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRDcm9zc0luZm9TY1JzcC5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90",
			"byJvChFHZXRDcm9zc0luZm9TY1JzcBIPCgdyb29tX2lkGA4gASgEEiMKC01H",
			"QUlBSkFLUEVJGAggASgOMg4uRmlnaHRHYW1lTW9kZRIPCgdyZXRjb2RlGAkg",
			"ASgNEhMKC0dDSUdKRElNTkNFGA0gASgEQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetCrossInfoScRsp), GetCrossInfoScRsp.Parser, new string[]
			{
				"RoomId",
				"MGAIAJAKPEI",
				"Retcode",
				"GCIGJDIMNCE"
			}, null, null, null, null)
		}));
	}
}
