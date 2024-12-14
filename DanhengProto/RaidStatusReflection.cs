using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D70 RID: 3440
	public static class RaidStatusReflection
	{
		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x060099CB RID: 39371 RVA: 0x00199865 File Offset: 0x00197A65
		public static FileDescriptor Descriptor
		{
			get
			{
				return RaidStatusReflection.descriptor;
			}
		}

		// Token: 0x04003BB9 RID: 15289
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBSYWlkU3RhdHVzLnByb3RvKmkKClJhaWRTdGF0dXMSFAoQUkFJRF9TVEFU" + "VVNfTk9ORRAAEhUKEVJBSURfU1RBVFVTX0RPSU5HEAESFgoSUkFJRF9TVEFU" + "VVNfRklOSVNIEAISFgoSUkFJRF9TVEFUVVNfRkFJTEVEEANCHqoCG0VnZ0xp" + "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[]
		{
			typeof(RaidStatus)
		}, null, null));
	}
}
