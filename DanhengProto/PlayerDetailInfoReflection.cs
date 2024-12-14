using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB4 RID: 3252
	public static class PlayerDetailInfoReflection
	{
		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x060090A1 RID: 37025 RVA: 0x0017E198 File Offset: 0x0017C398
		public static FileDescriptor Descriptor
		{
			get
			{
				return PlayerDetailInfoReflection.descriptor;
			}
		}

		// Token: 0x0400379C RID: 14236
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZQbGF5ZXJEZXRhaWxJbmZvLnByb3RvGhVQcml2YWN5U2V0dGluZ3MucHJv",
			"dG8aG1BsYXllckRpc3BsYXlTZXR0aW5ncy5wcm90bxodRGlzcGxheUF2YXRh",
			"ckRldGFpbEluZm8ucHJvdG8aElBsYXRmb3JtVHlwZS5wcm90bxoWUGxheWVy",
			"UmVjb3JkSW5mby5wcm90byKJBAoQUGxheWVyRGV0YWlsSW5mbxITCgt3b3Js",
			"ZF9sZXZlbBgIIAEoDRIRCglpc19iYW5uZWQYDyABKAgSDQoFbGV2ZWwYDSAB",
			"KA0SEQoJc2lnbmF0dXJlGAQgASgJEiwKC1BMQ0xKRUZBSElNGJANIAEoCzIW",
			"LlBsYXllckRpc3BsYXlTZXR0aW5ncxITCgtNRU9ER0NDQVBMRhgHIAEoDRIf",
			"CghwbGF0Zm9ybRgKIAEoDjINLlBsYXRmb3JtVHlwZRIRCgloZWFkX2ljb24Y",
			"AiABKA0SCwoDdWlkGAUgASgNEjQKEmFzc2lzdF9hdmF0YXJfbGlzdBgOIAMo",
			"CzIYLkRpc3BsYXlBdmF0YXJEZXRhaWxJbmZvEhMKC0ZMRktDSUhDRU5GGAYg",
			"ASgJEisKEHByaXZhY3lfc2V0dGluZ3MY+wMgASgLMhAuUHJpdmFjeVNldHRp",
			"bmdzEjYKE2Rpc3BsYXlfYXZhdGFyX2xpc3QY1AIgAygLMhguRGlzcGxheUF2",
			"YXRhckRldGFpbEluZm8SEwoLSEZIR1BMTUVGR0oYDCABKAkSEwoLUE1QTEhN",
			"RU5NUEkYAyABKAgSJgoLcmVjb3JkX2luZm8YCyABKAsyES5QbGF5ZXJSZWNv",
			"cmRJbmZvEhAKCG5pY2tuYW1lGAEgASgJEhMKC0VKSFBQSFBDSUVNGAkgASgN",
			"Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PrivacySettingsReflection.Descriptor,
			PlayerDisplaySettingsReflection.Descriptor,
			DisplayAvatarDetailInfoReflection.Descriptor,
			PlatformTypeReflection.Descriptor,
			PlayerRecordInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PlayerDetailInfo), PlayerDetailInfo.Parser, new string[]
			{
				"WorldLevel",
				"IsBanned",
				"Level",
				"Signature",
				"PLCLJEFAHIM",
				"MEODGCCAPLF",
				"Platform",
				"HeadIcon",
				"Uid",
				"AssistAvatarList",
				"FLFKCIHCENF",
				"PrivacySettings",
				"DisplayAvatarList",
				"HFHGPLMEFGJ",
				"PMPLHMENMPI",
				"RecordInfo",
				"Nickname",
				"EJHPPHPCIEM"
			}, null, null, null, null)
		}));
	}
}
