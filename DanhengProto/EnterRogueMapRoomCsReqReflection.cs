using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000458 RID: 1112
	public static class EnterRogueMapRoomCsReqReflection
	{
		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000882AA File Offset: 0x000864AA
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnterRogueMapRoomCsReqReflection.descriptor;
			}
		}

		// Token: 0x040013B7 RID: 5047
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxFbnRlclJvZ3VlTWFwUm9vbUNzUmVxLnByb3RvIjoKFkVudGVyUm9ndWVN" + "YXBSb29tQ3NSZXESDwoHcm9vbV9pZBgKIAEoDRIPCgdzaXRlX2lkGA0gASgN" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueMapRoomCsReq), EnterRogueMapRoomCsReq.Parser, new string[]
			{
				"RoomId",
				"SiteId"
			}, null, null, null, null)
		}));
	}
}
