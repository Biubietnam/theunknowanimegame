using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F04 RID: 3844
	public static class RogueMagicScepterDressInUnitCsReqReflection
	{
		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600ABA9 RID: 43945 RVA: 0x001CE528 File Offset: 0x001CC728
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicScepterDressInUnitCsReqReflection.descriptor;
			}
		}

		// Token: 0x0400460C RID: 17932
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CidSb2d1ZU1hZ2ljU2NlcHRlckRyZXNzSW5Vbml0Q3NSZXEucHJvdG8icQoh",
			"Um9ndWVNYWdpY1NjZXB0ZXJEcmVzc0luVW5pdENzUmVxEiIKGmRyZXNzX21h",
			"Z2ljX3VuaXRfdW5pcXVlX2lkGAsgASgNEhIKCnNjZXB0ZXJfaWQYDyABKA0S",
			"FAoMZGljZV9zbG90X2lkGA4gASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2",
			"ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicScepterDressInUnitCsReq), RogueMagicScepterDressInUnitCsReq.Parser, new string[]
			{
				"DressMagicUnitUniqueId",
				"ScepterId",
				"DiceSlotId"
			}, null, null, null, null)
		}));
	}
}
