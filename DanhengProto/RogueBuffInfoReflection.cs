using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E1C RID: 3612
	public static class RogueBuffInfoReflection
	{
		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x001B0944 File Offset: 0x001AEB44
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBuffInfoReflection.descriptor;
			}
		}

		// Token: 0x0400420B RID: 16907
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNSb2d1ZUJ1ZmZJbmZvLnByb3RvGg9Sb2d1ZUJ1ZmYucHJvdG8iMwoNUm9n" + "dWVCdWZmSW5mbxIiCg5tYXplX2J1ZmZfbGlzdBgPIAMoCzIKLlJvZ3VlQnVm" + "ZkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueBuffReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBuffInfo), RogueBuffInfo.Parser, new string[]
			{
				"MazeBuffList"
			}, null, null, null, null)
		}));
	}
}
