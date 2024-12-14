using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003E4 RID: 996
	public static class DrinkMakerGuestReflection
	{
		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x0007B169 File Offset: 0x00079369
		public static FileDescriptor Descriptor
		{
			get
			{
				return DrinkMakerGuestReflection.descriptor;
			}
		}

		// Token: 0x040011E7 RID: 4583
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVEcmlua01ha2VyR3Vlc3QucHJvdG8iTwoPRHJpbmtNYWtlckd1ZXN0Eg0K" + "BUZhaXRoGAggASgNEhwKFFVubG9ja2VkRmF2b3JUYWdMaXN0GAkgAygNEg8K" + "B0d1ZXN0SWQYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerGuest), DrinkMakerGuest.Parser, new string[]
			{
				"Faith",
				"UnlockedFavorTagList",
				"GuestId"
			}, null, null, null, null)
		}));
	}
}
