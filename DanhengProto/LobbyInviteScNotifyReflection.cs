using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3C RID: 2620
	public static class LobbyInviteScNotifyReflection
	{
		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600744A RID: 29770 RVA: 0x00135393 File Offset: 0x00133593
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbyInviteScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002CBD RID: 11453
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlMb2JieUludml0ZVNjTm90aWZ5LnByb3RvGhNGaWdodEdhbWVNb2RlLnBy",
			"b3RvIl4KE0xvYmJ5SW52aXRlU2NOb3RpZnkSIwoLTUdBSUFKQUtQRUkYCyAB",
			"KA4yDi5GaWdodEdhbWVNb2RlEg8KB3Jvb21faWQYAyABKA0SEQoJc2VuZGVy",
			"X2lkGAUgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
			"b3RvMw=="
		})), new FileDescriptor[]
		{
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbyInviteScNotify), LobbyInviteScNotify.Parser, new string[]
			{
				"MGAIAJAKPEI",
				"RoomId",
				"SenderId"
			}, null, null, null, null)
		}));
	}
}
