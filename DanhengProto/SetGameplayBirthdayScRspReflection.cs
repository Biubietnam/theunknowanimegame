using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FA RID: 4346
	public static class SetGameplayBirthdayScRspReflection
	{
		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x00208D9E File Offset: 0x00206F9E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetGameplayBirthdayScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E75 RID: 20085
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRHYW1lcGxheUJpcnRoZGF5U2NSc3AucHJvdG8iPQoYU2V0R2FtZXBs" + "YXlCaXJ0aGRheVNjUnNwEg8KB3JldGNvZGUYCiABKA0SEAoIYmlydGhkYXkY" + "BSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetGameplayBirthdayScRsp), SetGameplayBirthdayScRsp.Parser, new string[]
			{
				"Retcode",
				"Birthday"
			}, null, null, null, null)
		}));
	}
}
