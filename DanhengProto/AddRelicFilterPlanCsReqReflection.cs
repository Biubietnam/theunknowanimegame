using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000046 RID: 70
	public static class AddRelicFilterPlanCsReqReflection
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00008A8E File Offset: 0x00006C8E
		public static FileDescriptor Descriptor
		{
			get
			{
				return AddRelicFilterPlanCsReqReflection.descriptor;
			}
		}

		// Token: 0x040000FB RID: 251
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1BZGRSZWxpY0ZpbHRlclBsYW5Dc1JlcS5wcm90bxodUmVsaWNGaWx0ZXJQ",
			"bGFuU2V0dGluZ3MucHJvdG8aGVJlbGljRmlsdGVyUGxhbkljb24ucHJvdG8i",
			"owEKF0FkZFJlbGljRmlsdGVyUGxhbkNzUmVxEhgKEEF2YXRhcklkT25DcmVh",
			"dGUYCyABKA0SDAoETmFtZRgIIAEoCRIiCgRJY29uGAYgASgLMhQuUmVsaWNG",
			"aWx0ZXJQbGFuSWNvbhIqCghTZXR0aW5ncxgNIAEoCzIYLlJlbGljRmlsdGVy",
			"UGxhblNldHRpbmdzEhAKCElzTWFya2VkGAcgASgIQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RelicFilterPlanSettingsReflection.Descriptor,
			RelicFilterPlanIconReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AddRelicFilterPlanCsReq), AddRelicFilterPlanCsReq.Parser, new string[]
			{
				"AvatarIdOnCreate",
				"Name",
				"Icon",
				"Settings",
				"IsMarked"
			}, null, null, null, null)
		}));
	}
}
