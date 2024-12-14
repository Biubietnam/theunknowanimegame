using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001066 RID: 4198
	public static class SceneEntityMoveScNotifyReflection
	{
		// Token: 0x170034BC RID: 13500
		// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x001F6DA6 File Offset: 0x001F4FA6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04004BD7 RID: 19415
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch1TY2VuZUVudGl0eU1vdmVTY05vdGlmeS5wcm90bxoQTW90aW9uSW5mby5w",
			"cm90byJ3ChdTY2VuZUVudGl0eU1vdmVTY05vdGlmeRIQCghlbnRyeV9pZBgC",
			"IAEoDRIbCgZtb3Rpb24YDiABKAsyCy5Nb3Rpb25JbmZvEhEKCWVudGl0eV9p",
			"ZBgBIAEoDRIaChJjbGllbnRfcG9zX3ZlcnNpb24YBCABKA1CHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityMoveScNotify), SceneEntityMoveScNotify.Parser, new string[]
			{
				"EntryId",
				"Motion",
				"EntityId",
				"ClientPosVersion"
			}, null, null, null, null)
		}));
	}
}
