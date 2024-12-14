using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033A RID: 826
	public static class CurAssistChangedNotifyReflection
	{
		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000683F0 File Offset: 0x000665F0
		public static FileDescriptor Descriptor
		{
			get
			{
				return CurAssistChangedNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000F0C RID: 3852
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDdXJBc3Npc3RDaGFuZ2VkTm90aWZ5LnByb3RvGhZQbGF5ZXJBc3Npc3RJ" + "bmZvLnByb3RvIk8KFkN1ckFzc2lzdENoYW5nZWROb3RpZnkSNQoaRlJJRU5E" + "X0FQUExZX1NPVVJDRV9BU1NJU1QYDSABKAsyES5QbGF5ZXJBc3Npc3RJbmZv" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlayerAssistInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(CurAssistChangedNotify), CurAssistChangedNotify.Parser, new string[]
			{
				"FRIENDAPPLYSOURCEASSIST"
			}, null, null, null, null)
		}));
	}
}
