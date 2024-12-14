using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200110E RID: 4366
	public static class SetLanguageScRspReflection
	{
		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600C2B4 RID: 49844 RVA: 0x0020AD3E File Offset: 0x00208F3E
		public static FileDescriptor Descriptor
		{
			get
			{
				return SetLanguageScRspReflection.descriptor;
			}
		}

		// Token: 0x04004EBA RID: 20154
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXRMYW5ndWFnZVNjUnNwLnByb3RvGhJMYW5ndWFnZVR5cGUucHJvdG8i" + "RAoQU2V0TGFuZ3VhZ2VTY1JzcBIPCgdyZXRjb2RlGAwgASgNEh8KCGxhbmd1" + "YWdlGAQgASgOMg0uTGFuZ3VhZ2VUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdT" + "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			LanguageTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SetLanguageScRsp), SetLanguageScRsp.Parser, new string[]
			{
				"Retcode",
				"Language"
			}, null, null, null, null)
		}));
	}
}
