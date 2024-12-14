using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FE RID: 4350
	public static class SetGenderScRspReflection
	{
		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x0020934E File Offset: 0x0020754E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetGenderScRspReflection.descriptor;
			}
		}

		// Token: 0x04004E81 RID: 20097
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChRTZXRHZW5kZXJTY1JzcC5wcm90bxoZTXVsdGlQYXRoQXZhdGFySW5mby5w",
			"cm90bxoZTXVsdGlQYXRoQXZhdGFyVHlwZS5wcm90byKJAQoOU2V0R2VuZGVy",
			"U2NSc3ASNwoZY3VyX2F2YXRhcl9wYXRoX2luZm9fbGlzdBgLIAMoCzIULk11",
			"bHRpUGF0aEF2YXRhckluZm8SDwoHcmV0Y29kZRgKIAEoDRItCg9jdXJfYXZh",
			"dGFyX3BhdGgYBCABKA4yFC5NdWx0aVBhdGhBdmF0YXJUeXBlQh6qAhtFZ2dM",
			"aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MultiPathAvatarInfoReflection.Descriptor,
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetGenderScRsp), SetGenderScRsp.Parser, new string[]
			{
				"CurAvatarPathInfoList",
				"Retcode",
				"CurAvatarPath"
			}, null, null, null, null)
		}));
	}
}
