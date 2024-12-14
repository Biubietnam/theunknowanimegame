using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000238 RID: 568
	public static class ChessRogueLeaveScRspReflection
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x0004A61E File Offset: 0x0004881E
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueLeaveScRspReflection.descriptor;
			}
		}

		// Token: 0x04000ADF RID: 2783
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpDaGVzc1JvZ3VlTGVhdmVTY1JzcC5wcm90bxoXQ2hlc3NSb2d1ZUdldElu",
			"Zm8ucHJvdG8aGUNoZXNzUm9ndWVRdWVyeUluZm8ucHJvdG8aFENoZXNzUm9n",
			"dWVJbmZvLnByb3RvGhhDaGVzc1JvZ3VlQWVvbkluZm8ucHJvdG8i0AEKFENo",
			"ZXNzUm9ndWVMZWF2ZVNjUnNwEioKDnJvZ3VlX2dldF9pbmZvGAYgASgLMhIu",
			"Q2hlc3NSb2d1ZUdldEluZm8SIwoKc3RhZ2VfaW5mbxgJIAEoCzIPLkNoZXNz",
			"Um9ndWVJbmZvEg8KB3JldGNvZGUYDSABKA0SLAoPcm9ndWVfYWVvbl9pbmZv",
			"GAUgASgLMhMuQ2hlc3NSb2d1ZUFlb25JbmZvEigKCnF1ZXJ5X2luZm8YCyAB",
			"KAsyFC5DaGVzc1JvZ3VlUXVlcnlJbmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
			"ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueGetInfoReflection.Descriptor,
			ChessRogueQueryInfoReflection.Descriptor,
			ChessRogueInfoReflection.Descriptor,
			ChessRogueAeonInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueLeaveScRsp), ChessRogueLeaveScRsp.Parser, new string[]
			{
				"RogueGetInfo",
				"StageInfo",
				"Retcode",
				"RogueAeonInfo",
				"QueryInfo"
			}, null, null, null, null)
		}));
	}
}
