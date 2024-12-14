using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001006 RID: 4102
	public static class RogueTournResetPermanentTalentScRspReflection
	{
		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600B68B RID: 46731 RVA: 0x001E9B66 File Offset: 0x001E7D66
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournResetPermanentTalentScRspReflection.descriptor;
			}
		}

		// Token: 0x040049F4 RID: 18932
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CilSb2d1ZVRvdXJuUmVzZXRQZXJtYW5lbnRUYWxlbnRTY1JzcC5wcm90bxoj",
			"Um9ndWVUb3VyblBlcm1hbmVudFRhbGVudEluZm8ucHJvdG8ibgojUm9ndWVU",
			"b3VyblJlc2V0UGVybWFuZW50VGFsZW50U2NSc3ASDwoHcmV0Y29kZRgCIAEo",
			"DRI2Cg5wZXJtYW5lbnRfaW5mbxgLIAEoCzIeLlJvZ3VlVG91cm5QZXJtYW5l",
			"bnRUYWxlbnRJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueTournPermanentTalentInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournResetPermanentTalentScRsp), RogueTournResetPermanentTalentScRsp.Parser, new string[]
			{
				"Retcode",
				"PermanentInfo"
			}, null, null, null, null)
		}));
	}
}
