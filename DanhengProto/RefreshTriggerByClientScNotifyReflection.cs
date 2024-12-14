using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D92 RID: 3474
	public static class RefreshTriggerByClientScNotifyReflection
	{
		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x0019CC0D File Offset: 0x0019AE0D
		public static FileDescriptor Descriptor
		{
			get
			{
				return RefreshTriggerByClientScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003C32 RID: 15410
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiRSZWZyZXNoVHJpZ2dlckJ5Q2xpZW50U2NOb3RpZnkucHJvdG8icQoeUmVm",
			"cmVzaFRyaWdnZXJCeUNsaWVudFNjTm90aWZ5EhkKEXRyaWdnZXJfZW50aXR5",
			"X2lkGAQgASgNEh4KFnRyaWdnZXJfdGFyZ2V0X2lkX2xpc3QYCyADKA0SFAoM",
			"dHJpZ2dlcl9uYW1lGA8gASgJQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RefreshTriggerByClientScNotify), RefreshTriggerByClientScNotify.Parser, new string[]
			{
				"TriggerEntityId",
				"TriggerTargetIdList",
				"TriggerName"
			}, null, null, null, null)
		}));
	}
}
