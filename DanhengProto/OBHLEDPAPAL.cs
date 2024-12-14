using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C43 RID: 3139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OBHLEDPAPAL : IMessage<OBHLEDPAPAL>, IMessage, IEquatable<OBHLEDPAPAL>, IDeepCloneable<OBHLEDPAPAL>, IBufferMessage
	{
		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06008B33 RID: 35635 RVA: 0x0016FBF8 File Offset: 0x0016DDF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OBHLEDPAPAL> Parser
		{
			get
			{
				return OBHLEDPAPAL._parser;
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06008B34 RID: 35636 RVA: 0x0016FBFF File Offset: 0x0016DDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OBHLEDPAPALReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06008B35 RID: 35637 RVA: 0x0016FC11 File Offset: 0x0016DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OBHLEDPAPAL.Descriptor;
			}
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x0016FC18 File Offset: 0x0016DE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBHLEDPAPAL()
		{
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x0016FC20 File Offset: 0x0016DE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBHLEDPAPAL(OBHLEDPAPAL other) : this()
		{
			this.eNEAGDHNCGI_ = other.eNEAGDHNCGI_;
			this.level_ = other.level_;
			this.queuePosition_ = other.queuePosition_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x0016FC5D File Offset: 0x0016DE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OBHLEDPAPAL Clone()
		{
			return new OBHLEDPAPAL(this);
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06008B39 RID: 35641 RVA: 0x0016FC65 File Offset: 0x0016DE65
		// (set) Token: 0x06008B3A RID: 35642 RVA: 0x0016FC6D File Offset: 0x0016DE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ENEAGDHNCGI
		{
			get
			{
				return this.eNEAGDHNCGI_;
			}
			set
			{
				this.eNEAGDHNCGI_ = value;
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06008B3B RID: 35643 RVA: 0x0016FC76 File Offset: 0x0016DE76
		// (set) Token: 0x06008B3C RID: 35644 RVA: 0x0016FC7E File Offset: 0x0016DE7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x0016FC87 File Offset: 0x0016DE87
		// (set) Token: 0x06008B3E RID: 35646 RVA: 0x0016FC8F File Offset: 0x0016DE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QueuePosition
		{
			get
			{
				return this.queuePosition_;
			}
			set
			{
				this.queuePosition_ = value;
			}
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x0016FC98 File Offset: 0x0016DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OBHLEDPAPAL);
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x0016FCA8 File Offset: 0x0016DEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OBHLEDPAPAL other)
		{
			return other != null && (other == this || (this.ENEAGDHNCGI == other.ENEAGDHNCGI && this.Level == other.Level && this.QueuePosition == other.QueuePosition && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x0016FD04 File Offset: 0x0016DF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ENEAGDHNCGI != 0U)
			{
				num ^= this.ENEAGDHNCGI.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.QueuePosition != 0U)
			{
				num ^= this.QueuePosition.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x0016FD75 File Offset: 0x0016DF75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x0016FD7D File Offset: 0x0016DF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x0016FD88 File Offset: 0x0016DF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QueuePosition != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.QueuePosition);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Level);
			}
			if (this.ENEAGDHNCGI != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.ENEAGDHNCGI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x0016FE00 File Offset: 0x0016E000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ENEAGDHNCGI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ENEAGDHNCGI);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.QueuePosition != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QueuePosition);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x0016FE70 File Offset: 0x0016E070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OBHLEDPAPAL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ENEAGDHNCGI != 0U)
			{
				this.ENEAGDHNCGI = other.ENEAGDHNCGI;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.QueuePosition != 0U)
			{
				this.QueuePosition = other.QueuePosition;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x0016FED4 File Offset: 0x0016E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B48 RID: 35656 RVA: 0x0016FEE0 File Offset: 0x0016E0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 32U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ENEAGDHNCGI = input.ReadUInt32();
						}
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.QueuePosition = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003569 RID: 13673
		private static readonly MessageParser<OBHLEDPAPAL> _parser = new MessageParser<OBHLEDPAPAL>(() => new OBHLEDPAPAL());

		// Token: 0x0400356A RID: 13674
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400356B RID: 13675
		public const int ENEAGDHNCGIFieldNumber = 13;

		// Token: 0x0400356C RID: 13676
		private uint eNEAGDHNCGI_;

		// Token: 0x0400356D RID: 13677
		public const int LevelFieldNumber = 4;

		// Token: 0x0400356E RID: 13678
		private uint level_;

		// Token: 0x0400356F RID: 13679
		public const int QueuePositionFieldNumber = 3;

		// Token: 0x04003570 RID: 13680
		private uint queuePosition_;
	}
}
