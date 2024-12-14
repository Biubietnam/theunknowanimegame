using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000232 RID: 562
	public static class ChessRogueLayerAccountInfoNotifyReflection
	{
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00049AE7 File Offset: 0x00047CE7
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueLayerAccountInfoNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000AC6 RID: 2758
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZDaGVzc1JvZ3VlTGF5ZXJBY2NvdW50SW5mb05vdGlmeS5wcm90bxoZQ2hl",
			"c3NSb2d1ZUxldmVsSW5mby5wcm90bxoaQ2hlc3NSb2d1ZUZpbmlzaEluZm8u",
			"cHJvdG8iuQEKIENoZXNzUm9ndWVMYXllckFjY291bnRJbmZvTm90aWZ5EhAK",
			"CGxheWVyX2lkGAkgASgNEhMKC0hCTEhQT0xFREdBGAQgAygNEigKCmxldmVs",
			"X2luZm8YBiABKAsyFC5DaGVzc1JvZ3VlTGV2ZWxJbmZvEhgKEGRpZmZpY3Vs",
			"dHlfbGV2ZWwYCyABKA0SKgoLZmluaXNoX2luZm8YCCABKAsyFS5DaGVzc1Jv",
			"Z3VlRmluaXNoSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
			"YgZwcm90bzM="
		})), new FileDescriptor[]
		{
			ChessRogueLevelInfoReflection.Descriptor,
			ChessRogueFinishInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLayerAccountInfoNotify), ChessRogueLayerAccountInfoNotify.Parser, new string[]
			{
				"LayerId",
				"HBLHPOLEDGA",
				"LevelInfo",
				"DifficultyLevel",
				"FinishInfo"
			}, null, null, null, null)
		}));
	}
}
