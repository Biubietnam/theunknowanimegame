using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011FF RID: 4607
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SubmitOfferingItemCsReq : IMessage<SubmitOfferingItemCsReq>, IMessage, IEquatable<SubmitOfferingItemCsReq>, IDeepCloneable<SubmitOfferingItemCsReq>, IBufferMessage
	{
		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600CDE9 RID: 52713 RVA: 0x002288D5 File Offset: 0x00226AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SubmitOfferingItemCsReq> Parser
		{
			get
			{
				return SubmitOfferingItemCsReq._parser;
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x002288DC File Offset: 0x00226ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SubmitOfferingItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600CDEB RID: 52715 RVA: 0x002288EE File Offset: 0x00226AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitOfferingItemCsReq.Descriptor;
			}
		}

		// Token: 0x0600CDEC RID: 52716 RVA: 0x002288F5 File Offset: 0x00226AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemCsReq()
		{
		}

		// Token: 0x0600CDED RID: 52717 RVA: 0x002288FD File Offset: 0x00226AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemCsReq(SubmitOfferingItemCsReq other) : this()
		{
			this.bGKKLJMJGOF_ = other.bGKKLJMJGOF_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CDEE RID: 52718 RVA: 0x0022892E File Offset: 0x00226B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitOfferingItemCsReq Clone()
		{
			return new SubmitOfferingItemCsReq(this);
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600CDEF RID: 52719 RVA: 0x00228936 File Offset: 0x00226B36
		// (set) Token: 0x0600CDF0 RID: 52720 RVA: 0x0022893E File Offset: 0x00226B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BGKKLJMJGOF
		{
			get
			{
				return this.bGKKLJMJGOF_;
			}
			set
			{
				this.bGKKLJMJGOF_ = value;
			}
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600CDF1 RID: 52721 RVA: 0x00228947 File Offset: 0x00226B47
		// (set) Token: 0x0600CDF2 RID: 52722 RVA: 0x0022894F File Offset: 0x00226B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x0600CDF3 RID: 52723 RVA: 0x00228958 File Offset: 0x00226B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitOfferingItemCsReq);
		}

		// Token: 0x0600CDF4 RID: 52724 RVA: 0x00228966 File Offset: 0x00226B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitOfferingItemCsReq other)
		{
			return other != null && (other == this || (this.BGKKLJMJGOF == other.BGKKLJMJGOF && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDF5 RID: 52725 RVA: 0x002289A4 File Offset: 0x00226BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BGKKLJMJGOF != 0U)
			{
				num ^= this.BGKKLJMJGOF.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDF6 RID: 52726 RVA: 0x002289FC File Offset: 0x00226BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CDF7 RID: 52727 RVA: 0x00228A04 File Offset: 0x00226C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDF8 RID: 52728 RVA: 0x00228A10 File Offset: 0x00226C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this.BGKKLJMJGOF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BGKKLJMJGOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDF9 RID: 52729 RVA: 0x00228A6C File Offset: 0x00226C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BGKKLJMJGOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BGKKLJMJGOF);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDFA RID: 52730 RVA: 0x00228AC4 File Offset: 0x00226CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitOfferingItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BGKKLJMJGOF != 0U)
			{
				this.BGKKLJMJGOF = other.BGKKLJMJGOF;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDFB RID: 52731 RVA: 0x00228B14 File Offset: 0x00226D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDFC RID: 52732 RVA: 0x00228B20 File Offset: 0x00226D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BGKKLJMJGOF = input.ReadUInt32();
					}
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040052FF RID: 21247
		private static readonly MessageParser<SubmitOfferingItemCsReq> _parser = new MessageParser<SubmitOfferingItemCsReq>(() => new SubmitOfferingItemCsReq());

		// Token: 0x04005300 RID: 21248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005301 RID: 21249
		public const int BGKKLJMJGOFFieldNumber = 12;

		// Token: 0x04005302 RID: 21250
		private uint bGKKLJMJGOF_;

		// Token: 0x04005303 RID: 21251
		public const int InteractedPropEntityIdFieldNumber = 4;

		// Token: 0x04005304 RID: 21252
		private uint interactedPropEntityId_;
	}
}
