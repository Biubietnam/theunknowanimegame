using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F7E RID: 3966
	public static class RogueTournAreaInfoReflection
	{
		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600B0A1 RID: 45217 RVA: 0x001DA781 File Offset: 0x001D8981
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournAreaInfoReflection.descriptor;
			}
		}

		// Token: 0x040047DF RID: 18399
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZVRvdXJuQXJlYUluZm8ucHJvdG8ilAEKElJvZ3VlVG91cm5BcmVh",
			"SW5mbxImCh51bmxvY2tlZF90b3Vybl9kaWZmaWN1bHR5X2xpc3QYDCADKA0S",
			"FwoPaXNfdGFrZW5fcmV3YXJkGAYgASgIEg8KB2FyZWFfaWQYBSABKA0SFwoP",
			"aXNfdG91cm5fZmluaXNoGA8gASgIEhMKC2lzX3VubG9ja2VkGAcgASgIQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournAreaInfo), RogueTournAreaInfo.Parser, new string[]
			{
				"UnlockedTournDifficultyList",
				"IsTakenReward",
				"AreaId",
				"IsTournFinish",
				"IsUnlocked"
			}, null, null, null, null)
		}));
	}
}
