using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200108E RID: 4238
	public static class SceneUpdatePositionVersionNotifyReflection
	{
		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600BD07 RID: 48391 RVA: 0x001FD916 File Offset: 0x001FBB16
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneUpdatePositionVersionNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004CE1 RID: 19681
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZTY2VuZVVwZGF0ZVBvc2l0aW9uVmVyc2lvbk5vdGlmeS5wcm90byI3CiBT" + "Y2VuZVVwZGF0ZVBvc2l0aW9uVmVyc2lvbk5vdGlmeRITCgtwb3NfdmVyc2lv" + "bhgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneUpdatePositionVersionNotify), SceneUpdatePositionVersionNotify.Parser, new string[]
			{
				"PosVersion"
			}, null, null, null, null)
		}));
	}
}
