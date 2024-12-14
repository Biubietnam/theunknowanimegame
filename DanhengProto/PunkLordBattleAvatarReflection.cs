using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1A RID: 3354
	public static class PunkLordBattleAvatarReflection
	{
		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x060095C9 RID: 38345 RVA: 0x0018E4A7 File Offset: 0x0018C6A7
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleAvatarReflection.descriptor;
			}
		}

		// Token: 0x04003A13 RID: 14867
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQdW5rTG9yZEJhdHRsZUF2YXRhci5wcm90byI/ChRQdW5rTG9yZEJhdHRs" + "ZUF2YXRhchIRCglhdmF0YXJfaWQYASABKA0SFAoMYXZhdGFyX2xldmVsGAIg" + "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordBattleAvatar), PunkLordBattleAvatar.Parser, new string[]
			{
				"AvatarId",
				"AvatarLevel"
			}, null, null, null, null)
		}));
	}
}
