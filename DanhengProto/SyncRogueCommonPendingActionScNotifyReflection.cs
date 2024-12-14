using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001288 RID: 4744
	public static class SyncRogueCommonPendingActionScNotifyReflection
	{
		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0600D3B2 RID: 54194 RVA: 0x002355C6 File Offset: 0x002337C6
		public static FileDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonPendingActionScNotifyReflection.descriptor;
			}
		}

		// Token: 0x040054BF RID: 21695
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipTeW5jUm9ndWVDb21tb25QZW5kaW5nQWN0aW9uU2NOb3RpZnkucHJvdG8a",
			"HlJvZ3VlQ29tbW9uUGVuZGluZ0FjdGlvbi5wcm90byJpCiRTeW5jUm9ndWVD",
			"b21tb25QZW5kaW5nQWN0aW9uU2NOb3RpZnkSKQoGYWN0aW9uGAsgASgLMhku",
			"Um9ndWVDb21tb25QZW5kaW5nQWN0aW9uEhYKDnJvZ3VlX3N1Yl9tb2RlGA8g",
			"ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueCommonPendingActionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueCommonPendingActionScNotify), SyncRogueCommonPendingActionScNotify.Parser, new string[]
			{
				"Action",
				"RogueSubMode"
			}, null, null, null, null)
		}));
	}
}
