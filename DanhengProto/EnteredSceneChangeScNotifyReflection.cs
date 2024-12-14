using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200043E RID: 1086
	public static class EnteredSceneChangeScNotifyReflection
	{
		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x000848D0 File Offset: 0x00082AD0
		public static FileDescriptor Descriptor
		{
			get
			{
				return EnteredSceneChangeScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04001332 RID: 4914
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFbnRlcmVkU2NlbmVDaGFuZ2VTY05vdGlmeS5wcm90bxoWRW50ZXJlZFNj" + "ZW5lSW5mby5wcm90byJQChpFbnRlcmVkU2NlbmVDaGFuZ2VTY05vdGlmeRIy" + "ChdlbnRlcmVkX3NjZW5lX2luZm9fbGlzdBgBIAMoCzIRLkVudGVyZWRTY2Vu" + "ZUluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			EnteredSceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(EnteredSceneChangeScNotify), EnteredSceneChangeScNotify.Parser, new string[]
			{
				"EnteredSceneInfoList"
			}, null, null, null, null)
		}));
	}
}
