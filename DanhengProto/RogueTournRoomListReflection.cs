using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200100E RID: 4110
	public static class RogueTournRoomListReflection
	{
		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x001EA8FD File Offset: 0x001E8AFD
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueTournRoomListReflection.descriptor;
			}
		}

		// Token: 0x04004A0F RID: 18959
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZVRvdXJuUm9vbUxpc3QucHJvdG8aGlJvZ3VlVG91cm5Sb29tU3Rh",
			"dHVzLnByb3RvInUKElJvZ3VlVG91cm5Sb29tTGlzdBIPCgdyb29tX2lkGAUg",
			"ASgNEiUKBnN0YXR1cxgHIAEoDjIVLlJvZ3VlVG91cm5Sb29tU3RhdHVzEhMK",
			"C0ZHSUhIQUFIR0RBGAwgASgNEhIKCnJvb21faW5kZXgYCCABKA1CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueTournRoomStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRoomList), RogueTournRoomList.Parser, new string[]
			{
				"RoomId",
				"Status",
				"FGIHHAAHGDA",
				"RoomIndex"
			}, null, null, null, null)
		}));
	}
}
