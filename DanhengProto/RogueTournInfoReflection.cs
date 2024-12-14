using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FDE RID: 4062
	public static class RogueTournInfoReflection
	{
		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600B4E6 RID: 46310 RVA: 0x001E5723 File Offset: 0x001E3923
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournInfoReflection.descriptor;
			}
		}

		// Token: 0x0400495A RID: 18778
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRSb2d1ZVRvdXJuSW5mby5wcm90bxoaUm9ndWVUb3VyblNlYXNvbkluZm8u",
			"cHJvdG8aFEV4dHJhU2NvcmVJbmZvLnByb3RvGhhSb2d1ZVRvdXJuU2F2ZUxp",
			"c3QucHJvdG8aF1JvZ3VlVG91cm5FeHBJbmZvLnByb3RvGhhSb2d1ZVRvdXJu",
			"QXJlYUluZm8ucHJvdG8aHlJvZ3VlVG91cm5EaWZmaWN1bHR5SW5mby5wcm90",
			"bxojUm9ndWVUb3VyblBlcm1hbmVudFRhbGVudEluZm8ucHJvdG8aHFJvZ3Vl",
			"VG91cm5IYW5kYm9va0luZm8ucHJvdG8itgMKDlJvZ3VlVG91cm5JbmZvEjAK",
			"EXJvZ3VlX3NlYXNvbl9pbmZvGA8gASgLMhUuUm9ndWVUb3VyblNlYXNvbklu",
			"Zm8SMAoUcm9ndWVfdG91cm5fZXhwX2luZm8YAyABKAsyEi5Sb2d1ZVRvdXJu",
			"RXhwSW5mbxI+Chtyb2d1ZV90b3Vybl9kaWZmaWN1bHR5X2luZm8YBCADKAsy",
			"GS5Sb2d1ZVRvdXJuRGlmZmljdWx0eUluZm8SNQoUcm9ndWVfdG91cm5faGFu",
			"ZGJvb2sYAiABKAsyFy5Sb2d1ZVRvdXJuSGFuZGJvb2tJbmZvEjYKDnBlcm1h",
			"bmVudF9pbmZvGAkgASgLMh4uUm9ndWVUb3VyblBlcm1hbmVudFRhbGVudElu",
			"Zm8SMgoVcm9ndWVfdG91cm5fc2F2ZV9saXN0GAwgAygLMhMuUm9ndWVUb3Vy",
			"blNhdmVMaXN0EjIKFXJvZ3VlX3RvdXJuX2FyZWFfaW5mbxgLIAMoCzITLlJv",
			"Z3VlVG91cm5BcmVhSW5mbxIpChBleHRyYV9zY29yZV9pbmZvGA0gASgLMg8u",
			"RXh0cmFTY29yZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournSeasonInfoReflection.Descriptor,
			ExtraScoreInfoReflection.Descriptor,
			RogueTournSaveListReflection.Descriptor,
			RogueTournExpInfoReflection.Descriptor,
			RogueTournAreaInfoReflection.Descriptor,
			RogueTournDifficultyInfoReflection.Descriptor,
			RogueTournPermanentTalentInfoReflection.Descriptor,
			RogueTournHandbookInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournInfo), RogueTournInfo.Parser, new string[]
			{
				"RogueSeasonInfo",
				"RogueTournExpInfo",
				"RogueTournDifficultyInfo",
				"RogueTournHandbook",
				"PermanentInfo",
				"RogueTournSaveList",
				"RogueTournAreaInfo",
				"ExtraScoreInfo"
			}, null, null, null, null)
		}));
	}
}
