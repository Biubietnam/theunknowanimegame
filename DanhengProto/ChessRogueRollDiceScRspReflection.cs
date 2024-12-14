using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000290 RID: 656
	public static class ChessRogueRollDiceScRspReflection
	{
		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00053E8E File Offset: 0x0005208E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueRollDiceScRspReflection.descriptor;
			}
		}

		// Token: 0x04000C3A RID: 3130
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1DaGVzc1JvZ3VlUm9sbERpY2VTY1JzcC5wcm90bxoYQ2hlc3NSb2d1ZURp",
			"Y2VJbmZvLnByb3RvIm0KF0NoZXNzUm9ndWVSb2xsRGljZVNjUnNwEhMKC0pE",
			"SEJITk1QSVBJGAEgASgNEg8KB3JldGNvZGUYCiABKA0SLAoPcm9ndWVfZGlj",
			"ZV9pbmZvGAwgASgLMhMuQ2hlc3NSb2d1ZURpY2VJbmZvQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueDiceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueRollDiceScRsp), ChessRogueRollDiceScRsp.Parser, new string[]
			{
				"JDHBHNMPIPI",
				"Retcode",
				"RogueDiceInfo"
			}, null, null, null, null)
		}));
	}
}
