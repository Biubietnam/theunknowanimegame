using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B69 RID: 2921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyReRollRandomScRsp : IMessage<MonopolyReRollRandomScRsp>, IMessage, IEquatable<MonopolyReRollRandomScRsp>, IDeepCloneable<MonopolyReRollRandomScRsp>, IBufferMessage
	{
		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x00154ADB File Offset: 0x00152CDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyReRollRandomScRsp> Parser
		{
			get
			{
				return MonopolyReRollRandomScRsp._parser;
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x06008141 RID: 33089 RVA: 0x00154AE2 File Offset: 0x00152CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyReRollRandomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x06008142 RID: 33090 RVA: 0x00154AF4 File Offset: 0x00152CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyReRollRandomScRsp.Descriptor;
			}
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00154AFB File Offset: 0x00152CFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomScRsp()
		{
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x00154B04 File Offset: 0x00152D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomScRsp(MonopolyReRollRandomScRsp other) : this()
		{
			this.eventId_ = other.eventId_;
			this.retcode_ = other.retcode_;
			this.kLNPKPIMKHJ_ = ((other.kLNPKPIMKHJ_ != null) ? other.kLNPKPIMKHJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x00154B5C File Offset: 0x00152D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyReRollRandomScRsp Clone()
		{
			return new MonopolyReRollRandomScRsp(this);
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x00154B64 File Offset: 0x00152D64
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x00154B6C File Offset: 0x00152D6C
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

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x00154B75 File Offset: 0x00152D75
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x00154B7D File Offset: 0x00152D7D
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

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x00154B86 File Offset: 0x00152D86
		// (set) Token: 0x0600814B RID: 33099 RVA: 0x00154B8E File Offset: 0x00152D8E
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

		// Token: 0x0600814C RID: 33100 RVA: 0x00154B97 File Offset: 0x00152D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyReRollRandomScRsp);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x00154BA8 File Offset: 0x00152DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyReRollRandomScRsp other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.Retcode == other.Retcode && object.Equals(this.KLNPKPIMKHJ, other.KLNPKPIMKHJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x00154C08 File Offset: 0x00152E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
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

		// Token: 0x0600814F RID: 33103 RVA: 0x00154C76 File Offset: 0x00152E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x00154C7E File Offset: 0x00152E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x00154C88 File Offset: 0x00152E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.KLNPKPIMKHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00154D00 File Offset: 0x00152F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
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

		// Token: 0x06008153 RID: 33107 RVA: 0x00154D70 File Offset: 0x00152F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyReRollRandomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
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

		// Token: 0x06008154 RID: 33108 RVA: 0x00154DEC File Offset: 0x00152FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x00154DF8 File Offset: 0x00152FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003159 RID: 12633
		private static readonly MessageParser<MonopolyReRollRandomScRsp> _parser = new MessageParser<MonopolyReRollRandomScRsp>(() => new MonopolyReRollRandomScRsp());

		// Token: 0x0400315A RID: 12634
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400315B RID: 12635
		public const int EventIdFieldNumber = 3;

		// Token: 0x0400315C RID: 12636
		private uint eventId_;

		// Token: 0x0400315D RID: 12637
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400315E RID: 12638
		private uint retcode_;

		// Token: 0x0400315F RID: 12639
		public const int KLNPKPIMKHJFieldNumber = 9;

		// Token: 0x04003160 RID: 12640
		private NFOGHDHIDNH kLNPKPIMKHJ_;
	}
}
