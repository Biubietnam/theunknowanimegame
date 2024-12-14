using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000208 RID: 520
	public static class ChessRogueDiceSurfaceInfoReflection
	{
		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00042E83 File Offset: 0x00041083
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueDiceSurfaceInfoReflection.descriptor;
			}
		}

		// Token: 0x040009E0 RID: 2528
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlRGljZVN1cmZhY2VJbmZvLnByb3RvIkoKGUNoZXNzUm9n" + "dWVEaWNlU3VyZmFjZUluZm8SFwoPZGljZV9zdXJmYWNlX2lkGAUgASgNEhQK" + "DGRpY2Vfc2xvdF9pZBgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueDiceSurfaceInfo), ChessRogueDiceSurfaceInfo.Parser, new string[]
			{
				"DiceSurfaceId",
				"DiceSlotId"
			}, null, null, null, null)
		}));
	}
}
