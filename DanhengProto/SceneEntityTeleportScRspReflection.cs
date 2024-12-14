using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200106E RID: 4206
	public static class SceneEntityTeleportScRspReflection
	{
		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x001F7FF4 File Offset: 0x001F61F4
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneEntityTeleportScRspReflection.descriptor;
			}
		}

		// Token: 0x04004BFB RID: 19451
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5TY2VuZUVudGl0eVRlbGVwb3J0U2NSc3AucHJvdG8aEkVudGl0eU1vdGlv",
			"bi5wcm90byJtChhTY2VuZUVudGl0eVRlbGVwb3J0U2NSc3ASGgoSY2xpZW50",
			"X3Bvc192ZXJzaW9uGAYgASgNEiQKDWVudGl0eV9tb3Rpb24YDSABKAsyDS5F",
			"bnRpdHlNb3Rpb24SDwoHcmV0Y29kZRgIIAEoDUIeqgIbRWdnTGluay5EYW5o",
			"ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			EntityMotionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityTeleportScRsp), SceneEntityTeleportScRsp.Parser, new string[]
			{
				"ClientPosVersion",
				"EntityMotion",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
