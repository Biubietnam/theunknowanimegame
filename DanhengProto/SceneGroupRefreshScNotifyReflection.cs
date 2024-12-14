using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001070 RID: 4208
	public static class SceneGroupRefreshScNotifyReflection
	{
		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600BB79 RID: 47993 RVA: 0x001F844F File Offset: 0x001F664F
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneGroupRefreshScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004C04 RID: 19460
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TY2VuZUdyb3VwUmVmcmVzaFNjTm90aWZ5LnByb3RvGhZHcm91cFJlZnJl" + "c2hJbmZvLnByb3RvIkoKGVNjZW5lR3JvdXBSZWZyZXNoU2NOb3RpZnkSLQoS" + "Z3JvdXBfcmVmcmVzaF9saXN0GAggAygLMhEuR3JvdXBSZWZyZXNoSW5mb0Ie" + "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			GroupRefreshInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneGroupRefreshScNotify), SceneGroupRefreshScNotify.Parser, new string[]
			{
				"GroupRefreshList"
			}, null, null, null, null)
		}));
	}
}
