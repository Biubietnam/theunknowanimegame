using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001188 RID: 4488
	public static class StaminaInfoScNotifyReflection
	{
		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600C858 RID: 51288 RVA: 0x00219822 File Offset: 0x00217A22
		public static FileDescriptor Descriptor
		{
			get
			{
				return StaminaInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040050E1 RID: 20705
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTdGFtaW5hSW5mb1NjTm90aWZ5LnByb3RvIm8KE1N0YW1pbmFJbmZvU2NO" + "b3RpZnkSEwoLTE5CTENPSE5BTkYYBiABKAMSGQoRbmV4dF9yZWNvdmVyX3Rp" + "bWUYAyABKAMSDwoHc3RhbWluYRgPIAEoDRIXCg9yZXNlcnZlX3N0YW1pbmEY" + "CCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(StaminaInfoScNotify), StaminaInfoScNotify.Parser, new string[]
			{
				"LNBLCOHNANF",
				"NextRecoverTime",
				"Stamina",
				"ReserveStamina"
			}, null, null, null, null)
		}));
	}
}
