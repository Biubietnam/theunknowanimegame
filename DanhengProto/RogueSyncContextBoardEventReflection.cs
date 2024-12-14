using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F76 RID: 3958
	public static class RogueSyncContextBoardEventReflection
	{
		// Token: 0x170031BF RID: 12735
		// (get) Token: 0x0600B05C RID: 45148 RVA: 0x001D9D37 File Offset: 0x001D7F37
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueSyncContextBoardEventReflection.descriptor;
			}
		}

		// Token: 0x040047C3 RID: 18371
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSb2d1ZVN5bmNDb250ZXh0Qm9hcmRFdmVudC5wcm90byJOChpSb2d1ZVN5" + "bmNDb250ZXh0Qm9hcmRFdmVudBIaChJNb2RpZmllckVmZmVjdFR5cGUYBSAB" + "KA0SFAoMQm9hcmRFdmVudElkGAsgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueSyncContextBoardEvent), RogueSyncContextBoardEvent.Parser, new string[]
			{
				"ModifierEffectType",
				"BoardEventId"
			}, null, null, null, null)
		}));
	}
}
