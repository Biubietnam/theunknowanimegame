using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106C RID: 4204
	public static class SceneEntityTeleportCsReqReflection
	{
		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600BB49 RID: 47945 RVA: 0x001F7C5D File Offset: 0x001F5E5D
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityTeleportCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004BF4 RID: 19444
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXEucHJvdG8aEkVudGl0eU1vdGlv" + "bi5wcm90byJSChhTY2VuZUVudGl0eVRlbGVwb3J0Q3NSZXESEAoIZW50cnlf" + "aWQYDSABKA0SJAoNZW50aXR5X21vdGlvbhgGIAEoCzINLkVudGl0eU1vdGlv" + "bkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			EntityMotionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityTeleportCsReq), SceneEntityTeleportCsReq.Parser, new string[]
			{
				"EntryId",
				"EntityMotion"
			}, null, null, null, null)
		}));
	}
}
