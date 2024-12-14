using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200074A RID: 1866
	public static class GetNpcMessageGroupScRspReflection
	{
		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x000E0E40 File Offset: 0x000DF040
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetNpcMessageGroupScRspReflection.descriptor;
			}
		}

		// Token: 0x040020D5 RID: 8405
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXROcGNNZXNzYWdlR3JvdXBTY1JzcC5wcm90bxoSTWVzc2FnZUdyb3Vw" + "LnByb3RvIlUKF0dldE5wY01lc3NhZ2VHcm91cFNjUnNwEg8KB3JldGNvZGUY" + "AiABKA0SKQoSbWVzc2FnZV9ncm91cF9saXN0GA0gAygLMg0uTWVzc2FnZUdy" + "b3VwQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			MessageGroupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcMessageGroupScRsp), GetNpcMessageGroupScRsp.Parser, new string[]
			{
				"Retcode",
				"MessageGroupList"
			}, null, null, null, null)
		}));
	}
}
