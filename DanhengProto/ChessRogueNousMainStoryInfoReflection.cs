using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200025C RID: 604
	public static class ChessRogueNousMainStoryInfoReflection
	{
		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x0004E393 File Offset: 0x0004C593
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousMainStoryInfoReflection.descriptor;
			}
		}

		// Token: 0x04000B6D RID: 2925
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiFDaGVzc1JvZ3VlTm91c01haW5TdG9yeUluZm8ucHJvdG8aI0NoZXNzUm9n",
			"dWVOb3VzTWFpblN0b3J5U3RhdHVzLnByb3RvInAKG0NoZXNzUm9ndWVOb3Vz",
			"TWFpblN0b3J5SW5mbxIhChljaGVzc19yb2d1ZV9tYWluX3N0b3J5X2lkGAMg",
			"ASgNEi4KBnN0YXR1cxgHIAEoDjIeLkNoZXNzUm9ndWVOb3VzTWFpblN0b3J5",
			"U3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
			"Mw=="
		})), new FileDescriptor[]
		{
			ChessRogueNousMainStoryStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueNousMainStoryInfo), ChessRogueNousMainStoryInfo.Parser, new string[]
			{
				"ChessRogueMainStoryId",
				"Status"
			}, null, null, null, null)
		}));
	}
}
