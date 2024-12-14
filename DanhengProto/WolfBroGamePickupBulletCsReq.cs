using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200142D RID: 5165
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGamePickupBulletCsReq : IMessage<WolfBroGamePickupBulletCsReq>, IMessage, IEquatable<WolfBroGamePickupBulletCsReq>, IDeepCloneable<WolfBroGamePickupBulletCsReq>, IBufferMessage
	{
		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0600E66E RID: 58990 RVA: 0x00264755 File Offset: 0x00262955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGamePickupBulletCsReq> Parser
		{
			get
			{
				return WolfBroGamePickupBulletCsReq._parser;
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0600E66F RID: 58991 RVA: 0x0026475C File Offset: 0x0026295C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGamePickupBulletCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x0600E670 RID: 58992 RVA: 0x0026476E File Offset: 0x0026296E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGamePickupBulletCsReq.Descriptor;
			}
		}

		// Token: 0x0600E671 RID: 58993 RVA: 0x00264775 File Offset: 0x00262975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletCsReq()
		{
		}

		// Token: 0x0600E672 RID: 58994 RVA: 0x0026477D File Offset: 0x0026297D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletCsReq(WolfBroGamePickupBulletCsReq other) : this()
		{
			this.pPFJLCCFCOJ_ = ((other.pPFJLCCFCOJ_ != null) ? other.pPFJLCCFCOJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x002647B2 File Offset: 0x002629B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletCsReq Clone()
		{
			return new WolfBroGamePickupBulletCsReq(this);
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0600E674 RID: 58996 RVA: 0x002647BA File Offset: 0x002629BA
		// (set) Token: 0x0600E675 RID: 58997 RVA: 0x002647C2 File Offset: 0x002629C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PPFJLCCFCOJ
		{
			get
			{
				return this.pPFJLCCFCOJ_;
			}
			set
			{
				this.pPFJLCCFCOJ_ = value;
			}
		}

		// Token: 0x0600E676 RID: 58998 RVA: 0x002647CB File Offset: 0x002629CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGamePickupBulletCsReq);
		}

		// Token: 0x0600E677 RID: 58999 RVA: 0x002647D9 File Offset: 0x002629D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGamePickupBulletCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.PPFJLCCFCOJ, other.PPFJLCCFCOJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E678 RID: 59000 RVA: 0x0026480C File Offset: 0x00262A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pPFJLCCFCOJ_ != null)
			{
				num ^= this.PPFJLCCFCOJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E679 RID: 59001 RVA: 0x00264848 File Offset: 0x00262A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E67A RID: 59002 RVA: 0x00264850 File Offset: 0x00262A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E67B RID: 59003 RVA: 0x00264859 File Offset: 0x00262A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pPFJLCCFCOJ_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PPFJLCCFCOJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E67C RID: 59004 RVA: 0x0026488C File Offset: 0x00262A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pPFJLCCFCOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PPFJLCCFCOJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E67D RID: 59005 RVA: 0x002648CC File Offset: 0x00262ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGamePickupBulletCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pPFJLCCFCOJ_ != null)
			{
				if (this.pPFJLCCFCOJ_ == null)
				{
					this.PPFJLCCFCOJ = new Vector();
				}
				this.PPFJLCCFCOJ.MergeFrom(other.PPFJLCCFCOJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E67E RID: 59006 RVA: 0x00264920 File Offset: 0x00262B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E67F RID: 59007 RVA: 0x0026492C File Offset: 0x00262B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pPFJLCCFCOJ_ == null)
					{
						this.PPFJLCCFCOJ = new Vector();
					}
					input.ReadMessage(this.PPFJLCCFCOJ);
				}
			}
		}

		// Token: 0x04005B76 RID: 23414
		private static readonly MessageParser<WolfBroGamePickupBulletCsReq> _parser = new MessageParser<WolfBroGamePickupBulletCsReq>(() => new WolfBroGamePickupBulletCsReq());

		// Token: 0x04005B77 RID: 23415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B78 RID: 23416
		public const int PPFJLCCFCOJFieldNumber = 1;

		// Token: 0x04005B79 RID: 23417
		private Vector pPFJLCCFCOJ_;
	}
}
