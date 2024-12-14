using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C6C RID: 3180
	public static class OpenRogueChestScRspReflection
	{
		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06008D5B RID: 36187 RVA: 0x00175A91 File Offset: 0x00173C91
		public static FileDescriptor Descriptor
		{
			get
			{
				return OpenRogueChestScRspReflection.descriptor;
			}
		}

		// Token: 0x0400364C RID: 13900
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlPcGVuUm9ndWVDaGVzdFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJf" + "ChNPcGVuUm9ndWVDaGVzdFNjUnNwEhwKCWRyb3BfZGF0YRgJIAEoCzIJLkl0" + "ZW1MaXN0EhkKBnJld2FyZBgFIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUY" + "DSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(OpenRogueChestScRsp), OpenRogueChestScRsp.Parser, new string[]
			{
				"DropData",
				"Reward",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
