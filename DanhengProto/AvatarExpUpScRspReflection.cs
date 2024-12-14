using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C0 RID: 192
	public static class AvatarExpUpScRspReflection
	{
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00019D28 File Offset: 0x00017F28
		public static FileDescriptor Descriptor
		{
			get
			{
				return AvatarExpUpScRspReflection.descriptor;
			}
		}

		// Token: 0x0400038B RID: 907
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBdmF0YXJFeHBVcFNjUnNwLnByb3RvGg5QaWxlSXRlbS5wcm90byJIChBB" + "dmF0YXJFeHBVcFNjUnNwEg8KB3JldGNvZGUYCCABKA0SIwoQcmV0dXJuX2l0" + "ZW1fbGlzdBgKIAMoCzIJLlBpbGVJdGVtQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PileItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AvatarExpUpScRsp), AvatarExpUpScRsp.Parser, new string[]
			{
				"Retcode",
				"ReturnItemList"
			}, null, null, null, null)
		}));
	}
}
