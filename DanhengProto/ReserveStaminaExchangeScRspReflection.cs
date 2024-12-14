using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC6 RID: 3526
	public static class ReserveStaminaExchangeScRspReflection
	{
		// Token: 0x17002C86 RID: 11398
		// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x001A416A File Offset: 0x001A236A
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReserveStaminaExchangeScRspReflection.descriptor;
			}
		}

		// Token: 0x04003D51 RID: 15697
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNlcnZlU3RhbWluYUV4Y2hhbmdlU2NSc3AucHJvdG8iOwobUmVzZXJ2" + "ZVN0YW1pbmFFeGNoYW5nZVNjUnNwEg8KB3JldGNvZGUYBSABKA0SCwoDbnVt" + "GAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReserveStaminaExchangeScRsp), ReserveStaminaExchangeScRsp.Parser, new string[]
			{
				"Retcode",
				"Num"
			}, null, null, null, null)
		}));
	}
}
