using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200076A RID: 1898
	public static class GetPlayerDetailInfoScRspReflection
	{
		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x000E414A File Offset: 0x000E234A
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPlayerDetailInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400214D RID: 8525
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5HZXRQbGF5ZXJEZXRhaWxJbmZvU2NSc3AucHJvdG8aFlBsYXllckRldGFp",
			"bEluZm8ucHJvdG8iUwoYR2V0UGxheWVyRGV0YWlsSW5mb1NjUnNwEiYKC2Rl",
			"dGFpbF9pbmZvGAggASgLMhEuUGxheWVyRGV0YWlsSW5mbxIPCgdyZXRjb2Rl",
			"GAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			PlayerDetailInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerDetailInfoScRsp), GetPlayerDetailInfoScRsp.Parser, new string[]
			{
				"DetailInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
