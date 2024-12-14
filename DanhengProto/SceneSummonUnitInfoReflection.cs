using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200108C RID: 4236
	public static class SceneSummonUnitInfoReflection
	{
		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600BCE9 RID: 48361 RVA: 0x001FD2F2 File Offset: 0x001FB4F2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneSummonUnitInfoReflection.descriptor;
			}
		}

		// Token: 0x04004CD1 RID: 19665
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlTY2VuZVN1bW1vblVuaXRJbmZvLnByb3RvIqoBChNTY2VuZVN1bW1vblVu",
			"aXRJbmZvEhgKEGF0dGFjaF9lbnRpdHlfaWQYBCABKA0SFgoOY3JlYXRlX3Rp",
			"bWVfbXMYCyABKAQSGAoQY2FzdGVyX2VudGl0eV9pZBgMIAEoDRIUCgxsaWZl",
			"X3RpbWVfbXMYASABKAUSGQoRdHJpZ2dlcl9uYW1lX2xpc3QYAiADKAkSFgoO",
			"c3VtbW9uX3VuaXRfaWQYBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
			"ci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneSummonUnitInfo), SceneSummonUnitInfo.Parser, new string[]
			{
				"AttachEntityId",
				"CreateTimeMs",
				"CasterEntityId",
				"LifeTimeMs",
				"TriggerNameList",
				"SummonUnitId"
			}, null, null, null, null)
		}));
	}
}
