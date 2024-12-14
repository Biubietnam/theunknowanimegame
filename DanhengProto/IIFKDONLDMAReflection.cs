using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000922 RID: 2338
	public static class IIFKDONLDMAReflection
	{
		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06006852 RID: 26706 RVA: 0x00116972 File Offset: 0x00114B72
		public static FileDescriptor Descriptor
		{
			get
			{
				return IIFKDONLDMAReflection.descriptor;
			}
		}

		// Token: 0x04002807 RID: 10247
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSUZLRE9OTERNQS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtJSUZL" + "RE9OTERNQRIgCgthdmF0YXJfdHlwZRgJIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAogASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IIFKDONLDMA), IIFKDONLDMA.Parser, new string[]
			{
				"AvatarType",
				"AvatarId"
			}, null, null, null, null)
		}));
	}
}
