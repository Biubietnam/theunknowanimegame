using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FC RID: 252
	public static class BattleRogueMagicRoundCountReflection
	{
		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00021561 File Offset: 0x0001F761
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicRoundCountReflection.descriptor;
			}
		}

		// Token: 0x040004BB RID: 1211
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBCYXR0bGVSb2d1ZU1hZ2ljUm91bmRDb3VudC5wcm90byJjChpCYXR0bGVS" + "b2d1ZU1hZ2ljUm91bmRDb3VudBIjChtiYXR0bGVfc3RhbmRhcmRfcm91bmRf" + "bGltaXQYASABKA0SIAoYYmF0dGxlX2V4dHJhX3JvdW5kX2xpbWl0GAIgASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleRogueMagicRoundCount), BattleRogueMagicRoundCount.Parser, new string[]
			{
				"BattleStandardRoundLimit",
				"BattleExtraRoundLimit"
			}, null, null, null, null)
		}));
	}
}
