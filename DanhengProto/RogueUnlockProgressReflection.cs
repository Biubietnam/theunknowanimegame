using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200102A RID: 4138
	public static class RogueUnlockProgressReflection
	{
		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600B7F8 RID: 47096 RVA: 0x001ED9C7 File Offset: 0x001EBBC7
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueUnlockProgressReflection.descriptor;
			}
		}

		// Token: 0x04004A8A RID: 19082
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSb2d1ZVVubG9ja1Byb2dyZXNzLnByb3RvIkkKE1JvZ3VlVW5sb2NrUHJv" + "Z3Jlc3MSEAoIVW5sb2NrSWQYByABKA0SEAoIcHJvZ3Jlc3MYDSABKA0SDgoG" + "RmluaXNoGAwgASgIQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueUnlockProgress), RogueUnlockProgress.Parser, new string[]
			{
				"UnlockId",
				"Progress",
				"Finish"
			}, null, null, null, null)
		}));
	}
}
