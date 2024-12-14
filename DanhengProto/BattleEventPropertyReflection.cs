using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000E6 RID: 230
	public static class BattleEventPropertyReflection
	{
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0001E5D8 File Offset: 0x0001C7D8
		public static FileDescriptor Descriptor
		{
			get
			{
				return BattleEventPropertyReflection.descriptor;
			}
		}

		// Token: 0x0400044A RID: 1098
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlCYXR0bGVFdmVudFByb3BlcnR5LnByb3RvGg9TcEJhckluZm8ucHJvdG8i" + "MQoTQmF0dGxlRXZlbnRQcm9wZXJ0eRIaCgZzcF9iYXIYAiABKAsyCi5TcEJh" + "ckluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(BattleEventProperty), BattleEventProperty.Parser, new string[]
			{
				"SpBar"
			}, null, null, null, null)
		}));
	}
}
