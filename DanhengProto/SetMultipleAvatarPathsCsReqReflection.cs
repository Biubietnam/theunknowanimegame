using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001118 RID: 4376
	public static class SetMultipleAvatarPathsCsReqReflection
	{
		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600C327 RID: 49959 RVA: 0x0020BDA2 File Offset: 0x00209FA2
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetMultipleAvatarPathsCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004EDD RID: 20189
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRNdWx0aXBsZUF2YXRhclBhdGhzQ3NSZXEucHJvdG8aGU11bHRpUGF0" + "aEF2YXRhclR5cGUucHJvdG8iSwobU2V0TXVsdGlwbGVBdmF0YXJQYXRoc0Nz" + "UmVxEiwKDmF2YXRhcl9pZF9saXN0GA4gAygOMhQuTXVsdGlQYXRoQXZhdGFy" + "VHlwZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			MultiPathAvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetMultipleAvatarPathsCsReq), SetMultipleAvatarPathsCsReq.Parser, new string[]
			{
				"AvatarIdList"
			}, null, null, null, null)
		}));
	}
}
