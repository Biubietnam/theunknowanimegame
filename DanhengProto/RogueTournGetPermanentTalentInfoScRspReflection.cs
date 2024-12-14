using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD2 RID: 4050
	public static class RogueTournGetPermanentTalentInfoScRspReflection
	{
		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600B471 RID: 46193 RVA: 0x001E42FE File Offset: 0x001E24FE
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournGetPermanentTalentInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004923 RID: 18723
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitSb2d1ZVRvdXJuR2V0UGVybWFuZW50VGFsZW50SW5mb1NjUnNwLnByb3Rv",
			"GiNSb2d1ZVRvdXJuUGVybWFuZW50VGFsZW50SW5mby5wcm90byJwCiVSb2d1",
			"ZVRvdXJuR2V0UGVybWFuZW50VGFsZW50SW5mb1NjUnNwEjYKDnBlcm1hbmVu",
			"dF9pbmZvGAEgASgLMh4uUm9ndWVUb3VyblBlcm1hbmVudFRhbGVudEluZm8S",
			"DwoHcmV0Y29kZRgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
			"b3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			RogueTournPermanentTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetPermanentTalentInfoScRsp), RogueTournGetPermanentTalentInfoScRsp.Parser, new string[]
			{
				"PermanentInfo",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
