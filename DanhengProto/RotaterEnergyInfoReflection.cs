using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001044 RID: 4164
	public static class RotaterEnergyInfoReflection
	{
		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600B948 RID: 47432 RVA: 0x001F1724 File Offset: 0x001EF924
		public static FileDescriptor Descriptor
		{
			get
			{
				return RotaterEnergyInfoReflection.descriptor;
			}
		}

		// Token: 0x04004B0C RID: 19212
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSb3RhdGVyRW5lcmd5SW5mby5wcm90byI1ChFSb3RhdGVyRW5lcmd5SW5m" + "bxIPCgdjdXJfbnVtGAMgASgNEg8KB21heF9udW0YBiABKA1CHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RotaterEnergyInfo), RotaterEnergyInfo.Parser, new string[]
			{
				"CurNum",
				"MaxNum"
			}, null, null, null, null)
		}));
	}
}
