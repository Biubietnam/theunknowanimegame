using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F9A RID: 3994
	public static class RogueTournDoorInfoReflection
	{
		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600B1FE RID: 45566 RVA: 0x001DE6CD File Offset: 0x001DC8CD
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournDoorInfoReflection.descriptor;
			}
		}

		// Token: 0x04004862 RID: 18530
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZVRvdXJuRG9vckluZm8ucHJvdG8iZgoSUm9ndWVUb3VybkRvb3JJ" + "bmZvEiEKGXJvZ3VlX2Rvb3JfbmV4dF9yb29tX3R5cGUYBSABKA0SEwoLRkdJ" + "SEhBQUhHREEYCyABKA0SGAoQZW50ZXJfbmV4dF9sYXllchgIIAEoCEIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournDoorInfo), RogueTournDoorInfo.Parser, new string[]
			{
				"RogueDoorNextRoomType",
				"FGIHHAAHGDA",
				"EnterNextLayer"
			}, null, null, null, null)
		}));
	}
}
