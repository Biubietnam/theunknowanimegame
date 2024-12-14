using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001086 RID: 4230
	public static class ScenePropInfoReflection
	{
		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600BCA1 RID: 48289 RVA: 0x001FC79B File Offset: 0x001FA99B
		public static FileDescriptor Descriptor
		{
			get
			{
				return ScenePropInfoReflection.descriptor;
			}
		}

		// Token: 0x04004CB7 RID: 19639
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChNTY2VuZVByb3BJbmZvLnByb3RvGhNQcm9wRXh0cmFJbmZvLnByb3RvIqEB",
			"Cg1TY2VuZVByb3BJbmZvEhIKCnByb3Bfc3RhdGUYBSABKA0SFgoOY3JlYXRl",
			"X3RpbWVfbXMYDSABKAQSDwoHcHJvcF9pZBgHIAEoDRIiCgpleHRyYV9pbmZv",
			"GAsgASgLMg4uUHJvcEV4dHJhSW5mbxIUCgxsaWZlX3RpbWVfbXMYDCABKA0S",
			"GQoRdHJpZ2dlcl9uYW1lX2xpc3QYASADKAlCHqoCG0VnZ0xpbmsuRGFuaGVu",
			"Z1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			PropExtraInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ScenePropInfo), ScenePropInfo.Parser, new string[]
			{
				"PropState",
				"CreateTimeMs",
				"PropId",
				"ExtraInfo",
				"LifeTimeMs",
				"TriggerNameList"
			}, null, null, null, null)
		}));
	}
}
