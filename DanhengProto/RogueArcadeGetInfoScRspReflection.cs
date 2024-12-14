using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF8 RID: 3576
	public static class RogueArcadeGetInfoScRspReflection
	{
		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x06009FF4 RID: 40948 RVA: 0x001AD6C6 File Offset: 0x001AB8C6
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueArcadeGetInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04004196 RID: 16790
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Sb2d1ZUFyY2FkZUdldEluZm9TY1JzcC5wcm90byI7ChdSb2d1ZUFyY2Fk" + "ZUdldEluZm9TY1JzcBIPCgdyb29tX2lkGAwgASgNEg8KB3JldGNvZGUYASAB" + "KA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeGetInfoScRsp), RogueArcadeGetInfoScRsp.Parser, new string[]
			{
				"RoomId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
