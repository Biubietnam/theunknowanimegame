using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000093 RID: 147
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyShipmentEventEffectsScNotify : IMessage<AlleyShipmentEventEffectsScNotify>, IMessage, IEquatable<AlleyShipmentEventEffectsScNotify>, IDeepCloneable<AlleyShipmentEventEffectsScNotify>, IBufferMessage
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001208D File Offset: 0x0001028D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyShipmentEventEffectsScNotify> Parser
		{
			get
			{
				return AlleyShipmentEventEffectsScNotify._parser;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00012094 File Offset: 0x00010294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyShipmentEventEffectsScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000120A6 File Offset: 0x000102A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyShipmentEventEffectsScNotify.Descriptor;
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000120AD File Offset: 0x000102AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipmentEventEffectsScNotify()
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000120B5 File Offset: 0x000102B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipmentEventEffectsScNotify(AlleyShipmentEventEffectsScNotify other) : this()
		{
			this.cFNAFPDIJDD_ = ((other.cFNAFPDIJDD_ != null) ? other.cFNAFPDIJDD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000120EA File Offset: 0x000102EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyShipmentEventEffectsScNotify Clone()
		{
			return new AlleyShipmentEventEffectsScNotify(this);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000120F2 File Offset: 0x000102F2
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000120FA File Offset: 0x000102FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BNPAEMJJCFG CFNAFPDIJDD
		{
			get
			{
				return this.cFNAFPDIJDD_;
			}
			set
			{
				this.cFNAFPDIJDD_ = value;
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00012103 File Offset: 0x00010303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyShipmentEventEffectsScNotify);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00012111 File Offset: 0x00010311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyShipmentEventEffectsScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CFNAFPDIJDD, other.CFNAFPDIJDD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00012144 File Offset: 0x00010344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cFNAFPDIJDD_ != null)
			{
				num ^= this.CFNAFPDIJDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00012180 File Offset: 0x00010380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00012188 File Offset: 0x00010388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00012191 File Offset: 0x00010391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cFNAFPDIJDD_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.CFNAFPDIJDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000121C4 File Offset: 0x000103C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cFNAFPDIJDD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CFNAFPDIJDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00012204 File Offset: 0x00010404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyShipmentEventEffectsScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cFNAFPDIJDD_ != null)
			{
				if (this.cFNAFPDIJDD_ == null)
				{
					this.CFNAFPDIJDD = new BNPAEMJJCFG();
				}
				this.CFNAFPDIJDD.MergeFrom(other.CFNAFPDIJDD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00012258 File Offset: 0x00010458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00012264 File Offset: 0x00010464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.cFNAFPDIJDD_ == null)
					{
						this.CFNAFPDIJDD = new BNPAEMJJCFG();
					}
					input.ReadMessage(this.CFNAFPDIJDD);
				}
			}
		}

		// Token: 0x0400025B RID: 603
		private static readonly MessageParser<AlleyShipmentEventEffectsScNotify> _parser = new MessageParser<AlleyShipmentEventEffectsScNotify>(() => new AlleyShipmentEventEffectsScNotify());

		// Token: 0x0400025C RID: 604
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400025D RID: 605
		public const int CFNAFPDIJDDFieldNumber = 3;

		// Token: 0x0400025E RID: 606
		private BNPAEMJJCFG cFNAFPDIJDD_;
	}
}
