using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EFC RID: 3836
	public static class RogueMagicRoomInfoReflection
	{
		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x001CD8B5 File Offset: 0x001CBAB5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicRoomInfoReflection.descriptor;
			}
		}

		// Token: 0x040045EB RID: 17899
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChhSb2d1ZU1hZ2ljUm9vbUluZm8ucHJvdG8aGlJvZ3VlTWFnaWNSb29tU3Rh",
			"dHVzLnByb3RvInUKElJvZ3VlTWFnaWNSb29tSW5mbxIPCgdyb29tX2lkGAsg",
			"ASgNEiUKBnN0YXR1cxgKIAEoDjIVLlJvZ3VlTWFnaWNSb29tU3RhdHVzEhMK",
			"C0ZHSUhIQUFIR0RBGAEgASgNEhIKCnJvb21faW5kZXgYDyABKA1CHqoCG0Vn",
			"Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			RogueMagicRoomStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicRoomInfo), RogueMagicRoomInfo.Parser, new string[]
			{
				"RoomId",
				"Status",
				"FGIHHAAHGDA",
				"RoomIndex"
			}, null, null, null, null)
		}));
	}
}
