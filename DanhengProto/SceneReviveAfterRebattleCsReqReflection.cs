using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001088 RID: 4232
	public static class SceneReviveAfterRebattleCsReqReflection
	{
		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x001FCE02 File Offset: 0x001FB002
		public static FileDescriptor Descriptor
		{
			get
			{
				return SceneReviveAfterRebattleCsReqReflection.descriptor;
			}
		}

		// Token: 0x04004CC7 RID: 19655
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTY2VuZVJldml2ZUFmdGVyUmViYXR0bGVDc1JlcS5wcm90bxoSUmViYXR0" + "bGVUeXBlLnByb3RvIkUKHVNjZW5lUmV2aXZlQWZ0ZXJSZWJhdHRsZUNzUmVx" + "EiQKDXJlYmF0dGxlX3R5cGUYCyABKA4yDS5SZWJhdHRsZVR5cGVCHqoCG0Vn" + "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			RebattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SceneReviveAfterRebattleCsReq), SceneReviveAfterRebattleCsReq.Parser, new string[]
			{
				"RebattleType"
			}, null, null, null, null)
		}));
	}
}
