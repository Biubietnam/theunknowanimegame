using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F4 RID: 5108
	public static class UpdateRogueAdventureRoomScoreScRspReflection
	{
		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x0025DD7D File Offset: 0x0025BF7D
		public static FileDescriptor Descriptor
		{
			get
			{
				return UpdateRogueAdventureRoomScoreScRspReflection.descriptor;
			}
		}

		// Token: 0x04005A89 RID: 23177
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CihVcGRhdGVSb2d1ZUFkdmVudHVyZVJvb21TY29yZVNjUnNwLnByb3RvGhdB",
			"ZHZlbnR1cmVSb29tSW5mby5wcm90byJmCiJVcGRhdGVSb2d1ZUFkdmVudHVy",
			"ZVJvb21TY29yZVNjUnNwEg8KB3JldGNvZGUYDyABKA0SLwoTYWR2ZW50dXJl",
			"X3Jvb21faW5mbxgKIAEoCzISLkFkdmVudHVyZVJvb21JbmZvQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			AdventureRoomInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(UpdateRogueAdventureRoomScoreScRsp), UpdateRogueAdventureRoomScoreScRsp.Parser, new string[]
			{
				"Retcode",
				"AdventureRoomInfo"
			}, null, null, null, null)
		}));
	}
}
