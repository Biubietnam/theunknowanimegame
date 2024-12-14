using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F42 RID: 3906
	public static class RogueMiracleSelectInfoReflection
	{
		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600AE56 RID: 44630 RVA: 0x001D4D12 File Offset: 0x001D2F12
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMiracleSelectInfoReflection.descriptor;
			}
		}

		// Token: 0x040046F7 RID: 18167
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU1pcmFjbGVTZWxlY3RJbmZvLnByb3RvImwKFlJvZ3VlTWlyYWNs" + "ZVNlbGVjdEluZm8SGwoTc2VsZWN0X21pcmFjbGVfbGlzdBgIIAMoDRIdChVt" + "aXJhY2xlX2hhbmRib29rX2xpc3QYAyADKA0SFgoOc2VsZWN0X2hpbnRfaWQY" + "BSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMiracleSelectInfo), RogueMiracleSelectInfo.Parser, new string[]
			{
				"SelectMiracleList",
				"MiracleHandbookList",
				"SelectHintId"
			}, null, null, null, null)
		}));
	}
}
