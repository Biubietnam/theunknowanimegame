using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001DB RID: 475
	public enum ChatType
	{
		// Token: 0x040008F0 RID: 2288
		[OriginalName("CHAT_TYPE_NONE")]
		None,
		// Token: 0x040008F1 RID: 2289
		[OriginalName("CHAT_TYPE_PRIVATE")]
		Private,
		// Token: 0x040008F2 RID: 2290
		[OriginalName("CHAT_TYPE_GROUP")]
		Group
	}
}
