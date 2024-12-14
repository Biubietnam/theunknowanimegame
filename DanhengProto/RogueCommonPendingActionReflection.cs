using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E5E RID: 3678
	public static class RogueCommonPendingActionReflection
	{
		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x001B91A5 File Offset: 0x001B73A5
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueCommonPendingActionReflection.descriptor;
			}
		}

		// Token: 0x04004318 RID: 17176
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb24ucHJvdG8aEVJvZ3VlQWN0aW9u" + "LnByb3RvIlYKGFJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlvbhIWCg5xdWV1ZV9w" + "b3NpdGlvbhgHIAEoDRIiCgxyb2d1ZV9hY3Rpb24YBiABKAsyDC5Sb2d1ZUFj" + "dGlvbkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="), new FileDescriptor[]
		{
			RogueActionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueCommonPendingAction), RogueCommonPendingAction.Parser, new string[]
			{
				"QueuePosition",
				"RogueAction"
			}, null, null, null, null)
		}));
	}
}
