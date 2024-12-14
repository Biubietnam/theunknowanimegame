using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EBC RID: 3772
	public static class RogueMagicDoorInfoReflection
	{
		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600A89C RID: 43164 RVA: 0x001C64DD File Offset: 0x001C46DD
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicDoorInfoReflection.descriptor;
			}
		}

		// Token: 0x040044E8 RID: 17640
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSb2d1ZU1hZ2ljRG9vckluZm8ucHJvdG8iZgoSUm9ndWVNYWdpY0Rvb3JJ" + "bmZvEiEKGXJvZ3VlX2Rvb3JfbmV4dF9yb29tX3R5cGUYDiABKA0SEwoLRkdJ" + "SEhBQUhHREEYDCABKA0SGAoQZW50ZXJfbmV4dF9sYXllchgNIAEoCEIeqgIb" + "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicDoorInfo), RogueMagicDoorInfo.Parser, new string[]
			{
				"RogueDoorNextRoomType",
				"FGIHHAAHGDA",
				"EnterNextLayer"
			}, null, null, null, null)
		}));
	}
}
