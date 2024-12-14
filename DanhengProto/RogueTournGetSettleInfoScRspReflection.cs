using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD6 RID: 4054
	public static class RogueTournGetSettleInfoScRspReflection
	{
		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600B49D RID: 46237 RVA: 0x001E4926 File Offset: 0x001E2B26
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournGetSettleInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x0400492F RID: 18735
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJSb2d1ZVRvdXJuR2V0U2V0dGxlSW5mb1NjUnNwLnByb3RvGhpSb2d1ZVRv",
			"dXJuRmluaXNoSW5mby5wcm90byJhChxSb2d1ZVRvdXJuR2V0U2V0dGxlSW5m",
			"b1NjUnNwEjAKEXRvdXJuX2ZpbmlzaF9pbmZvGAQgASgLMhUuUm9ndWVUb3Vy",
			"bkZpbmlzaEluZm8SDwoHcmV0Y29kZRgFIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournFinishInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetSettleInfoScRsp), RogueTournGetSettleInfoScRsp.Parser, new string[]
			{
				"TournFinishInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
