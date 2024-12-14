using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001414 RID: 5140
	public static class VirtualLineupDestroyNotifyReflection
	{
		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x00261D0D File Offset: 0x0025FF0D
		public static FileDescriptor Descriptor
		{
			get
			{
				return VirtualLineupDestroyNotifyReflection.descriptor;
			}
		}

		// Token: 0x04005B16 RID: 23318
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBWaXJ0dWFsTGluZXVwRGVzdHJveU5vdGlmeS5wcm90byIuChpWaXJ0dWFs" + "TGluZXVwRGVzdHJveU5vdGlmeRIQCghwbGFuZV9pZBgCIAEoDUIeqgIbRWdn" + "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(VirtualLineupDestroyNotify), VirtualLineupDestroyNotify.Parser, new string[]
			{
				"PlaneId"
			}, null, null, null, null)
		}));
	}
}
