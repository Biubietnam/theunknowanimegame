using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000932 RID: 2354
	public static class InteractChargerCsReqReflection
	{
		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06006910 RID: 26896 RVA: 0x00118832 File Offset: 0x00116A32
		public static FileDescriptor Descriptor
		{
			get
			{
				return InteractChargerCsReqReflection.descriptor;
			}
		}

		// Token: 0x04002849 RID: 10313
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpJbnRlcmFjdENoYXJnZXJDc1JlcS5wcm90bxoRQ2hhcmdlckluZm8ucHJv" + "dG8iOgoUSW50ZXJhY3RDaGFyZ2VyQ3NSZXESIgoMY2hhcmdlcl9pbmZvGAcg" + "ASgLMgwuQ2hhcmdlckluZm9CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[]
		{
			ChargerInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(InteractChargerCsReq), InteractChargerCsReq.Parser, new string[]
			{
				"ChargerInfo"
			}, null, null, null, null)
		}));
	}
}
