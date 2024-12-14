using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001422 RID: 5154
	public static class WolfBroGameDataReflection
	{
		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x0600E5F6 RID: 58870 RVA: 0x00263386 File Offset: 0x00261586
		public static FileDescriptor Descriptor
		{
			get
			{
				return WolfBroGameDataReflection.descriptor;
			}
		}

		// Token: 0x04005B49 RID: 23369
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChVXb2xmQnJvR2FtZURhdGEucHJvdG8aFVdvbGZCcm9HYW1lSW5mby5wcm90",
			"bxoMVmVjdG9yLnByb3RvIqEBCg9Xb2xmQnJvR2FtZURhdGESHAoLSkJPRklB",
			"TExPUEkYCiADKAsyBy5WZWN0b3ISJQoLS1BQRUhCSkxBQUEYBiABKAsyEC5X",
			"b2xmQnJvR2FtZUluZm8SCgoCaWQYBCABKA0SEwoLUFBJTlBFSEpGQUIYASAB",
			"KA0SEwoLTklFUEFPQkJGSkYYDyABKAkSEwoLSEZORUtNTU1GSE8YCSABKAhC",
			"HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			WolfBroGameInfoReflection.Descriptor,
			VectorReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(WolfBroGameData), WolfBroGameData.Parser, new string[]
			{
				"JBOFIALLOPI",
				"KPPEHBJLAAA",
				"Id",
				"PPINPEHJFAB",
				"NIEPAOBBFJF",
				"HFNEKMMMFHO"
			}, null, null, null, null)
		}));
	}
}
