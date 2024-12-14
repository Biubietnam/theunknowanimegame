using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200006E RID: 110
	public static class AetherDivideTakeChallengeRewardScRspReflection
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000D932 File Offset: 0x0000BB32
		public static FileDescriptor Descriptor
		{
			get
			{
				return AetherDivideTakeChallengeRewardScRspReflection.descriptor;
			}
		}

		// Token: 0x040001B4 RID: 436
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipBZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AucHJvdG8a",
			"Dkl0ZW1MaXN0LnByb3RvImgKJEFldGhlckRpdmlkZVRha2VDaGFsbGVuZ2VS",
			"ZXdhcmRTY1JzcBIZCgZyZXdhcmQYCiABKAsyCS5JdGVtTGlzdBIPCgdyZXRj",
			"b2RlGAsgASgNEhQKDGNoYWxsZW5nZV9pZBgNIAEoDUIeqgIbRWdnTGluay5E",
			"YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideTakeChallengeRewardScRsp), AetherDivideTakeChallengeRewardScRsp.Parser, new string[]
			{
				"Reward",
				"Retcode",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
