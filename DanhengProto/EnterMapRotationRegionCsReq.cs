using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200044F RID: 1103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterMapRotationRegionCsReq : IMessage<EnterMapRotationRegionCsReq>, IMessage, IEquatable<EnterMapRotationRegionCsReq>, IDeepCloneable<EnterMapRotationRegionCsReq>, IBufferMessage
	{
		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x00086CF3 File Offset: 0x00084EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterMapRotationRegionCsReq> Parser
		{
			get
			{
				return EnterMapRotationRegionCsReq._parser;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x00086CFA File Offset: 0x00084EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterMapRotationRegionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x00086D0C File Offset: 0x00084F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterMapRotationRegionCsReq.Descriptor;
			}
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00086D13 File Offset: 0x00084F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionCsReq()
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00086D1C File Offset: 0x00084F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionCsReq(EnterMapRotationRegionCsReq other) : this()
		{
			this.iPFOFHHKJKP_ = other.iPFOFHHKJKP_;
			this.motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
			this.cHJMODIMLDA_ = other.cHJMODIMLDA_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00086D74 File Offset: 0x00084F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterMapRotationRegionCsReq Clone()
		{
			return new EnterMapRotationRegionCsReq(this);
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x00086D7C File Offset: 0x00084F7C
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x00086D84 File Offset: 0x00084F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IPFOFHHKJKP
		{
			get
			{
				return this.iPFOFHHKJKP_;
			}
			set
			{
				this.iPFOFHHKJKP_ = value;
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x00086D8D File Offset: 0x00084F8D
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x00086D95 File Offset: 0x00084F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotionInfo Motion
		{
			get
			{
				return this.motion_;
			}
			set
			{
				this.motion_ = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x00086D9E File Offset: 0x00084F9E
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x00086DA6 File Offset: 0x00084FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CHJMODIMLDA
		{
			get
			{
				return this.cHJMODIMLDA_;
			}
			set
			{
				this.cHJMODIMLDA_ = value;
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00086DAF File Offset: 0x00084FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterMapRotationRegionCsReq);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x00086DC0 File Offset: 0x00084FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterMapRotationRegionCsReq other)
		{
			return other != null && (other == this || (this.IPFOFHHKJKP == other.IPFOFHHKJKP && object.Equals(this.Motion, other.Motion) && this.CHJMODIMLDA == other.CHJMODIMLDA && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00086E20 File Offset: 0x00085020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IPFOFHHKJKP != 0U)
			{
				num ^= this.IPFOFHHKJKP.GetHashCode();
			}
			if (this.motion_ != null)
			{
				num ^= this.Motion.GetHashCode();
			}
			if (this.CHJMODIMLDA != 0U)
			{
				num ^= this.CHJMODIMLDA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00086E8E File Offset: 0x0008508E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x00086E96 File Offset: 0x00085096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00086EA0 File Offset: 0x000850A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.motion_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Motion);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CHJMODIMLDA);
			}
			if (this.IPFOFHHKJKP != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IPFOFHHKJKP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00086F18 File Offset: 0x00085118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IPFOFHHKJKP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IPFOFHHKJKP);
			}
			if (this.motion_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Motion);
			}
			if (this.CHJMODIMLDA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CHJMODIMLDA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00086F88 File Offset: 0x00085188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterMapRotationRegionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IPFOFHHKJKP != 0U)
			{
				this.IPFOFHHKJKP = other.IPFOFHHKJKP;
			}
			if (other.motion_ != null)
			{
				if (this.motion_ == null)
				{
					this.Motion = new MotionInfo();
				}
				this.Motion.MergeFrom(other.Motion);
			}
			if (other.CHJMODIMLDA != 0U)
			{
				this.CHJMODIMLDA = other.CHJMODIMLDA;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00087004 File Offset: 0x00085204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00087010 File Offset: 0x00085210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 32U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IPFOFHHKJKP = input.ReadUInt32();
						}
					}
					else
					{
						this.CHJMODIMLDA = input.ReadUInt32();
					}
				}
				else
				{
					if (this.motion_ == null)
					{
						this.Motion = new MotionInfo();
					}
					input.ReadMessage(this.Motion);
				}
			}
		}

		// Token: 0x04001388 RID: 5000
		private static readonly MessageParser<EnterMapRotationRegionCsReq> _parser = new MessageParser<EnterMapRotationRegionCsReq>(() => new EnterMapRotationRegionCsReq());

		// Token: 0x04001389 RID: 5001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400138A RID: 5002
		public const int IPFOFHHKJKPFieldNumber = 7;

		// Token: 0x0400138B RID: 5003
		private uint iPFOFHHKJKP_;

		// Token: 0x0400138C RID: 5004
		public const int MotionFieldNumber = 1;

		// Token: 0x0400138D RID: 5005
		private MotionInfo motion_;

		// Token: 0x0400138E RID: 5006
		public const int CHJMODIMLDAFieldNumber = 4;

		// Token: 0x0400138F RID: 5007
		private uint cHJMODIMLDA_;
	}
}
