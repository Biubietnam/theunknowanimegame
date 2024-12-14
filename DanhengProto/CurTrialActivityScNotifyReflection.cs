using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000340 RID: 832
	public static class CurTrialActivityScNotifyReflection
	{
		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x000691FA File Offset: 0x000673FA
		public static FileDescriptor Descriptor
		{
			get
			{
				return CurTrialActivityScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F2C RID: 3884
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5DdXJUcmlhbEFjdGl2aXR5U2NOb3RpZnkucHJvdG8aGVRyaWFsQWN0aXZp",
			"dHlTdGF0dXMucHJvdG8iWwoYQ3VyVHJpYWxBY3Rpdml0eVNjTm90aWZ5EhkK",
			"EWFjdGl2aXR5X3N0YWdlX2lkGAcgASgNEiQKBnN0YXR1cxgBIAEoDjIULlRy",
			"aWFsQWN0aXZpdHlTdGF0dXNCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
			"cm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			TrialActivityStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CurTrialActivityScNotify), CurTrialActivityScNotify.Parser, new string[]
			{
				"ActivityStageId",
				"Status"
			}, null, null, null, null)
		}));
	}
}
