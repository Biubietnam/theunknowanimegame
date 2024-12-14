using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200028A RID: 650
	public static class ChessRogueReviveAvatarCsReqReflection
	{
		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x00053468 File Offset: 0x00051668
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarCsReqReflection.descriptor;
			}
		}

		// Token: 0x04000C23 RID: 3107
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGVzc1JvZ3VlUmV2aXZlQXZhdGFyQ3NSZXEucHJvdG8iXQobQ2hlc3NS" + "b2d1ZVJldml2ZUF2YXRhckNzUmVxEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QY" + "DSADKA0SIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgIIAEoDUIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueReviveAvatarCsReq), ChessRogueReviveAvatarCsReq.Parser, new string[]
			{
				"BaseAvatarIdList",
				"InteractedPropEntityId"
			}, null, null, null, null)
		}));
	}
}
