using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B5E RID: 2910
	public static class MonopolyLikeScRspReflection
	{
		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x00153967 File Offset: 0x00151B67
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonopolyLikeScRspReflection.descriptor;
			}
		}

		// Token: 0x04003133 RID: 12595
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNb25vcG9seUxpa2VTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iWQoR" + "TW9ub3BvbHlMaWtlU2NSc3ASDwoHcmV0Y29kZRgJIAEoDRITCgtCRUpMSktM" + "UEZISRgLIAEoDRIeCgtyZXdhcmRfbGlzdBgIIAEoCzIJLkl0ZW1MaXN0Qh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyLikeScRsp), MonopolyLikeScRsp.Parser, new string[]
			{
				"Retcode",
				"BEJLJKLPFHI",
				"RewardList"
			}, null, null, null, null)
		}));
	}
}
