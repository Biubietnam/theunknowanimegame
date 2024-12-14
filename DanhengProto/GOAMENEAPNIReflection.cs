using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086E RID: 2158
	public static class GOAMENEAPNIReflection
	{
		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x000FD939 File Offset: 0x000FBB39
		public static FileDescriptor Descriptor
		{
			get
			{
				return GOAMENEAPNIReflection.descriptor;
			}
		}

		// Token: 0x040024DE RID: 9438
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHT0FNRU5FQVBOSS5wcm90byIiCgtHT0FNRU5FQVBOSRITCgtkaWFsb2d1" + "ZV9pZBgLIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GOAMENEAPNI), GOAMENEAPNI.Parser, new string[]
			{
				"DialogueId"
			}, null, null, null, null)
		}));
	}
}
