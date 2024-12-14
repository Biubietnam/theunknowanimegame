using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000204 RID: 516
	public static class ChessRogueDiceInfoReflection
	{
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00041EA8 File Offset: 0x000400A8
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceInfoReflection.descriptor;
			}
		}

		// Token: 0x040009B4 RID: 2484
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhDaGVzc1JvZ3VlRGljZUluZm8ucHJvdG8aEUpQRUdPR05EUEpKLnByb3Rv",
			"GhNSb2d1ZU1vZGlmaWVyLnByb3RvGhpDaGVzc1JvZ3VlRGljZVN0YXR1cy5w",
			"cm90bxoYQ2hlc3NSb2d1ZURpY2VUeXBlLnByb3RvGhRDaGVzc1JvZ3VlRGlj",
			"ZS5wcm90byLuAwoSQ2hlc3NSb2d1ZURpY2VJbmZvEhMKC2NoZWF0X3RpbWVz",
			"GAsgASgNEhsKE2dhbWVfZGljZV9icmFuY2hfaWQYDSABKA0SFAoLSEhDSk5K",
			"S0pJS0YY7gIgASgFEhMKC0hFTENNQkRDRUNIGAYgASgNEhMKC0FNRkJEREFD",
			"SEtCGAkgASgIEiIKC0lQTkZISkVGR0FNGOwKIAEoCzIMLkpQRUdPR05EUEpK",
			"Eh4KBGRpY2UYjAQgASgLMg8uQ2hlc3NSb2d1ZURpY2USEwoLTEpERENCTktF",
			"Qk4YDiABKA0SFAoMcmVyb2xsX3RpbWVzGAUgASgNEhgKD2Nhbl9yZXJvbGxf",
			"ZGljZRiSCiABKAgSKgoLZGljZV9zdGF0dXMYByABKA4yFS5DaGVzc1JvZ3Vl",
			"RGljZVN0YXR1cxImCglkaWNlX3R5cGUYBCABKA4yEy5DaGVzc1JvZ3VlRGlj",
			"ZVR5cGUSFgoOY3VyX3N1cmZhY2VfaWQYAyABKA0SGwoTY3VyX3N1cmZhY2Vf",
			"c2xvdF9pZBgCIAEoDRImCg1kaWNlX21vZGlmaWVyGOsHIAEoCzIOLlJvZ3Vl",
			"TW9kaWZpZXISFAoLQUpNTEdJQ0FHQkQY0gIgAygNEhYKDmdhbWVfYnJhbmNo",
			"X2lkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			JPEGOGNDPJJReflection.Descriptor,
			RogueModifierReflection.Descriptor,
			ChessRogueDiceStatusReflection.Descriptor,
			ChessRogueDiceTypeReflection.Descriptor,
			ChessRogueDiceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueDiceInfo), ChessRogueDiceInfo.Parser, new string[]
			{
				"CheatTimes",
				"GameDiceBranchId",
				"HHCJNJKJIKF",
				"HELCMBDCECH",
				"AMFBDDACHKB",
				"IPNFHJEFGAM",
				"Dice",
				"LJDDCBNKEBN",
				"RerollTimes",
				"CanRerollDice",
				"DiceStatus",
				"DiceType",
				"CurSurfaceId",
				"CurSurfaceSlotId",
				"DiceModifier",
				"AJMLGICAGBD",
				"GameBranchId"
			}, null, null, null, null)
		}));
	}
}
