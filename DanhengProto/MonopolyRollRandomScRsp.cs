using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B71 RID: 2929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyRollRandomScRsp : IMessage<MonopolyRollRandomScRsp>, IMessage, IEquatable<MonopolyRollRandomScRsp>, IDeepCloneable<MonopolyRollRandomScRsp>, IBufferMessage
	{
		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06008198 RID: 33176 RVA: 0x0015568B File Offset: 0x0015388B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyRollRandomScRsp> Parser
		{
			get
			{
				return MonopolyRollRandomScRsp._parser;
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x06008199 RID: 33177 RVA: 0x00155692 File Offset: 0x00153892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyRollRandomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x0600819A RID: 33178 RVA: 0x001556A4 File Offset: 0x001538A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyRollRandomScRsp.Descriptor;
			}
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x001556AB File Offset: 0x001538AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomScRsp()
		{
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x001556B4 File Offset: 0x001538B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomScRsp(MonopolyRollRandomScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eventId_ = other.eventId_;
			this.kLNPKPIMKHJ_ = ((other.kLNPKPIMKHJ_ != null) ? other.kLNPKPIMKHJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x0015570C File Offset: 0x0015390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyRollRandomScRsp Clone()
		{
			return new MonopolyRollRandomScRsp(this);
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600819E RID: 33182 RVA: 0x00155714 File Offset: 0x00153914
		// (set) Token: 0x0600819F RID: 33183 RVA: 0x0015571C File Offset: 0x0015391C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x060081A0 RID: 33184 RVA: 0x00155725 File Offset: 0x00153925
		// (set) Token: 0x060081A1 RID: 33185 RVA: 0x0015572D File Offset: 0x0015392D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x060081A2 RID: 33186 RVA: 0x00155736 File Offset: 0x00153936
		// (set) Token: 0x060081A3 RID: 33187 RVA: 0x0015573E File Offset: 0x0015393E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH KLNPKPIMKHJ
		{
			get
			{
				return this.kLNPKPIMKHJ_;
			}
			set
			{
				this.kLNPKPIMKHJ_ = value;
			}
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00155747 File Offset: 0x00153947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyRollRandomScRsp);
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x00155758 File Offset: 0x00153958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyRollRandomScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.EventId == other.EventId && object.Equals(this.KLNPKPIMKHJ, other.KLNPKPIMKHJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x001557B8 File Offset: 0x001539B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num ^= this.KLNPKPIMKHJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x00155826 File Offset: 0x00153A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x0015582E File Offset: 0x00153A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x00155838 File Offset: 0x00153A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.kLNPKPIMKHJ_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.KLNPKPIMKHJ);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x001558B0 File Offset: 0x00153AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KLNPKPIMKHJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x00155920 File Offset: 0x00153B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyRollRandomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.kLNPKPIMKHJ_ != null)
			{
				if (this.kLNPKPIMKHJ_ == null)
				{
					this.KLNPKPIMKHJ = new NFOGHDHIDNH();
				}
				this.KLNPKPIMKHJ.MergeFrom(other.KLNPKPIMKHJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x0015599C File Offset: 0x00153B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x001559A8 File Offset: 0x00153BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EventId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.kLNPKPIMKHJ_ == null)
					{
						this.KLNPKPIMKHJ = new NFOGHDHIDNH();
					}
					input.ReadMessage(this.KLNPKPIMKHJ);
				}
			}
		}

		// Token: 0x04003171 RID: 12657
		private static readonly MessageParser<MonopolyRollRandomScRsp> _parser = new MessageParser<MonopolyRollRandomScRsp>(() => new MonopolyRollRandomScRsp());

		// Token: 0x04003172 RID: 12658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003173 RID: 12659
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04003174 RID: 12660
		private uint retcode_;

		// Token: 0x04003175 RID: 12661
		public const int EventIdFieldNumber = 12;

		// Token: 0x04003176 RID: 12662
		private uint eventId_;

		// Token: 0x04003177 RID: 12663
		public const int KLNPKPIMKHJFieldNumber = 6;

		// Token: 0x04003178 RID: 12664
		private NFOGHDHIDNH kLNPKPIMKHJ_;
	}
}
